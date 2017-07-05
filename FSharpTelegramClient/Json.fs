namespace Shkoda.Telegram.Client
module Json  =
    open FSharp.Data
    open System

    type JsonSchema = JsonProvider<"../data/schema.json">

    let coreSchemaUrl = "https://core.telegram.org/schema/json"
    let endToEndchemaUrl = "https://core.telegram.org/schema/end-to-end-json"
       
    let loadSchema (url: string) = JsonSchema.Load(url)
    let loadConstructors ([<ParamArray>] urls) = 
        urls |> Array.map loadSchema |> Array.map (fun s -> s.Constructors) |> Array.concat
    let loadAllKnownConstructors = loadConstructors ([|coreSchemaUrl; endToEndchemaUrl|])       

    let withoutDots (s: string) = s.Replace(".", "_")
    let containsSpaces (s: string) = s.Contains(" ")
    let toStringValueOrEmpty (x: option<'a>) toString = if (x.IsSome) then (toString x.Value) else ""
    let firstCharToUpper (str:string) = 
            //todo hndle empty
            let u = str.Substring(0,1).ToUpper
            match str with
            | "" -> ""
            | _ -> sprintf "%s%s"  ((str.Substring(0,1)).ToUpper()) (str.Substring(1, str.Length - 1))
    
    type ParamType = 
    | Bool
    | Int 
    | Long 
    | String 
    | Bytes 
    | Double
    | Vector of ParamType
    | TypeName of string
    | GenericArray of string
    
     static member FromString (rawTypeName : string) =
            let VectorType (pt:string) =
                pt.Replace("Vector<", "").Replace(">", "") |> ParamType.FromString             
                
            match rawTypeName with
            | "int" -> ParamType.Int
            | "long" -> ParamType.Long
            | "string" -> ParamType.String
            | "bytes" -> ParamType.Bytes
            | "double" -> ParamType.Double
            | txt when txt.StartsWith("Vector") -> ParamType.Vector (VectorType txt)
            | txt when txt.Contains "flag" -> ParamType.Bool
            | _ -> ParamType.TypeName (withoutDots rawTypeName)
            
     member this.ToString = 
         let rec toString (p:ParamType) = 
                match p with
                | Bool -> "bool"
                | Int -> "int"
                | Long -> "int64"
                | Double -> "double"
                | Bytes -> "byte[]"
                | String -> "string"
                | Vector smth -> sprintf "Vector<%s>" (toString smth)
                | GenericArray t -> sprintf "%s[]" t
                | TypeName t -> t
         toString this 
    
    type ConstructorParam (name:string, paramType:ParamType) =                       
        static member ToParam (typeName:string) (fieldName:string) = 
            let parsedType = match fieldName with
                                |"flags" -> ParamType.Int 
                                |_ -> ParamType.FromString typeName
            new ConstructorParam(fieldName, parsedType)
            
        member this.RequiredType  = 
            let rec requiredType paramType = 
                match paramType  with
                | Int | Long | String | Bytes | Double | Bool | GenericArray _ -> None
                | Vector smth -> requiredType smth
                | TypeName n -> n |> Some
            requiredType paramType      
        
        member this.ToString = sprintf "%s : %s" name paramType.ToString

    
    type ConstructorDefinition (id:int, predicate:string, typeName:string, layer:int option, constructorParams:ConstructorParam list) =
        let genericArrayParam genericParamTypeName= new ConstructorParam("elements", ParamType.GenericArray genericParamTypeName)
        
        member this.TypeValue = typeName
        member this.TypeName isSingleImplementation = 
            let isGeneric = containsSpaces typeName
            let genericType () = (typeName.Split(' ').[0])
            let genericParamType () = (typeName.Split(' ').[1])
            let withLayer name = 
                let layerSuffix = toStringValueOrEmpty layer (sprintf "_%i")              
                sprintf "%s%s" name layerSuffix           
            match isSingleImplementation with
            |true -> if isGeneric then (sprintf "%s<'%s>" (genericType()) (genericParamType())) else typeName
            |false -> withLayer predicate
            
        member this.ToString isSingleImplementation = 
            let typeDefinition = sprintf "\ttype %s = \n" (this.TypeName isSingleImplementation)
            let paramDefinition = 
                match List.length constructorParams with
                |0 -> ""
                |_ -> constructorParams |> List.map (fun c -> c.ToString) |> String.concat "; " |> sprintf "\t\t{%s} with\n"
                
            let constructorDefinition = sprintf "\t\tmember this.Constructor = %i\n" id
            let layerDefinition = toStringValueOrEmpty layer (sprintf "\t\tmember this.Layer = %i\n")  
                 
            typeDefinition + constructorDefinition + layerDefinition
        member this.ToStringAsUnionElement =        
             let elementType = this.TypeName false
             sprintf "|%s of %s " (firstCharToUpper elementType) elementType

        member this.RequiredTypes = constructorParams |> Seq.choose (fun (p:ConstructorParam) -> p.RequiredType) |> Seq.distinct                
    
    type RecordDefinition (typeName: string, children: ConstructorDefinition list) = 
        member this.TypeName = typeName
        member this.RequiredTypes = children |> Seq.collect (fun c -> c.RequiredTypes) |> Seq.distinct 
        member this.ToString = 
            let unionString  = 
                let elements = children |> Seq.map (fun c -> (c.ToStringAsUnionElement)) |> String.concat "\n\t\t"
                sprintf "\ttype %s = \n\t\t%s\n" typeName elements
            let constructorsAndUnion =                  
                let constructors = children |> Seq.map (fun c -> c.ToString false) |> String.concat "\n"        
                sprintf "%s\n%s" constructors unionString
            match children.Length with
                | 1 -> (children.[0].ToString true)
                | _ -> constructorsAndUnion 
   
    let records =        
        let parseConstructor (raw : JsonSchema.Constructor) = 
            let parseConstructorParams (p: JsonSchema.Param[]) = 
                p |> Seq.map (fun p -> ConstructorParam.ToParam p.Type p.Name) |> Seq.toList
            new ConstructorDefinition(raw.Id, withoutDots raw.Predicate, withoutDots raw.Type, raw.Layer, parseConstructorParams raw.Params)  
            
        loadAllKnownConstructors 
        |> Seq.map parseConstructor  
        |> Seq.groupBy (fun c -> c.TypeValue)
        |> Seq.map (fun (k, v) -> new RecordDefinition( k, Seq.toList v))
   
     
    let sorted (src:RecordDefinition[]) =
        let rec sorted (source:RecordDefinition[]) (result:RecordDefinition[]) = 
            let knownTypes = result |> Array.map (fun r -> r.TypeName) |> Array.distinct
            let areAllTypesAlreadyKnown (record: RecordDefinition) = 
                record.RequiredTypes |> Seq.forall (fun t -> Seq.contains t knownTypes)                                  

            let readyRecords  = source |> Array.filter areAllTypesAlreadyKnown 
            let notReadyRecords  = source |> Array.filter (fun r -> not (areAllTypesAlreadyKnown(r)))
                                  
            match (Seq.length source) with
            |0 -> result
            |_ -> sorted notReadyRecords (Array.append result readyRecords) 
            
        sorted src Array.empty<RecordDefinition> 

    
    let toStringAll (records : RecordDefinition[]) = 
         let r = records |> Array.map (fun r -> r.ToString) |> String.concat "\n"
         let txt = sprintf "namespace Shkoda.Telegram.Client\nmodule GeneratedTypes = \n%s" r
         (txt.Replace("\t", "    "))
    
  
