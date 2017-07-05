namespace Shkoda.Telegram.Client
module GeneratedTypes = 
    type boolFalse = 
        member this.Constructor = -1132882121

    type boolTrue = 
        member this.Constructor = -1720552011

    type Bool = 
        |BoolFalse of boolFalse 
        |BoolTrue of boolTrue 

    type True = 
        member this.Constructor = 1072550713

    type Vector<'t> = 
        member this.Constructor = 481674261

    type Error = 
        member this.Constructor = -994444869

    type Null = 
        member this.Constructor = 1450380236

    type inputPeerEmpty = 
        member this.Constructor = 2134579434

    type inputPeerSelf = 
        member this.Constructor = 2107670217

    type inputPeerContact = 
        member this.Constructor = 270785512

    type inputPeerForeign = 
        member this.Constructor = -1690012891

    type inputPeerChat = 
        member this.Constructor = 396093539

    type InputPeer = 
        |InputPeerEmpty of inputPeerEmpty 
        |InputPeerSelf of inputPeerSelf 
        |InputPeerContact of inputPeerContact 
        |InputPeerForeign of inputPeerForeign 
        |InputPeerChat of inputPeerChat 

    type inputUserEmpty = 
        member this.Constructor = -1182234929

    type inputUserSelf = 
        member this.Constructor = -138301121

    type inputUserContact = 
        member this.Constructor = -2031530139

    type inputUserForeign = 
        member this.Constructor = 1700689151

    type InputUser = 
        |InputUserEmpty of inputUserEmpty 
        |InputUserSelf of inputUserSelf 
        |InputUserContact of inputUserContact 
        |InputUserForeign of inputUserForeign 

    type InputContact = 
        member this.Constructor = -208488460

    type inputFile = 
        member this.Constructor = -181407105

    type inputFileBig = 
        member this.Constructor = -95482955

    type InputFile = 
        |InputFile of inputFile 
        |InputFileBig of inputFileBig 

    type inputGeoPointEmpty = 
        member this.Constructor = -457104426

    type inputGeoPoint = 
        member this.Constructor = -206066487

    type InputGeoPoint = 
        |InputGeoPointEmpty of inputGeoPointEmpty 
        |InputGeoPoint of inputGeoPoint 

    type inputPhotoEmpty = 
        member this.Constructor = 483901197

    type inputPhoto = 
        member this.Constructor = -74070332

    type InputPhoto = 
        |InputPhotoEmpty of inputPhotoEmpty 
        |InputPhoto of inputPhoto 

    type inputVideoEmpty = 
        member this.Constructor = 1426648181

    type inputVideo = 
        member this.Constructor = -296249774

    type InputVideo = 
        |InputVideoEmpty of inputVideoEmpty 
        |InputVideo of inputVideo 

    type inputFileLocation = 
        member this.Constructor = 342061462

    type inputVideoFileLocation = 
        member this.Constructor = 1023632620

    type inputEncryptedFileLocation = 
        member this.Constructor = -182231723

    type inputAudioFileLocation = 
        member this.Constructor = 1960591437

    type inputDocumentFileLocation = 
        member this.Constructor = 1313188841

    type InputFileLocation = 
        |InputFileLocation of inputFileLocation 
        |InputVideoFileLocation of inputVideoFileLocation 
        |InputEncryptedFileLocation of inputEncryptedFileLocation 
        |InputAudioFileLocation of inputAudioFileLocation 
        |InputDocumentFileLocation of inputDocumentFileLocation 

    type inputPhotoCropAuto = 
        member this.Constructor = -1377390588

    type inputPhotoCrop = 
        member this.Constructor = -644787419

    type InputPhotoCrop = 
        |InputPhotoCropAuto of inputPhotoCropAuto 
        |InputPhotoCrop of inputPhotoCrop 

    type InputAppEvent = 
        member this.Constructor = 1996904104

    type peerUser = 
        member this.Constructor = -1649296275

    type peerChat = 
        member this.Constructor = -1160714821

    type Peer = 
        |PeerUser of peerUser 
        |PeerChat of peerChat 

    type storage_fileUnknown = 
        member this.Constructor = -1432995067

    type storage_filePartial = 
        member this.Constructor = 1086091090

    type storage_fileJpeg = 
        member this.Constructor = 8322574

    type storage_fileGif = 
        member this.Constructor = -891180321

    type storage_filePng = 
        member this.Constructor = 172975040

    type storage_filePdf = 
        member this.Constructor = -1373745011

    type storage_fileMp3 = 
        member this.Constructor = 1384777335

    type storage_fileMov = 
        member this.Constructor = 1258941372

    type storage_fileMp4 = 
        member this.Constructor = -1278304028

    type storage_fileWebp = 
        member this.Constructor = 276907596

    type storage_FileType = 
        |Storage_fileUnknown of storage_fileUnknown 
        |Storage_filePartial of storage_filePartial 
        |Storage_fileJpeg of storage_fileJpeg 
        |Storage_fileGif of storage_fileGif 
        |Storage_filePng of storage_filePng 
        |Storage_filePdf of storage_filePdf 
        |Storage_fileMp3 of storage_fileMp3 
        |Storage_fileMov of storage_fileMov 
        |Storage_fileMp4 of storage_fileMp4 
        |Storage_fileWebp of storage_fileWebp 

    type fileLocationUnavailable = 
        member this.Constructor = 2086234950

    type fileLocation = 
        member this.Constructor = 1406570614

    type fileLocationUnavailable_23 = 
        member this.Constructor = 2086234950
        member this.Layer = 23

    type fileLocation_23 = 
        member this.Constructor = 1406570614
        member this.Layer = 23

    type FileLocation = 
        |FileLocationUnavailable of fileLocationUnavailable 
        |FileLocation of fileLocation 
        |FileLocationUnavailable_23 of fileLocationUnavailable_23 
        |FileLocation_23 of fileLocation_23 

    type userStatusEmpty = 
        member this.Constructor = 164646985

    type userStatusOnline = 
        member this.Constructor = -306628279

    type userStatusOffline = 
        member this.Constructor = 9203775

    type userStatusRecently = 
        member this.Constructor = -496024847

    type userStatusLastWeek = 
        member this.Constructor = 129960444

    type userStatusLastMonth = 
        member this.Constructor = 2011940674

    type UserStatus = 
        |UserStatusEmpty of userStatusEmpty 
        |UserStatusOnline of userStatusOnline 
        |UserStatusOffline of userStatusOffline 
        |UserStatusRecently of userStatusRecently 
        |UserStatusLastWeek of userStatusLastWeek 
        |UserStatusLastMonth of userStatusLastMonth 

    type ChatParticipant = 
        member this.Constructor = -925415106

    type geoPointEmpty = 
        member this.Constructor = 286776671

    type geoPoint = 
        member this.Constructor = 541710092

    type GeoPoint = 
        |GeoPointEmpty of geoPointEmpty 
        |GeoPoint of geoPoint 

    type auth_ExportedAuthorization = 
        member this.Constructor = -543777747

    type inputPeerNotifyEventsEmpty = 
        member this.Constructor = -265263912

    type inputPeerNotifyEventsAll = 
        member this.Constructor = -395694988

    type InputPeerNotifyEvents = 
        |InputPeerNotifyEventsEmpty of inputPeerNotifyEventsEmpty 
        |InputPeerNotifyEventsAll of inputPeerNotifyEventsAll 

    type peerNotifyEventsEmpty = 
        member this.Constructor = -1378534221

    type peerNotifyEventsAll = 
        member this.Constructor = 1830677896

    type PeerNotifyEvents = 
        |PeerNotifyEventsEmpty of peerNotifyEventsEmpty 
        |PeerNotifyEventsAll of peerNotifyEventsAll 

    type PeerSettings = 
        member this.Constructor = -2122045747

    type inputReportReasonSpam = 
        member this.Constructor = 1490799288

    type inputReportReasonViolence = 
        member this.Constructor = 505595789

    type inputReportReasonPornography = 
        member this.Constructor = 777640226

    type inputReportReasonOther = 
        member this.Constructor = -512463606

    type ReportReason = 
        |InputReportReasonSpam of inputReportReasonSpam 
        |InputReportReasonViolence of inputReportReasonViolence 
        |InputReportReasonPornography of inputReportReasonPornography 
        |InputReportReasonOther of inputReportReasonOther 

    type ImportedContact = 
        member this.Constructor = -805141448

    type ContactBlocked = 
        member this.Constructor = 1444661369

    type messages_AffectedHistory = 
        member this.Constructor = -1210173710

    type inputMessagesFilterEmpty = 
        member this.Constructor = 1474492012

    type inputMessagesFilterPhotos = 
        member this.Constructor = -1777752804

    type inputMessagesFilterVideo = 
        member this.Constructor = -1614803355

    type inputMessagesFilterPhotoVideo = 
        member this.Constructor = 1458172132

    type inputMessagesFilterPhotoVideoDocuments = 
        member this.Constructor = -648121413

    type inputMessagesFilterDocument = 
        member this.Constructor = -1629621880

    type inputMessagesFilterAudio = 
        member this.Constructor = -808946398

    type inputMessagesFilterAudioDocuments = 
        member this.Constructor = 1526462308

    type inputMessagesFilterUrl = 
        member this.Constructor = 2129714567

    type inputMessagesFilterGif = 
        member this.Constructor = -3644025

    type MessagesFilter = 
        |InputMessagesFilterEmpty of inputMessagesFilterEmpty 
        |InputMessagesFilterPhotos of inputMessagesFilterPhotos 
        |InputMessagesFilterVideo of inputMessagesFilterVideo 
        |InputMessagesFilterPhotoVideo of inputMessagesFilterPhotoVideo 
        |InputMessagesFilterPhotoVideoDocuments of inputMessagesFilterPhotoVideoDocuments 
        |InputMessagesFilterDocument of inputMessagesFilterDocument 
        |InputMessagesFilterAudio of inputMessagesFilterAudio 
        |InputMessagesFilterAudioDocuments of inputMessagesFilterAudioDocuments 
        |InputMessagesFilterUrl of inputMessagesFilterUrl 
        |InputMessagesFilterGif of inputMessagesFilterGif 

    type updates_State = 
        member this.Constructor = -1519637954

    type DcOption = 
        member this.Constructor = 784507964

    type NearestDc = 
        member this.Constructor = -1910892683

    type help_InviteText = 
        member this.Constructor = 415997816

    type encryptedChatEmpty = 
        member this.Constructor = -1417756512

    type encryptedChatWaiting = 
        member this.Constructor = 1006044124

    type encryptedChatRequested = 
        member this.Constructor = -931638658

    type encryptedChat = 
        member this.Constructor = -94974410

    type encryptedChatDiscarded = 
        member this.Constructor = 332848423

    type EncryptedChat = 
        |EncryptedChatEmpty of encryptedChatEmpty 
        |EncryptedChatWaiting of encryptedChatWaiting 
        |EncryptedChatRequested of encryptedChatRequested 
        |EncryptedChat of encryptedChat 
        |EncryptedChatDiscarded of encryptedChatDiscarded 

    type InputEncryptedChat = 
        member this.Constructor = -247351839

    type encryptedFileEmpty = 
        member this.Constructor = -1038136962

    type encryptedFile = 
        member this.Constructor = 1248893260

    type EncryptedFile = 
        |EncryptedFileEmpty of encryptedFileEmpty 
        |EncryptedFile of encryptedFile 

    type inputEncryptedFileEmpty = 
        member this.Constructor = 406307684

    type inputEncryptedFileUploaded = 
        member this.Constructor = 1690108678

    type inputEncryptedFile = 
        member this.Constructor = 1511503333

    type inputEncryptedFileBigUploaded = 
        member this.Constructor = 767652808

    type InputEncryptedFile = 
        |InputEncryptedFileEmpty of inputEncryptedFileEmpty 
        |InputEncryptedFileUploaded of inputEncryptedFileUploaded 
        |InputEncryptedFile of inputEncryptedFile 
        |InputEncryptedFileBigUploaded of inputEncryptedFileBigUploaded 

    type messages_dhConfigNotModified = 
        member this.Constructor = -1058912715

    type messages_dhConfig = 
        member this.Constructor = 740433629

    type messages_DhConfig = 
        |Messages_dhConfigNotModified of messages_dhConfigNotModified 
        |Messages_dhConfig of messages_dhConfig 

    type inputAudioEmpty = 
        member this.Constructor = -648356732

    type inputAudio = 
        member this.Constructor = 2010398975

    type InputAudio = 
        |InputAudioEmpty of inputAudioEmpty 
        |InputAudio of inputAudio 

    type inputDocumentEmpty = 
        member this.Constructor = 1928391342

    type inputDocument = 
        member this.Constructor = 410618194

    type InputDocument = 
        |InputDocumentEmpty of inputDocumentEmpty 
        |InputDocument of inputDocument 

    type audioEmpty = 
        member this.Constructor = 1483311320

    type audio = 
        member this.Constructor = -945003370

    type Audio = 
        |AudioEmpty of audioEmpty 
        |Audio of audio 

    type sendMessageTypingAction = 
        member this.Constructor = 381645902

    type sendMessageCancelAction = 
        member this.Constructor = -44119819

    type sendMessageRecordVideoAction = 
        member this.Constructor = -1584933265

    type sendMessageUploadVideoAction = 
        member this.Constructor = -1845219337

    type sendMessageRecordAudioAction = 
        member this.Constructor = -718310409

    type sendMessageUploadAudioAction = 
        member this.Constructor = -424899985

    type sendMessageUploadPhotoAction = 
        member this.Constructor = -1727382502

    type sendMessageUploadDocumentAction = 
        member this.Constructor = -1884362354

    type sendMessageGeoLocationAction = 
        member this.Constructor = 393186209

    type sendMessageChooseContactAction = 
        member this.Constructor = 1653390447

    type sendMessageTypingAction_17 = 
        member this.Constructor = 381645902
        member this.Layer = 17

    type sendMessageCancelAction_17 = 
        member this.Constructor = -44119819
        member this.Layer = 17

    type sendMessageRecordVideoAction_17 = 
        member this.Constructor = -1584933265
        member this.Layer = 17

    type sendMessageUploadVideoAction_17 = 
        member this.Constructor = -1845219337
        member this.Layer = 17

    type sendMessageRecordAudioAction_17 = 
        member this.Constructor = -718310409
        member this.Layer = 17

    type sendMessageUploadAudioAction_17 = 
        member this.Constructor = -424899985
        member this.Layer = 17

    type sendMessageUploadPhotoAction_17 = 
        member this.Constructor = -1727382502
        member this.Layer = 17

    type sendMessageUploadDocumentAction_17 = 
        member this.Constructor = -1884362354
        member this.Layer = 17

    type sendMessageGeoLocationAction_17 = 
        member this.Constructor = 393186209
        member this.Layer = 17

    type sendMessageChooseContactAction_17 = 
        member this.Constructor = 1653390447
        member this.Layer = 17

    type SendMessageAction = 
        |SendMessageTypingAction of sendMessageTypingAction 
        |SendMessageCancelAction of sendMessageCancelAction 
        |SendMessageRecordVideoAction of sendMessageRecordVideoAction 
        |SendMessageUploadVideoAction of sendMessageUploadVideoAction 
        |SendMessageRecordAudioAction of sendMessageRecordAudioAction 
        |SendMessageUploadAudioAction of sendMessageUploadAudioAction 
        |SendMessageUploadPhotoAction of sendMessageUploadPhotoAction 
        |SendMessageUploadDocumentAction of sendMessageUploadDocumentAction 
        |SendMessageGeoLocationAction of sendMessageGeoLocationAction 
        |SendMessageChooseContactAction of sendMessageChooseContactAction 
        |SendMessageTypingAction_17 of sendMessageTypingAction_17 
        |SendMessageCancelAction_17 of sendMessageCancelAction_17 
        |SendMessageRecordVideoAction_17 of sendMessageRecordVideoAction_17 
        |SendMessageUploadVideoAction_17 of sendMessageUploadVideoAction_17 
        |SendMessageRecordAudioAction_17 of sendMessageRecordAudioAction_17 
        |SendMessageUploadAudioAction_17 of sendMessageUploadAudioAction_17 
        |SendMessageUploadPhotoAction_17 of sendMessageUploadPhotoAction_17 
        |SendMessageUploadDocumentAction_17 of sendMessageUploadDocumentAction_17 
        |SendMessageGeoLocationAction_17 of sendMessageGeoLocationAction_17 
        |SendMessageChooseContactAction_17 of sendMessageChooseContactAction_17 

    type ContactFound = 
        member this.Constructor = -360210539

    type InputPrivacyKey = 
        member this.Constructor = 1335282456

    type PrivacyKey = 
        member this.Constructor = -1137792208

    type privacyValueAllowContacts = 
        member this.Constructor = -123988

    type privacyValueAllowAll = 
        member this.Constructor = 1698855810

    type privacyValueAllowUsers = 
        member this.Constructor = 1297858060

    type privacyValueDisallowContacts = 
        member this.Constructor = -125240806

    type privacyValueDisallowAll = 
        member this.Constructor = -1955338397

    type privacyValueDisallowUsers = 
        member this.Constructor = 209668535

    type PrivacyRule = 
        |PrivacyValueAllowContacts of privacyValueAllowContacts 
        |PrivacyValueAllowAll of privacyValueAllowAll 
        |PrivacyValueAllowUsers of privacyValueAllowUsers 
        |PrivacyValueDisallowContacts of privacyValueDisallowContacts 
        |PrivacyValueDisallowAll of privacyValueDisallowAll 
        |PrivacyValueDisallowUsers of privacyValueDisallowUsers 

    type AccountDaysTTL = 
        member this.Constructor = -1194283041

    type account_SentChangePhoneCode = 
        member this.Constructor = -1527411636

    type documentAttributeImageSize = 
        member this.Constructor = 1815593308

    type documentAttributeAnimated = 
        member this.Constructor = 297109817

    type documentAttributeSticker = 
        member this.Constructor = -83208409

    type documentAttributeVideo = 
        member this.Constructor = 1494273227

    type documentAttributeAudio = 
        member this.Constructor = 85215461

    type documentAttributeFilename = 
        member this.Constructor = 358154344

    type documentAttributeImageSize_23 = 
        member this.Constructor = 1815593308
        member this.Layer = 23

    type documentAttributeAnimated_23 = 
        member this.Constructor = 297109817
        member this.Layer = 23

    type documentAttributeSticker_23 = 
        member this.Constructor = -83208409
        member this.Layer = 23

    type documentAttributeVideo_23 = 
        member this.Constructor = 1494273227
        member this.Layer = 23

    type documentAttributeAudio_23 = 
        member this.Constructor = 85215461
        member this.Layer = 23

    type documentAttributeFilename_23 = 
        member this.Constructor = 358154344
        member this.Layer = 23

    type DocumentAttribute = 
        |DocumentAttributeImageSize of documentAttributeImageSize 
        |DocumentAttributeAnimated of documentAttributeAnimated 
        |DocumentAttributeSticker of documentAttributeSticker 
        |DocumentAttributeVideo of documentAttributeVideo 
        |DocumentAttributeAudio of documentAttributeAudio 
        |DocumentAttributeFilename of documentAttributeFilename 
        |DocumentAttributeImageSize_23 of documentAttributeImageSize_23 
        |DocumentAttributeAnimated_23 of documentAttributeAnimated_23 
        |DocumentAttributeSticker_23 of documentAttributeSticker_23 
        |DocumentAttributeVideo_23 of documentAttributeVideo_23 
        |DocumentAttributeAudio_23 of documentAttributeAudio_23 
        |DocumentAttributeFilename_23 of documentAttributeFilename_23 

    type StickerPack = 
        member this.Constructor = 313694676

    type DisabledFeature = 
        member this.Constructor = -1369215196

    type inputMediaEmpty = 
        member this.Constructor = -1771768449

    type inputMediaUploadedPhoto = 
        member this.Constructor = 767900285

    type inputMediaPhoto = 
        member this.Constructor = -1893027092

    type inputMediaGeoPoint = 
        member this.Constructor = -104578748

    type inputMediaContact = 
        member this.Constructor = -1494984313

    type inputMediaUploadedVideo = 
        member this.Constructor = 322623222

    type inputMediaUploadedThumbVideo = 
        member this.Constructor = -1726817601

    type inputMediaVideo = 
        member this.Constructor = 2130852582

    type inputMediaUploadedAudio = 
        member this.Constructor = 1313442987

    type inputMediaAudio = 
        member this.Constructor = -1986820223

    type inputMediaUploadedDocument = 
        member this.Constructor = -1610888

    type inputMediaUploadedThumbDocument = 
        member this.Constructor = 1095242886

    type inputMediaDocument = 
        member this.Constructor = -779818943

    type InputMedia = 
        |InputMediaEmpty of inputMediaEmpty 
        |InputMediaUploadedPhoto of inputMediaUploadedPhoto 
        |InputMediaPhoto of inputMediaPhoto 
        |InputMediaGeoPoint of inputMediaGeoPoint 
        |InputMediaContact of inputMediaContact 
        |InputMediaUploadedVideo of inputMediaUploadedVideo 
        |InputMediaUploadedThumbVideo of inputMediaUploadedThumbVideo 
        |InputMediaVideo of inputMediaVideo 
        |InputMediaUploadedAudio of inputMediaUploadedAudio 
        |InputMediaAudio of inputMediaAudio 
        |InputMediaUploadedDocument of inputMediaUploadedDocument 
        |InputMediaUploadedThumbDocument of inputMediaUploadedThumbDocument 
        |InputMediaDocument of inputMediaDocument 

    type inputChatPhotoEmpty = 
        member this.Constructor = 480546647

    type inputChatUploadedPhoto = 
        member this.Constructor = -1809496270

    type inputChatPhoto = 
        member this.Constructor = -1293828344

    type InputChatPhoto = 
        |InputChatPhotoEmpty of inputChatPhotoEmpty 
        |InputChatUploadedPhoto of inputChatUploadedPhoto 
        |InputChatPhoto of inputChatPhoto 

    type userProfilePhotoEmpty = 
        member this.Constructor = 1326562017

    type userProfilePhoto = 
        member this.Constructor = -715532088

    type UserProfilePhoto = 
        |UserProfilePhotoEmpty of userProfilePhotoEmpty 
        |UserProfilePhoto of userProfilePhoto 

    type chatParticipantsForbidden = 
        member this.Constructor = 265468810

    type chatParticipants = 
        member this.Constructor = 2017571861

    type ChatParticipants = 
        |ChatParticipantsForbidden of chatParticipantsForbidden 
        |ChatParticipants of chatParticipants 

    type chatPhotoEmpty = 
        member this.Constructor = 935395612

    type chatPhoto = 
        member this.Constructor = 1632839530

    type ChatPhoto = 
        |ChatPhotoEmpty of chatPhotoEmpty 
        |ChatPhoto of chatPhoto 

    type photoSizeEmpty = 
        member this.Constructor = 236446268

    type photoSize = 
        member this.Constructor = 2009052699

    type photoCachedSize = 
        member this.Constructor = -374917894

    type photoSizeEmpty_23 = 
        member this.Constructor = 236446268
        member this.Layer = 23

    type photoSize_23 = 
        member this.Constructor = 2009052699
        member this.Layer = 23

    type photoCachedSize_23 = 
        member this.Constructor = -374917894
        member this.Layer = 23

    type PhotoSize = 
        |PhotoSizeEmpty of photoSizeEmpty 
        |PhotoSize of photoSize 
        |PhotoCachedSize of photoCachedSize 
        |PhotoSizeEmpty_23 of photoSizeEmpty_23 
        |PhotoSize_23 of photoSize_23 
        |PhotoCachedSize_23 of photoCachedSize_23 

    type auth_CheckedPhone = 
        member this.Constructor = -486486981

    type auth_sentCode = 
        member this.Constructor = -269659687

    type auth_sentAppCode = 
        member this.Constructor = -484053553

    type auth_SentCode = 
        |Auth_sentCode of auth_sentCode 
        |Auth_sentAppCode of auth_sentAppCode 

    type inputNotifyPeer = 
        member this.Constructor = -1195615476

    type inputNotifyUsers = 
        member this.Constructor = 423314455

    type inputNotifyChats = 
        member this.Constructor = 1251338318

    type inputNotifyAll = 
        member this.Constructor = -1540769658

    type InputNotifyPeer = 
        |InputNotifyPeer of inputNotifyPeer 
        |InputNotifyUsers of inputNotifyUsers 
        |InputNotifyChats of inputNotifyChats 
        |InputNotifyAll of inputNotifyAll 

    type InputPeerNotifySettings = 
        member this.Constructor = 1185074840

    type peerNotifySettingsEmpty = 
        member this.Constructor = 1889961234

    type peerNotifySettings = 
        member this.Constructor = -1923214866

    type PeerNotifySettings = 
        |PeerNotifySettingsEmpty of peerNotifySettingsEmpty 
        |PeerNotifySettings of peerNotifySettings 

    type Contact = 
        member this.Constructor = -116274796

    type ContactStatus = 
        member this.Constructor = -748155807

    type contacts_foreignLinkUnknown = 
        member this.Constructor = 322183672

    type contacts_foreignLinkRequested = 
        member this.Constructor = -1484775609

    type contacts_foreignLinkMutual = 
        member this.Constructor = 468356321

    type contacts_ForeignLink = 
        |Contacts_foreignLinkUnknown of contacts_foreignLinkUnknown 
        |Contacts_foreignLinkRequested of contacts_foreignLinkRequested 
        |Contacts_foreignLinkMutual of contacts_foreignLinkMutual 

    type contacts_myLinkEmpty = 
        member this.Constructor = -768992160

    type contacts_myLinkRequested = 
        member this.Constructor = 1818882030

    type contacts_myLinkContact = 
        member this.Constructor = -1035932711

    type contacts_MyLink = 
        |Contacts_myLinkEmpty of contacts_myLinkEmpty 
        |Contacts_myLinkRequested of contacts_myLinkRequested 
        |Contacts_myLinkContact of contacts_myLinkContact 

    type upload_File = 
        member this.Constructor = 157948117

    type Config = 
        member this.Constructor = 2108568544

    type help_appUpdate = 
        member this.Constructor = -1987579119

    type help_noAppUpdate = 
        member this.Constructor = -1000708810

    type help_AppUpdate = 
        |Help_appUpdate of help_appUpdate 
        |Help_noAppUpdate of help_noAppUpdate 

    type encryptedMessage = 
        member this.Constructor = -317144808

    type encryptedMessageService = 
        member this.Constructor = 594758406

    type EncryptedMessage = 
        |EncryptedMessage of encryptedMessage 
        |EncryptedMessageService of encryptedMessageService 

    type messages_sentEncryptedMessage = 
        member this.Constructor = 1443858741

    type messages_sentEncryptedFile = 
        member this.Constructor = -1802240206

    type messages_SentEncryptedMessage = 
        |Messages_sentEncryptedMessage of messages_sentEncryptedMessage 
        |Messages_sentEncryptedFile of messages_sentEncryptedFile 

    type notifyPeer = 
        member this.Constructor = -1613493288

    type notifyUsers = 
        member this.Constructor = -1261946036

    type notifyChats = 
        member this.Constructor = -1073230141

    type notifyAll = 
        member this.Constructor = 1959820384

    type NotifyPeer = 
        |NotifyPeer of notifyPeer 
        |NotifyUsers of notifyUsers 
        |NotifyChats of notifyChats 
        |NotifyAll of notifyAll 

    type inputPrivacyValueAllowContacts = 
        member this.Constructor = 218751099

    type inputPrivacyValueAllowAll = 
        member this.Constructor = 407582158

    type inputPrivacyValueAllowUsers = 
        member this.Constructor = 320652927

    type inputPrivacyValueDisallowContacts = 
        member this.Constructor = 195371015

    type inputPrivacyValueDisallowAll = 
        member this.Constructor = -697604407

    type inputPrivacyValueDisallowUsers = 
        member this.Constructor = -1877932953

    type InputPrivacyRule = 
        |InputPrivacyValueAllowContacts of inputPrivacyValueAllowContacts 
        |InputPrivacyValueAllowAll of inputPrivacyValueAllowAll 
        |InputPrivacyValueAllowUsers of inputPrivacyValueAllowUsers 
        |InputPrivacyValueDisallowContacts of inputPrivacyValueDisallowContacts 
        |InputPrivacyValueDisallowAll of inputPrivacyValueDisallowAll 
        |InputPrivacyValueDisallowUsers of inputPrivacyValueDisallowUsers 

    type decryptedMessageActionSetMessageTTL_8 = 
        member this.Constructor = -1586283796
        member this.Layer = 8

    type decryptedMessageActionReadMessages_8 = 
        member this.Constructor = 206520510
        member this.Layer = 8

    type decryptedMessageActionDeleteMessages_8 = 
        member this.Constructor = 1700872964
        member this.Layer = 8

    type decryptedMessageActionScreenshotMessages_8 = 
        member this.Constructor = -1967000459
        member this.Layer = 8

    type decryptedMessageActionFlushHistory_8 = 
        member this.Constructor = 1729750108
        member this.Layer = 8

    type decryptedMessageActionResend_17 = 
        member this.Constructor = 1360072880
        member this.Layer = 17

    type decryptedMessageActionNotifyLayer_17 = 
        member this.Constructor = -217806717
        member this.Layer = 17

    type decryptedMessageActionTyping_17 = 
        member this.Constructor = -860719551
        member this.Layer = 17

    type decryptedMessageActionRequestKey_20 = 
        member this.Constructor = -204906213
        member this.Layer = 20

    type decryptedMessageActionAcceptKey_20 = 
        member this.Constructor = 1877046107
        member this.Layer = 20

    type decryptedMessageActionAbortKey_20 = 
        member this.Constructor = -586814357
        member this.Layer = 20

    type decryptedMessageActionCommitKey_20 = 
        member this.Constructor = -332526693
        member this.Layer = 20

    type decryptedMessageActionNoop_20 = 
        member this.Constructor = -1473258141
        member this.Layer = 20

    type DecryptedMessageAction = 
        |DecryptedMessageActionSetMessageTTL_8 of decryptedMessageActionSetMessageTTL_8 
        |DecryptedMessageActionReadMessages_8 of decryptedMessageActionReadMessages_8 
        |DecryptedMessageActionDeleteMessages_8 of decryptedMessageActionDeleteMessages_8 
        |DecryptedMessageActionScreenshotMessages_8 of decryptedMessageActionScreenshotMessages_8 
        |DecryptedMessageActionFlushHistory_8 of decryptedMessageActionFlushHistory_8 
        |DecryptedMessageActionResend_17 of decryptedMessageActionResend_17 
        |DecryptedMessageActionNotifyLayer_17 of decryptedMessageActionNotifyLayer_17 
        |DecryptedMessageActionTyping_17 of decryptedMessageActionTyping_17 
        |DecryptedMessageActionRequestKey_20 of decryptedMessageActionRequestKey_20 
        |DecryptedMessageActionAcceptKey_20 of decryptedMessageActionAcceptKey_20 
        |DecryptedMessageActionAbortKey_20 of decryptedMessageActionAbortKey_20 
        |DecryptedMessageActionCommitKey_20 of decryptedMessageActionCommitKey_20 
        |DecryptedMessageActionNoop_20 of decryptedMessageActionNoop_20 

    type userEmpty = 
        member this.Constructor = 537022650

    type userSelf = 
        member this.Constructor = 1879553105

    type userContact = 
        member this.Constructor = -894214632

    type userRequest = 
        member this.Constructor = -640891665

    type userForeign = 
        member this.Constructor = 123533224

    type userDeleted = 
        member this.Constructor = -704549510

    type User = 
        |UserEmpty of userEmpty 
        |UserSelf of userSelf 
        |UserContact of userContact 
        |UserRequest of userRequest 
        |UserForeign of userForeign 
        |UserDeleted of userDeleted 

    type chatEmpty = 
        member this.Constructor = -1683826688

    type chat = 
        member this.Constructor = 1855757255

    type chatForbidden = 
        member this.Constructor = -83047359

    type Chat = 
        |ChatEmpty of chatEmpty 
        |Chat of chat 
        |ChatForbidden of chatForbidden 

    type Dialog = 
        member this.Constructor = -1422222932

    type photoEmpty = 
        member this.Constructor = 590459437

    type photo = 
        member this.Constructor = 582313809

    type Photo = 
        |PhotoEmpty of photoEmpty 
        |Photo of photo 

    type videoEmpty = 
        member this.Constructor = -1056548696

    type video = 
        member this.Constructor = 948937617

    type Video = 
        |VideoEmpty of videoEmpty 
        |Video of video 

    type wallPaper = 
        member this.Constructor = -860866985

    type wallPaperSolid = 
        member this.Constructor = 1662091044

    type WallPaper = 
        |WallPaper of wallPaper 
        |WallPaperSolid of wallPaperSolid 

    type documentEmpty = 
        member this.Constructor = 922273905

    type document = 
        member this.Constructor = -106717361

    type Document = 
        |DocumentEmpty of documentEmpty 
        |Document of document 

    type decryptedMessageMediaEmpty_8 = 
        member this.Constructor = 144661578
        member this.Layer = 8

    type decryptedMessageMediaPhoto_8 = 
        member this.Constructor = 846826124
        member this.Layer = 8

    type decryptedMessageMediaVideo_8 = 
        member this.Constructor = 1290694387
        member this.Layer = 8

    type decryptedMessageMediaVideo_17 = 
        member this.Constructor = 1380598109
        member this.Layer = 17

    type decryptedMessageMediaGeoPoint_8 = 
        member this.Constructor = 893913689
        member this.Layer = 8

    type decryptedMessageMediaContact_8 = 
        member this.Constructor = 1485441687
        member this.Layer = 8

    type decryptedMessageMediaDocument_8 = 
        member this.Constructor = -1332395189
        member this.Layer = 8

    type decryptedMessageMediaAudio_8 = 
        member this.Constructor = 1619031439
        member this.Layer = 8

    type decryptedMessageMediaAudio_17 = 
        member this.Constructor = 1474341323
        member this.Layer = 17

    type decryptedMessageMediaExternalDocument_23 = 
        member this.Constructor = -90853155
        member this.Layer = 23

    type DecryptedMessageMedia = 
        |DecryptedMessageMediaEmpty_8 of decryptedMessageMediaEmpty_8 
        |DecryptedMessageMediaPhoto_8 of decryptedMessageMediaPhoto_8 
        |DecryptedMessageMediaVideo_8 of decryptedMessageMediaVideo_8 
        |DecryptedMessageMediaVideo_17 of decryptedMessageMediaVideo_17 
        |DecryptedMessageMediaGeoPoint_8 of decryptedMessageMediaGeoPoint_8 
        |DecryptedMessageMediaContact_8 of decryptedMessageMediaContact_8 
        |DecryptedMessageMediaDocument_8 of decryptedMessageMediaDocument_8 
        |DecryptedMessageMediaAudio_8 of decryptedMessageMediaAudio_8 
        |DecryptedMessageMediaAudio_17 of decryptedMessageMediaAudio_17 
        |DecryptedMessageMediaExternalDocument_23 of decryptedMessageMediaExternalDocument_23 

    type ChatFull = 
        member this.Constructor = 1661886910

    type messageMediaEmpty = 
        member this.Constructor = 1038967584

    type messageMediaPhoto = 
        member this.Constructor = -926655958

    type messageMediaVideo = 
        member this.Constructor = -1563278704

    type messageMediaGeo = 
        member this.Constructor = 1457575028

    type messageMediaContact = 
        member this.Constructor = 1585262393

    type messageMediaDocument = 
        member this.Constructor = 802824708

    type messageMediaAudio = 
        member this.Constructor = -961117440

    type MessageMedia = 
        |MessageMediaEmpty of messageMediaEmpty 
        |MessageMediaPhoto of messageMediaPhoto 
        |MessageMediaVideo of messageMediaVideo 
        |MessageMediaGeo of messageMediaGeo 
        |MessageMediaContact of messageMediaContact 
        |MessageMediaDocument of messageMediaDocument 
        |MessageMediaAudio of messageMediaAudio 

    type messageActionEmpty = 
        member this.Constructor = -1230047312

    type messageActionChatCreate = 
        member this.Constructor = -1503425638

    type messageActionChatEditTitle = 
        member this.Constructor = -1247687078

    type messageActionChatEditPhoto = 
        member this.Constructor = 2144015272

    type messageActionChatDeletePhoto = 
        member this.Constructor = -1780220945

    type messageActionChatAddUser = 
        member this.Constructor = 1581055051

    type messageActionChatDeleteUser = 
        member this.Constructor = -1297179892

    type MessageAction = 
        |MessageActionEmpty of messageActionEmpty 
        |MessageActionChatCreate of messageActionChatCreate 
        |MessageActionChatEditTitle of messageActionChatEditTitle 
        |MessageActionChatEditPhoto of messageActionChatEditPhoto 
        |MessageActionChatDeletePhoto of messageActionChatDeletePhoto 
        |MessageActionChatAddUser of messageActionChatAddUser 
        |MessageActionChatDeleteUser of messageActionChatDeleteUser 

    type auth_Authorization = 
        member this.Constructor = -155815004

    type contacts_Link = 
        member this.Constructor = -322001931

    type contacts_contactsNotModified = 
        member this.Constructor = -1219778094

    type contacts_contacts = 
        member this.Constructor = 1871416498

    type contacts_Contacts = 
        |Contacts_contactsNotModified of contacts_contactsNotModified 
        |Contacts_contacts of contacts_contacts 

    type contacts_ImportedContacts = 
        member this.Constructor = -1387117803

    type contacts_blocked = 
        member this.Constructor = 471043349

    type contacts_blockedSlice = 
        member this.Constructor = -1878523231

    type contacts_Blocked = 
        |Contacts_blocked of contacts_blocked 
        |Contacts_blockedSlice of contacts_blockedSlice 

    type messages_Chats = 
        member this.Constructor = -2125411368

    type photos_photos = 
        member this.Constructor = -1916114267

    type photos_photosSlice = 
        member this.Constructor = 352657236

    type photos_Photos = 
        |Photos_photos of photos_photos 
        |Photos_photosSlice of photos_photosSlice 

    type photos_Photo = 
        member this.Constructor = 539045032

    type help_Support = 
        member this.Constructor = 398898678

    type contacts_Found = 
        member this.Constructor = 90570766

    type account_PrivacyRules = 
        member this.Constructor = 1430961007

    type messages_stickersNotModified = 
        member this.Constructor = -244016606

    type messages_stickers = 
        member this.Constructor = -1970352846

    type messages_Stickers = 
        |Messages_stickersNotModified of messages_stickersNotModified 
        |Messages_stickers of messages_stickers 

    type messages_allStickersNotModified = 
        member this.Constructor = -395967805

    type messages_allStickers = 
        member this.Constructor = -588304126

    type messages_AllStickers = 
        |Messages_allStickersNotModified of messages_allStickersNotModified 
        |Messages_allStickers of messages_allStickers 

    type decryptedMessage_8 = 
        member this.Constructor = 528568095
        member this.Layer = 8

    type decryptedMessage_17 = 
        member this.Constructor = 541931640
        member this.Layer = 17

    type decryptedMessageService_8 = 
        member this.Constructor = -1438109059
        member this.Layer = 8

    type decryptedMessageService_17 = 
        member this.Constructor = 1930838368
        member this.Layer = 17

    type DecryptedMessage = 
        |DecryptedMessage_8 of decryptedMessage_8 
        |DecryptedMessage_17 of decryptedMessage_17 
        |DecryptedMessageService_8 of decryptedMessageService_8 
        |DecryptedMessageService_17 of decryptedMessageService_17 

    type messageEmpty = 
        member this.Constructor = -2082087340

    type message = 
        member this.Constructor = 1450613171

    type messageForwarded = 
        member this.Constructor = -1553471722

    type messageService = 
        member this.Constructor = 495384334

    type Message = 
        |MessageEmpty of messageEmpty 
        |Message of message 
        |MessageForwarded of messageForwarded 
        |MessageService of messageService 

    type UserFull = 
        member this.Constructor = 1997575642

    type messages_sentMessage = 
        member this.Constructor = -772484260

    type messages_sentMessageLink = 
        member this.Constructor = -371504577

    type messages_SentMessage = 
        |Messages_sentMessage of messages_sentMessage 
        |Messages_sentMessageLink of messages_sentMessageLink 

    type messages_ChatFull = 
        member this.Constructor = -438840932

    type DecryptedMessageLayer = 
        member this.Constructor = 467867529
        member this.Layer = 17

    type messages_dialogs = 
        member this.Constructor = 364538944

    type messages_dialogsSlice = 
        member this.Constructor = 1910543603

    type messages_Dialogs = 
        |Messages_dialogs of messages_dialogs 
        |Messages_dialogsSlice of messages_dialogsSlice 

    type messages_messages = 
        member this.Constructor = -1938715001

    type messages_messagesSlice = 
        member this.Constructor = 189033187

    type messages_Messages = 
        |Messages_messages of messages_messages 
        |Messages_messagesSlice of messages_messagesSlice 

    type messages_statedMessages = 
        member this.Constructor = -1768654661

    type messages_statedMessagesLinks = 
        member this.Constructor = 1047852486

    type messages_StatedMessages = 
        |Messages_statedMessages of messages_statedMessages 
        |Messages_statedMessagesLinks of messages_statedMessagesLinks 

    type messages_statedMessage = 
        member this.Constructor = -797251802

    type messages_statedMessageLink = 
        member this.Constructor = -1448138623

    type messages_StatedMessage = 
        |Messages_statedMessage of messages_statedMessage 
        |Messages_statedMessageLink of messages_statedMessageLink 

    type updateNewMessage = 
        member this.Constructor = 20626867

    type updateMessageID = 
        member this.Constructor = 1318109142

    type updateReadMessages = 
        member this.Constructor = -966484431

    type updateDeleteMessages = 
        member this.Constructor = -1456734682

    type updateUserTyping = 
        member this.Constructor = 1548249383

    type updateChatUserTyping = 
        member this.Constructor = -1704596961

    type updateChatParticipants = 
        member this.Constructor = 125178264

    type updateUserStatus = 
        member this.Constructor = 469489699

    type updateUserName = 
        member this.Constructor = -1489818765

    type updateUserPhoto = 
        member this.Constructor = -1791935732

    type updateContactRegistered = 
        member this.Constructor = 628472761

    type updateContactLink = 
        member this.Constructor = 1369737882

    type updateNewAuthorization = 
        member this.Constructor = -1895411046

    type updateNewEncryptedMessage = 
        member this.Constructor = 314359194

    type updateEncryptedChatTyping = 
        member this.Constructor = 386986326

    type updateEncryption = 
        member this.Constructor = -1264392051

    type updateEncryptedMessagesRead = 
        member this.Constructor = 956179895

    type updateChatParticipantAdd = 
        member this.Constructor = 974056226

    type updateChatParticipantDelete = 
        member this.Constructor = 1851755554

    type updateDcOptions = 
        member this.Constructor = -1906403213

    type updateUserBlocked = 
        member this.Constructor = -2131957734

    type updateNotifySettings = 
        member this.Constructor = -1094555409

    type updateServiceNotification = 
        member this.Constructor = 942527460

    type updatePrivacy = 
        member this.Constructor = -298113238

    type updateUserPhone = 
        member this.Constructor = 314130811

    type Update = 
        |UpdateNewMessage of updateNewMessage 
        |UpdateMessageID of updateMessageID 
        |UpdateReadMessages of updateReadMessages 
        |UpdateDeleteMessages of updateDeleteMessages 
        |UpdateUserTyping of updateUserTyping 
        |UpdateChatUserTyping of updateChatUserTyping 
        |UpdateChatParticipants of updateChatParticipants 
        |UpdateUserStatus of updateUserStatus 
        |UpdateUserName of updateUserName 
        |UpdateUserPhoto of updateUserPhoto 
        |UpdateContactRegistered of updateContactRegistered 
        |UpdateContactLink of updateContactLink 
        |UpdateNewAuthorization of updateNewAuthorization 
        |UpdateNewEncryptedMessage of updateNewEncryptedMessage 
        |UpdateEncryptedChatTyping of updateEncryptedChatTyping 
        |UpdateEncryption of updateEncryption 
        |UpdateEncryptedMessagesRead of updateEncryptedMessagesRead 
        |UpdateChatParticipantAdd of updateChatParticipantAdd 
        |UpdateChatParticipantDelete of updateChatParticipantDelete 
        |UpdateDcOptions of updateDcOptions 
        |UpdateUserBlocked of updateUserBlocked 
        |UpdateNotifySettings of updateNotifySettings 
        |UpdateServiceNotification of updateServiceNotification 
        |UpdatePrivacy of updatePrivacy 
        |UpdateUserPhone of updateUserPhone 

    type updates_differenceEmpty = 
        member this.Constructor = 1567990072

    type updates_difference = 
        member this.Constructor = 16030880

    type updates_differenceSlice = 
        member this.Constructor = -1459938943

    type updates_Difference = 
        |Updates_differenceEmpty of updates_differenceEmpty 
        |Updates_difference of updates_difference 
        |Updates_differenceSlice of updates_differenceSlice 

    type updatesTooLong = 
        member this.Constructor = -484987010

    type updateShortMessage = 
        member this.Constructor = -738961532

    type updateShortChatMessage = 
        member this.Constructor = 724548942

    type updateShort = 
        member this.Constructor = 2027216577

    type updatesCombined = 
        member this.Constructor = 1918567619

    type updates = 
        member this.Constructor = 1957577280

    type Updates = 
        |UpdatesTooLong of updatesTooLong 
        |UpdateShortMessage of updateShortMessage 
        |UpdateShortChatMessage of updateShortChatMessage 
        |UpdateShort of updateShort 
        |UpdatesCombined of updatesCombined 
        |Updates of updates 
