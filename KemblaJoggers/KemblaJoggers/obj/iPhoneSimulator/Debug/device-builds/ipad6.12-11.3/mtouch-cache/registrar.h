#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#define DEBUG 1
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <QuartzCore/QuartzCore.h>
#import <UserNotificationsUI/UserNotificationsUI.h>
#import <Speech/Speech.h>
#import <SafariServices/SafariServices.h>
#import <QuickLook/QuickLook.h>
#import <PushKit/PushKit.h>
#import <NotificationCenter/NotificationCenter.h>
#import <Messages/Messages.h>
#import <IntentsUI/IntentsUI.h>
#import <IdentityLookup/IdentityLookup.h>
#import <iAd/iAd.h>
#import <FileProviderUI/FileProviderUI.h>
#import <FileProvider/FileProvider.h>
#import <ExternalAccessory/ExternalAccessory.h>
#import <CoreNFC/CoreNFC.h>
#import <ContactsUI/ContactsUI.h>
#import <AdSupport/AdSupport.h>
#import <WatchConnectivity/WatchConnectivity.h>
#import <PhotosUI/PhotosUI.h>
#import <NewsstandKit/NewsstandKit.h>
#import <CoreTelephony/CoreTelephonyDefines.h>
#import <CoreTelephony/CTCall.h>
#import <CoreTelephony/CTCallCenter.h>
#import <CoreTelephony/CTCarrier.h>
#import <CoreTelephony/CTTelephonyNetworkInfo.h>
#import <CoreTelephony/CTSubscriber.h>
#import <CoreTelephony/CTSubscriberInfo.h>
#import <CoreMIDI/CoreMIDI.h>
#import <Accounts/Accounts.h>
#import <WatchKit/WatchKit.h>
#import <Vision/Vision.h>
#import <VideoSubscriberAccount/VideoSubscriberAccount.h>
#import <UserNotifications/UserNotifications.h>
#import <Twitter/Twitter.h>
#import <StoreKit/StoreKit.h>
#import <Social/Social.h>
#import <ReplayKit/ReplayKit.h>
#import <Photos/Photos.h>
#import <PDFKit/PDFKit.h>
#import <PassKit/PassKit.h>
#import <NetworkExtension/NetworkExtension.h>
#import <MultipeerConnectivity/MultipeerConnectivity.h>
#import <ModelIO/ModelIO.h>
#import <MessageUI/MessageUI.h>
#import <MediaPlayer/MediaPlayer.h>
#import <MapKit/MapKit.h>
#import <CoreLocation/CoreLocation.h>
#import <JavaScriptCore/JavaScriptCore.h>
#import <Intents/Intents.h>
#import <HomeKit/HomeKit.h>
#import <HealthKit/HealthKit.h>
#import <GameplayKit/GameplayKit.h>
#import <GameController/GameController.h>
#import <GLKit/GLKit.h>
#import <EventKitUI/EventKitUI.h>
#import <EventKit/EventKit.h>
#import <CoreSpotlight/CoreSpotlight.h>
#import <CloudKit/CloudKit.h>
#import <CoreMotion/CoreMotion.h>
#import <CoreImage/CoreImage.h>
#import <CoreData/CoreData.h>
#import <SceneKit/SceneKit.h>
#import <Contacts/Contacts.h>
#import <CallKit/CallKit.h>
#import <BusinessChat/BusinessChat.h>
#import <AudioUnit/AudioUnit.h>
#import <AssetsLibrary/AssetsLibrary.h>
#import <ARKit/ARKit.h>
#import <SpriteKit/SpriteKit.h>
#import <AddressBookUI/AddressBookUI.h>
#import <GameKit/GameKit.h>
#import <WebKit/WebKit.h>
#import <CoreML/CoreML.h>
#import <CoreBluetooth/CoreBluetooth.h>
#import <AVKit/AVKit.h>
#import <AVFoundation/AVFoundation.h>
#import <LocalAuthentication/LocalAuthentication.h>
#import <HealthKitUI/HealthKitUI.h>
#import <CoreGraphics/CoreGraphics.h>

@class UIApplicationDelegate;
@class UIScrollViewDelegate;
@class UITableViewSource;
@class SFSpeechRecognitionTaskDelegate;
@class SFSpeechRecognizerDelegate;
@class SFSafariViewControllerDelegate;
@class QLPreviewControllerDataSource;
@class QLPreviewControllerDelegate;
@class QLPreviewItem;
@class PKPushRegistryDelegate;
@class NCWidgetProviding;
@class MSStickerBrowserViewDataSource;
@class ADBannerViewDelegate;
@class ADInterstitialAdDelegate;
@class EAAccessoryDelegate;
@class EAWiFiUnconfiguredAccessoryBrowserDelegate;
@class NFCNDEFReaderSessionDelegate;
@class NFCReaderSessionDelegate;
@class CNContactPickerDelegate;
@class CNContactViewControllerDelegate;
@class WCSessionDelegate;
@class PHContentEditingController;
@class PHLivePhotoViewDelegate;
@class VSAccountManagerDelegate;
@class UNUserNotificationCenterDelegate;
@class SKPaymentTransactionObserver;
@class SKCloudServiceSetupViewControllerDelegate;
@class SKRequestDelegate;
@class SKProductsRequestDelegate;
@class SKStoreProductViewControllerDelegate;
@class RPBroadcastActivityViewControllerDelegate;
@class RPBroadcastControllerDelegate;
@class RPPreviewViewControllerDelegate;
@class RPScreenRecorderDelegate;
@class PHPhotoLibraryChangeObserver;
@class PDFDocumentDelegate;
@class PDFViewDelegate;
@class PKAddPassesViewControllerDelegate;
@class PKAddPaymentPassViewControllerDelegate;
@class PKPaymentAuthorizationControllerDelegate;
@class PKPaymentAuthorizationViewControllerDelegate;
@class NWTCPConnectionAuthenticationDelegate;
@class MCAdvertiserAssistantDelegate;
@class MCBrowserViewControllerDelegate;
@class MCNearbyServiceAdvertiserDelegate;
@class MCNearbyServiceBrowserDelegate;
@class MCSessionDelegate;
@class MDLLightProbeIrradianceDataSource;
@class UINavigationControllerDelegate;
@class MFMailComposeViewControllerDelegate;
@class MessageUI_Mono_MFMailComposeViewControllerDelegate;
@class MFMessageComposeViewControllerDelegate;
@class MessageUI_Mono_MFMessageComposeViewControllerDelegate;
@class MPPlayableContentDelegate;
@class MPPlayableContentDataSource;
@class MPMediaPickerControllerDelegate;
@class MKAnnotation;
@class MKLocalSearchCompleterDelegate;
@class MKMapViewDelegate;
@class MKOverlay;
@class MKReverseGeocoderDelegate;
@class Xamarin_iOS__JavaScriptCore_JSExport;
@class HMAccessoryBrowserDelegate;
@class HMAccessoryDelegate;
@class HMCameraSnapshotControlDelegate;
@class HMCameraStreamControlDelegate;
@class HMHomeDelegate;
@class HMHomeManagerDelegate;
@class GKAgentDelegate;
@class GLKNamedEffect;
@class GLKViewControllerDelegate;
@class GLKViewDelegate;
@class EKCalendarChooserDelegate;
@class EKEventEditViewDelegate;
@class EKEventViewDelegate;
@class CSSearchableIndexDelegate;
@class CLLocationManagerDelegate;
@class CoreImage_CIAccordionFoldTransition;
@class CoreImage_CICompositingFilter;
@class CoreImage_CIAdditionCompositing;
@class CoreImage_CIAffineFilter;
@class CoreImage_CIAffineClamp;
@class CoreImage_CIAffineTile;
@class CoreImage_CIAffineTransform;
@class CoreImage_CIAreaAverage;
@class CoreImage_CIAreaHistogram;
@class CoreImage_CIAreaMaximum;
@class CoreImage_CIAreaMaximumAlpha;
@class CoreImage_CIAreaMinimum;
@class CoreImage_CIAreaMinimumAlpha;
@class CoreImage_CIAreaMinMaxRed;
@class CoreImage_CIImageGenerator;
@class CoreImage_CIAttributedTextImageGenerator;
@class CoreImage_CICodeGenerator;
@class CoreImage_CIAztecCodeGenerator;
@class CoreImage_CIBarcodeGenerator;
@class CoreImage_CITransitionFilter;
@class CoreImage_CIBarsSwipeTransition;
@class CoreImage_CIBicubicScaleTransform;
@class CoreImage_CIBlendFilter;
@class CoreImage_CIBlendWithMask;
@class CoreImage_CIBlendWithAlphaMask;
@class CoreImage_CIBlendWithBlueMask;
@class CoreImage_CIBlendWithRedMask;
@class CoreImage_CIBloom;
@class CoreImage_CILinearBlur;
@class CoreImage_CIBokehBlur;
@class CoreImage_CIBoxBlur;
@class CoreImage_CIDistortionFilter;
@class CoreImage_CIBumpDistortion;
@class CoreImage_CIBumpDistortionLinear;
@class CoreImage_CICheckerboardGenerator;
@class CoreImage_CICircleSplashDistortion;
@class CoreImage_CIScreenFilter;
@class CoreImage_CICircularScreen;
@class CoreImage_CICircularWrap;
@class CoreImage_CIClamp;
@class CoreImage_CICmykHalftone;
@class CoreImage_CICode128BarcodeGenerator;
@class CoreImage_CIColorBlendMode;
@class CoreImage_CIColorBurnBlendMode;
@class CoreImage_CIColorClamp;
@class CoreImage_CIColorControls;
@class CoreImage_CIColorCrossPolynomial;
@class CoreImage_CIColorCube;
@class CoreImage_CIColorCubesMixedWithMask;
@class CoreImage_CIColorCubeWithColorSpace;
@class CoreImage_CIColorCurves;
@class CoreImage_CIColorDodgeBlendMode;
@class CoreImage_CIColorInvert;
@class CoreImage_CIColorMap;
@class CoreImage_CIColorMatrix;
@class CoreImage_CIColorMonochrome;
@class CoreImage_CIColorPolynomial;
@class CoreImage_CIColorPosterize;
@class CoreImage_CIColumnAverage;
@class CoreImage_CIComicEffect;
@class CoreImage_CIConstantColorGenerator;
@class CoreImage_CIConvolutionCore;
@class CoreImage_CIConvolution3X3;
@class CoreImage_CIConvolution5X5;
@class CoreImage_CIConvolution7X7;
@class CoreImage_CIConvolution9Horizontal;
@class CoreImage_CIConvolution9Vertical;
@class CoreImage_CICopyMachineTransition;
@class CoreImage_CICrop;
@class CoreImage_CICrystallize;
@class CoreImage_CIDarkenBlendMode;
@class CoreImage_CIDepthBlurEffect;
@class CoreImage_CIDepthDisparityConverter;
@class CoreImage_CIDepthOfField;
@class CoreImage_CIDepthToDisparity;
@class CoreImage_CIDifferenceBlendMode;
@class CoreImage_CIDiscBlur;
@class CoreImage_CIDisintegrateWithMaskTransition;
@class CoreImage_CIDisparityToDepth;
@class CoreImage_CIDisplacementDistortion;
@class CoreImage_CIDissolveTransition;
@class CoreImage_CIDivideBlendMode;
@class CoreImage_CIDotScreen;
@class CoreImage_CIDroste;
@class CoreImage_CIEdgePreserveUpsampleFilter;
@class CoreImage_CIEdges;
@class CoreImage_CIEdgeWork;
@class CoreImage_CITileFilter;
@class CoreImage_CIEightfoldReflectedTile;
@class CoreImage_CIExclusionBlendMode;
@class CoreImage_CIExposureAdjust;
@class CoreImage_CIFaceBalance;
@class CoreImage_CIFalseColor;
@class CoreImage_CIFlashTransition;
@class CoreImage_CIFourfoldReflectedTile;
@class CoreImage_CIFourfoldRotatedTile;
@class CoreImage_CIFourfoldTranslatedTile;
@class CoreImage_CIGammaAdjust;
@class CoreImage_CIGaussianBlur;
@class CoreImage_CIGaussianGradient;
@class CoreImage_CIGlassDistortion;
@class CoreImage_CIGlassLozenge;
@class CoreImage_CIGlideReflectedTile;
@class CoreImage_CIGloom;
@class CoreImage_CIHardLightBlendMode;
@class CoreImage_CIHatchedScreen;
@class CoreImage_CIHeightFieldFromMask;
@class CoreImage_CIHexagonalPixellate;
@class CoreImage_CIHighlightShadowAdjust;
@class CoreImage_CIHistogramDisplayFilter;
@class CoreImage_CIHoleDistortion;
@class CoreImage_CIHueAdjust;
@class CoreImage_CIHueBlendMode;
@class CoreImage_CIHueSaturationValueGradient;
@protocol CIImageProvider;
@class CoreImage_CIKaleidoscope;
@class CoreImage_CILabDeltaE;
@class CoreImage_CILanczosScaleTransform;
@class CoreImage_CILenticularHaloGenerator;
@class CoreImage_CILightenBlendMode;
@class CoreImage_CILightTunnel;
@class CoreImage_CILinearBurnBlendMode;
@class CoreImage_CILinearDodgeBlendMode;
@class CoreImage_CILinearGradient;
@class CoreImage_CILinearToSRGBToneCurve;
@class CoreImage_CILineOverlay;
@class CoreImage_CILineScreen;
@class CoreImage_CILuminosityBlendMode;
@class CoreImage_CIMaskedVariableBlur;
@class CoreImage_CIMaskToAlpha;
@class CoreImage_CIMaximumComponent;
@class CoreImage_CIMaximumCompositing;
@class CoreImage_CIMedianFilter;
@class CoreImage_CIMinimumComponent;
@class CoreImage_CIMinimumCompositing;
@class CoreImage_CIModTransition;
@class CoreImage_CIMorphology;
@class CoreImage_CIMorphologyGradient;
@class CoreImage_CIMorphologyMaximum;
@class CoreImage_CIMorphologyMinimum;
@class CoreImage_CIMotionBlur;
@class CoreImage_CIMultiplyBlendMode;
@class CoreImage_CIMultiplyCompositing;
@class CoreImage_CINinePartStretched;
@class CoreImage_CINinePartTiled;
@class CoreImage_CINoiseReduction;
@class CoreImage_CIOpTile;
@class CoreImage_CIOverlayBlendMode;
@class CoreImage_CIPageCurlTransition;
@class CoreImage_CIPageCurlWithShadowTransition;
@class CoreImage_CIParallelogramTile;
@class CoreImage_CIPdf417BarcodeGenerator;
@class CoreImage_CIPerspectiveTransform;
@class CoreImage_CIPerspectiveCorrection;
@class CoreImage_CIPerspectiveTile;
@class CoreImage_CIPerspectiveTransformWithExtent;
@class CoreImage_CIPhotoEffect;
@class CoreImage_CIPhotoEffectChrome;
@class CoreImage_CIPhotoEffectFade;
@class CoreImage_CIPhotoEffectInstant;
@class CoreImage_CIPhotoEffectMono;
@class CoreImage_CIPhotoEffectNoir;
@class CoreImage_CIPhotoEffectProcess;
@class CoreImage_CIPhotoEffectTonal;
@class CoreImage_CIPhotoEffectTransfer;
@class CoreImage_CIPinchDistortion;
@class CoreImage_CIPinLightBlendMode;
@class CoreImage_CIPixellate;
@class CoreImage_CIPointillize;
@class CoreImage_CIQRCodeGenerator;
@class CoreImage_CIRadialGradient;
@class CoreImage_CIRandomGenerator;
@class CoreImage_CIRippleTransition;
@class CoreImage_CIRowAverage;
@class CoreImage_CISaturationBlendMode;
@class CoreImage_CIScreenBlendMode;
@class CoreImage_CISepiaTone;
@class CoreImage_CIShadedMaterial;
@class CoreImage_CISharpenLuminance;
@class CoreImage_CISixfoldReflectedTile;
@class CoreImage_CISixfoldRotatedTile;
@class CoreImage_CISmoothLinearGradient;
@class CoreImage_CISoftLightBlendMode;
@class CoreImage_CISourceAtopCompositing;
@class CoreImage_CISourceInCompositing;
@class CoreImage_CISourceOutCompositing;
@class CoreImage_CISourceOverCompositing;
@class CoreImage_CISpotColor;
@class CoreImage_CISpotLight;
@class CoreImage_CISRGBToneCurveToLinear;
@class CoreImage_CIStarShineGenerator;
@class CoreImage_CIStraightenFilter;
@class CoreImage_CIStretchCrop;
@class CoreImage_CIStripesGenerator;
@class CoreImage_CISubtractBlendMode;
@class CoreImage_CISunbeamsGenerator;
@class CoreImage_CISwipeTransition;
@class CoreImage_CITemperatureAndTint;
@class CoreImage_CITextImageGenerator;
@class CoreImage_CIThermal;
@class CoreImage_CIToneCurve;
@class CoreImage_CITorusLensDistortion;
@class CoreImage_CITriangleKaleidoscope;
@class CoreImage_CITriangleTile;
@class CoreImage_CITwelvefoldReflectedTile;
@class CoreImage_CITwirlDistortion;
@class CoreImage_CIUnsharpMask;
@class CoreImage_CIVibrance;
@class CoreImage_CIVignette;
@class CoreImage_CIVignetteEffect;
@class CoreImage_CIVortexDistortion;
@class CoreImage_CIWhitePointAdjust;
@class CoreImage_CIXRay;
@class CoreImage_CIZoomBlur;
@class NSFetchedResultsControllerDelegate;
@class NSFetchedResultsSectionInfo;
@class CALayerDelegate;
@class CAAnimationDelegate;
@class CAMediaTiming;
@class CKRecordValue;
@class CXCallDirectoryExtensionContextDelegate;
@class CXCallObserverDelegate;
@class CXProviderDelegate;
@class ARSCNViewDelegate;
@class ARSessionDelegate;
@class ARSKViewDelegate;
@class ABNewPersonViewControllerDelegate;
@class AddressBookUI_InternalABNewPersonViewControllerDelegate;
@class ABPeoplePickerNavigationControllerDelegate;
@class AddressBookUI_InternalABPeoplePickerNavigationControllerDelegate;
@class ABPersonViewControllerDelegate;
@class AddressBookUI_InternalABPersonViewControllerDelegate;
@class ABUnknownPersonViewControllerDelegate;
@class AddressBookUI_InternalABUnknownPersonViewControllerDelegate;
@class SKPhysicsContactDelegate;
@class SKSceneDelegate;
@class SKViewDelegate;
@class SCNAnimatable;
@class SCNSceneRenderer;
@class SCNActionable;
@class SCNAvoidOccluderConstraintDelegate;
@class SCNBoundingVolume;
@class SCNCameraControllerDelegate;
@class SCNNodeRendererDelegate;
@class SCNPhysicsContactDelegate;
@class SCNProgramDelegate;
@class SCNSceneExportDelegate;
@class SCNSceneRendererDelegate;
@class SCNShadable;
@class SCNTechniqueSupport;
@class GKLocalPlayerListener;
@class GKSessionDelegate;
@class GameKit_Mono_GKSessionDelegate;
@class GKAchievementViewControllerDelegate;
@class GKChallengeEventHandlerDelegate;
@class GKChallengeListener;
@class GKFriendRequestComposeViewControllerDelegate;
@class GKGameCenterControllerDelegate;
@class GKInviteEventListener;
@class GKLeaderboardViewControllerDelegate;
@class GKMatchDelegate;
@class GKMatchmakerViewControllerDelegate;
@class GKPeerPickerControllerDelegate;
@class GKSavedGameListener;
@class GKTurnBasedEventHandlerDelegate;
@class GKTurnBasedEventListener;
@class GKTurnBasedMatchmakerViewControllerDelegate;
@class GKVoiceChatClient;
@class WKNavigationDelegate;
@class WKScriptMessageHandler;
@class WKUIDelegate;
@class UIAdaptivePresentationControllerDelegate;
@class UIKit_UIControlEventProxy;
@class __MonoTouch_UIImageStatusDispatcher;
@class UIPopoverPresentationControllerDelegate;
@class __MonoTouch_UIVideoStatusDispatcher;
@class NSLayoutManagerDelegate;
@class NSTextAttachmentContainer;
@class NSTextStorageDelegate;
@class UIAccelerometerDelegate;
@protocol UIAccessibilityContainer;
@class UIAccessibilityContainerDataTable;
@class UIActionSheetDelegate;
@class UIActivityItemSource;
@class UIAlertViewDelegate;
@class UIAppearanceContainer;
@class UIBarPositioning;
@class UIBarPositioningDelegate;
@class UICloudSharingControllerDelegate;
@protocol UICollectionViewSource;
@class UICollectionViewDataSource;
@class UICollectionViewDelegate;
@class UICollectionViewDelegateFlowLayout;
@class UICollectionViewDragDelegate;
@class UICollectionViewDropDelegate;
@class UICollectionViewSource;
@class UICollisionBehaviorDelegate;
@class UIContentContainer;
@class UICoordinateSpace;
@class UIDocumentBrowserViewControllerDelegate;
@class UIDocumentInteractionControllerDelegate;
@class UIDocumentMenuDelegate;
@class UIDocumentPickerDelegate;
@class UIDragInteractionDelegate;
@class UIDropInteractionDelegate;
@class UIDynamicAnimatorDelegate;
@class UIDynamicItem;
@class UIGestureRecognizerDelegate;
@class UIImagePickerControllerDelegate;
@class UILayoutSupport;
@class UINavigationBarDelegate;
@class UIObjectRestoration;
@class UIPageViewControllerDataSource;
@class UIPageViewControllerDelegate;
@class UIPickerViewDelegate;
@class UIPickerViewAccessibilityDelegate;
@class UIPickerViewDataSource;
@protocol UIPickerViewModel;
@class UIPickerViewModel;
@class UIPopoverControllerDelegate;
@class UIPreviewInteractionDelegate;
@class UIPrinterPickerControllerDelegate;
@class UIPrintInteractionControllerDelegate;
@class UIScrollViewAccessibilityDelegate;
@class UISearchBarDelegate;
@class UISearchControllerDelegate;
@class UISearchDisplayDelegate;
@class UISearchResultsUpdating;
@class UISplitViewControllerDelegate;
@class UIStateRestoring;
@class UITabBarControllerDelegate;
@class UITabBarDelegate;
@class Xamarin_iOS__UIKit_UITableViewDataSource;
@class UITableViewDelegate;
@class UITableViewDragDelegate;
@class UITableViewDropDelegate;
@class UITextDocumentProxy;
@class UITextDragDelegate;
@class UITextDropDelegate;
@class UITextFieldDelegate;
@class UITextInputDelegate;
@class UITextInputTokenizer;
@class UITextPasteDelegate;
@class UITextViewDelegate;
@class UIToolbarDelegate;
@class UITraitEnvironment;
@class UIVideoEditorControllerDelegate;
@class UIViewControllerAnimatedTransitioning;
@class UIViewControllerContextTransitioning;
@class UIViewControllerInteractiveTransitioning;
@class UIViewControllerPreviewingDelegate;
@class UIViewControllerTransitioningDelegate;
@class UIWebViewDelegate;
@class NSFileManagerDelegate;
@class Foundation_InternalNSNotificationHandler;
@class __MonoMac_NSActionDispatcher;
@class __MonoMac_ActionDispatcher;
@class __Xamarin_NSTimerActionDispatcher;
@class __MonoMac_NSAsyncActionDispatcher;
@class NSCacheDelegate;
@class NSCoding;
@class NSCopying;
@class NSExtensionRequestHandling;
@class NSFilePresenter;
@class NSKeyedArchiverDelegate;
@class NSKeyedUnarchiverDelegate;
@class NSPortDelegate;
@class NSMachPortDelegate;
@class NSMetadataQueryDelegate;
@class NSMutableCopying;
@class NSNetServiceBrowserDelegate;
@class NSNetServiceDelegate;
@class NSStreamDelegate;
@class NSURLAuthenticationChallengeSender;
@class NSURLConnectionDelegate;
@class NSURLConnectionDataDelegate;
@class NSURLConnectionDownloadDelegate;
@class NSURLSessionDelegate;
@class NSURLSessionTaskDelegate;
@class NSURLSessionDataDelegate;
@class NSURLSessionDownloadDelegate;
@class NSURLSessionStreamDelegate;
@class NSUserActivityDelegate;
@class CBCentralManagerDelegate;
@class CBPeripheralDelegate;
@class CBPeripheralManagerDelegate;
@class AVPictureInPictureControllerDelegate;
@class AVPlayerViewControllerDelegate;
@class AVRoutePickerViewDelegate;
@class AVCaptureAudioDataOutputSampleBufferDelegate;
@class AVAudioPlayerDelegate;
@class AVFoundation_InternalAVAudioPlayerDelegate;
@class AVAudioRecorderDelegate;
@class AVFoundation_InternalAVAudioRecorderDelegate;
@class AVAudioSessionDelegate;
@class AVFoundation_InternalAVAudioSessionDelegate;
@class AVAssetDownloadDelegate;
@class AVAssetResourceLoaderDelegate;
@class AVAsynchronousKeyValueLoading;
@class AVAudio3DMixing;
@class AVAudioStereoMixing;
@class AVCaptureDataOutputSynchronizerDelegate;
@class AVCaptureDepthDataOutputDelegate;
@class AVCaptureFileOutputRecordingDelegate;
@class AVCaptureMetadataOutputObjectsDelegate;
@class AVCapturePhotoCaptureDelegate;
@class AVCaptureVideoDataOutputSampleBufferDelegate;
@class AVContentKeySessionDelegate;
@class AVPlayerItemOutputPushDelegate;
@class AVPlayerItemLegibleOutputPushDelegate;
@class AVPlayerItemMetadataCollectorPushDelegate;
@class AVPlayerItemMetadataOutputPushDelegate;
@class AVPlayerItemOutputPullDelegate;
@class AVSpeechSynthesizerDelegate;
@class AVVideoCompositing;
@class AppDelegate;
@class checkResultViewController;
@class contactController;
@class filterParticipationViewController;
@class filterRaceViewController;
@class menuViewController;
@class RaceResultViewController;
@class KemblaJoggers_employeeTVS;
@class RaceResultsCell;
@class reportController;
@class settingController;
@class ViewController;
@class viewRaceRecordViewController;
@class viewSeriesRecordViewController;
@class handicapViewController;
@class KemblaJoggers_TableSource;
@class timeEventViewController;
@class ParticipationViewController;
@class addNewRecordViewController;
@class CheckResultCell;
@class KemblaJoggers_checkResultDataSource;
@class KemblaJoggers_filterRaceDataSource;
@class HandicapCell;
@class LapCell;
@class KemblaJoggers_LapDataSource;
@class ParticipationCell;
@class KemblaJoggers_ParticipationDataSource;
@class RaceRecordCell;
@class KemblaJoggers_RaceRecordsDataSource;
@class SeriesRecordCell;
@class KemblaJoggers_SeriesRecordDataSource;
@class eventViewController;
@class courseManagementViewController;
@class pointScoresViewController;
@class loginController;
@class KemblaJoggers_ContactDataSource;
@class KemblaJoggers_HandicapDataSource;
@class chooseLocationViewController;
@class selectRecordTypeViewController;
@class QuickLook_QLPreviewController__QLPreviewControllerDelegate;
@class UIKit_UIView_UIViewAppearance;
@class Messages_MSStickerBrowserView_MSStickerBrowserViewAppearance;
@class Messages_MSStickerView_MSStickerViewAppearance;
@class iAd_ADBannerView__ADBannerViewDelegate;
@class iAd_ADBannerView_ADBannerViewAppearance;
@class iAd_ADInterstitialAd__ADInterstitialAdDelegate;
@class HealthKitUI_HKActivityRingView_HKActivityRingViewAppearance;
@class ExternalAccessory_EAAccessory__EAAccessoryDelegate;
@class ExternalAccessory_EAWiFiUnconfiguredAccessoryBrowser__EAWiFiUnconfiguredAccessoryBrowserDelegate;
@class CoreAudioKit_CAInterAppAudioSwitcherView_CAInterAppAudioSwitcherViewAppearance;
@class CoreAudioKit_CAInterAppAudioTransportView_CAInterAppAudioTransportViewAppearance;
@class PhotosUI_PHLivePhotoView_PHLivePhotoViewAppearance;
@class StoreKit_SKRequest__SKRequestDelegate;
@class StoreKit_SKProductsRequest__SKProductsRequestDelegate;
@class StoreKit_SKStoreProductViewController__SKStoreProductViewControllerDelegate;
@class Photos_PHPhotoLibrary___phlib_observer;
@class PdfKit_PdfDocument__PdfDocumentDelegate;
@class PdfKit_PdfThumbnailView_PdfThumbnailViewAppearance;
@class PdfKit_PdfView__PdfViewDelegate;
@class PdfKit_PdfView_PdfViewAppearance;
@class UIKit_UIControl_UIControlAppearance;
@class UIKit_UIButton_UIButtonAppearance;
@class PassKit_PKAddPassButton_PKAddPassButtonAppearance;
@class PassKit_PKAddPassesViewController__PKAddPassesViewControllerDelegate;
@class PassKit_PKPaymentAuthorizationViewController__PKPaymentAuthorizationViewControllerDelegate;
@class PassKit_PKPaymentButton_PKPaymentButtonAppearance;
@class MetalKit_MTKView_MTKViewAppearance;
@class MessageUI_MFMailComposeViewController_MFMailComposeViewControllerAppearance;
@class MessageUI_MFMessageComposeViewController_MFMessageComposeViewControllerAppearance;
@class MediaPlayer_MPMediaPickerController__MPMediaPickerControllerDelegate;
@class MediaPlayer_MPVolumeView_MPVolumeViewAppearance;
@class MapKit_MKOverlayView_MKOverlayViewAppearance;
@class MapKit_MKAnnotationView_MKAnnotationViewAppearance;
@class MapKit_MKOverlayPathView_MKOverlayPathViewAppearance;
@class MapKit_MKCircleView_MKCircleViewAppearance;
@class MapKit_MKCompassButton_MKCompassButtonAppearance;
@class MapKit_MKMapView__MKMapViewDelegate;
@class MapKit_MKMapView_MKMapViewAppearance;
@class MapKit_MKMarkerAnnotationView_MKMarkerAnnotationViewAppearance;
@class MapKit_MKPinAnnotationView_MKPinAnnotationViewAppearance;
@class MapKit_MKPolygonView_MKPolygonViewAppearance;
@class MapKit_MKPolylineView_MKPolylineViewAppearance;
@class MapKit_MKScaleView_MKScaleViewAppearance;
@class UIKit_UIBarItem_UIBarItemAppearance;
@class UIKit_UIBarButtonItem_UIBarButtonItemAppearance;
@class MapKit_MKUserTrackingBarButtonItem_MKUserTrackingBarButtonItemAppearance;
@class MapKit_MKUserTrackingButton_MKUserTrackingButtonAppearance;
@class HomeKit_HMHome__HMHomeDelegate;
@class HomeKit_HMAccessory__HMAccessoryDelegate;
@class HomeKit_HMAccessoryBrowser__HMAccessoryBrowserDelegate;
@class HomeKit_HMCameraView_HMCameraViewAppearance;
@class HomeKit_HMHomeManager__HMHomeManagerDelegate;
@class GLKit_GLKView__GLKViewDelegate;
@class GLKit_GLKView_GLKViewAppearance;
@class EventKitUI_EKCalendarChooser__EKCalendarChooserDelegate;
@class EventKitUI_EKEventEditViewController__EKEventEditViewDelegate;
@class EventKitUI_EKEventEditViewController_EKEventEditViewControllerAppearance;
@class EventKitUI_EKEventViewController__EKEventViewDelegate;
@class CoreLocation_CLLocationManager__CLLocationManagerDelegate;
@class CoreAnimation_CAAnimation__CAAnimationDelegate;
@class BusinessChat_BCChatButton_BCChatButtonAppearance;
@class SceneKit_SCNView_SCNViewAppearance;
@class ARKit_ARSCNView_ARSCNViewAppearance;
@class SpriteKit_SKView_SKViewAppearance;
@class ARKit_ARSKView_ARSKViewAppearance;
@class AddressBookUI_ABPeoplePickerNavigationController_ABPeoplePickerNavigationControllerAppearance;
@class SpriteKit_SKPhysicsWorld__SKPhysicsContactDelegate;
@class SceneKit_SCNPhysicsWorld__SCNPhysicsContactDelegate;
@class MonoTouch_GKSession_ReceivedObject;
@class GameKit_GKMatch__GKMatchDelegate;
@class GameKit_GKGameCenterViewController__GKGameCenterControllerDelegate;
@class GameKit_GKAchievementViewController__GKAchievementViewControllerDelegate;
@class GameKit_GKAchievementViewController_GKAchievementViewControllerAppearance;
@class GameKit_GKChallengeEventHandler__GKChallengeEventHandlerDelegate;
@class GameKit_GKFriendRequestComposeViewController__GKFriendRequestComposeViewControllerDelegate;
@class GameKit_GKFriendRequestComposeViewController_GKFriendRequestComposeViewControllerAppearance;
@class GameKit_GKLeaderboardViewController__GKLeaderboardViewControllerDelegate;
@class GameKit_GKLeaderboardViewController_GKLeaderboardViewControllerAppearance;
@class GameKit_GKMatchmakerViewController__GKMatchmakerViewControllerDelegate;
@class GameKit_GKTurnBasedMatchmakerViewController_GKTurnBasedMatchmakerViewControllerAppearance;
@class WebKit_WKWebView_WKWebViewAppearance;
@class UIKit_UIPreviewInteraction__UIPreviewInteractionDelegate;
@class __MonoMac_FuncBoolDispatcher;
@class UIKit_UIActionSheet__UIActionSheetDelegate;
@class UIKit_UIActionSheet_UIActionSheetAppearance;
@class UIKit_UIAlertView__UIAlertViewDelegate;
@class UIKit_UIAlertView_UIAlertViewAppearance;
@class UIKit_UIBarButtonItem_Callback;
@class UIKit_UIScrollView_UIScrollViewAppearance;
@class UIKit_UICollectionView_UICollectionViewAppearance;
@class UIKit_UIDocumentMenuViewController__UIDocumentMenuDelegate;
@class UIKit_UIDocumentPickerViewController__UIDocumentPickerDelegate;
@class __UIGestureRecognizerToken;
@class __UIGestureRecognizerParameterlessToken;
@class __UIGestureRecognizerParametrizedToken;
@class UIKit_UIGestureRecognizer__UIGestureRecognizerDelegate;
@class __UIRotationGestureRecognizer;
@class __UILongPressGestureRecognizer;
@class __UITapGestureRecognizer;
@class __UIPanGestureRecognizer;
@class __UIPinchGestureRecognizer;
@class __UISwipeGestureRecognizer;
@class __UIScreenEdgePanGestureRecognizer;
@class UIKit_UIImagePickerController__UIImagePickerControllerDelegate;
@class UIKit_UINavigationBar_UINavigationBarAppearance;
@class UIKit_UIPageViewController__UIPageViewControllerDelegate;
@class UIKit_UIPageViewController__UIPageViewControllerDataSource;
@class UIKit_UIPickerView_UIPickerViewAppearance;
@class UIKit_UIPopoverController__UIPopoverControllerDelegate;
@class UIKit_UIPopoverPresentationController__UIPopoverPresentationControllerDelegate;
@class UIKit_UISearchBar_UISearchBarAppearance;
@class UIKit_UISearchBar__UISearchBarDelegate;
@class UIKit_UISearchController___Xamarin_UISearchResultsUpdating;
@class UIKit_UISegmentedControl_UISegmentedControlAppearance;
@class UIKit_UITableView_UITableViewAppearance;
@class UIKit_UITableViewCell_UITableViewCellAppearance;
@class UIKit_UITextField__UITextFieldDelegate;
@class UIKit_UITextField_UITextFieldAppearance;
@class UIKit_UIScrollView__UIScrollViewDelegate;
@class UIKit_UITextView__UITextViewDelegate;
@class UIKit_UITextView_UITextViewAppearance;
@class UIKit_UIToolbar_UIToolbarAppearance;
@class UIKit_UIView__UIViewStaticCallback;
@class UIKit_UIWindow_UIWindowAppearance;
@class UIKit_UIPrintInteractionController__UIPrintInteractionControllerDelegate;
@class UIKit_NSTextStorage__NSTextStorageDelegate;
@class UIKit_UIAccelerometer__UIAccelerometerDelegate;
@class UIKit_UIActivityIndicatorView_UIActivityIndicatorViewAppearance;
@class UIKit_UICollectionReusableView_UICollectionReusableViewAppearance;
@class UIKit_UICollectionViewCell_UICollectionViewCellAppearance;
@class UIKit_UICollisionBehavior__UICollisionBehaviorDelegate;
@class UIKit_UIDatePicker_UIDatePickerAppearance;
@class UIKit_UIDocumentInteractionController__UIDocumentInteractionControllerDelegate;
@class UIKit_UIImageView_UIImageViewAppearance;
@class UIKit_UIInputView_UIInputViewAppearance;
@class UIKit_UILabel_UILabelAppearance;
@class UIKit_UIPageControl_UIPageControlAppearance;
@class UIKit_UIPopoverBackgroundView_UIPopoverBackgroundViewAppearance;
@class UIKit_UIProgressView_UIProgressViewAppearance;
@class UIKit_UIRefreshControl_UIRefreshControlAppearance;
@class UIKit_UISlider_UISliderAppearance;
@class UIKit_UISplitViewController__UISplitViewControllerDelegate;
@class UIKit_UIStackView_UIStackViewAppearance;
@class UIKit_UIStepper_UIStepperAppearance;
@class UIKit_UISwitch_UISwitchAppearance;
@class UIKit_UITabBar__UITabBarDelegate;
@class UIKit_UITabBar_UITabBarAppearance;
@class UIKit_UITabBarController__UITabBarControllerDelegate;
@class UIKit_UITabBarItem_UITabBarItemAppearance;
@class UIKit_UITableViewHeaderFooterView_UITableViewHeaderFooterViewAppearance;
@class UIKit_UIVideoEditorController__UIVideoEditorControllerDelegate;
@class UIKit_UIVisualEffectView_UIVisualEffectViewAppearance;
@class UIKit_UIWebView__UIWebViewDelegate;
@class UIKit_UIWebView_UIWebViewAppearance;
@class Foundation_NSKeyedArchiver__NSKeyedArchiverDelegate;
@class Foundation_NSKeyedUnarchiver__NSKeyedUnarchiverDelegate;
@class Foundation_NSNetService__NSNetServiceDelegate;
@class Foundation_NSStream__NSStreamDelegate;
@class __NSObject_Disposer;
@class __XamarinObjectObserver;
@class Foundation_NSCache__NSCacheDelegate;
@class Foundation_NSMetadataQuery__NSMetadataQueryDelegate;
@class Foundation_NSNetServiceBrowser__NSNetServiceBrowserDelegate;
@class CoreBluetooth_CBCentralManager__CBCentralManagerDelegate;
@class CoreBluetooth_CBPeripheralManager__CBPeripheralManagerDelegate;
@class CoreBluetooth_CBPeripheral__CBPeripheralDelegate;
@class AVKit_AVRoutePickerView_AVRoutePickerViewAppearance;
@class AVFoundation_AVCaptureFileOutput_recordingProxy;
@class AVFoundation_AVSpeechSynthesizer__AVSpeechSynthesizerDelegate;
@class FIRDatabaseQuery;
@class FIRDatabaseReference;
@class FIRDataSnapshot;
@class FIRMutableData;
@class FIRDatabase;
@class FIRServerValue;
@class FIRTransactionResult;
@class FIRAnalyticsConfiguration;
@class FIRApp;
@class FIRConfiguration;
@class FIROptions;
@class FIRInstanceID;
@class FIRAnalytics;
@class FIRActionCodeInfo;
@class FIRActionCodeSettings;
@class FIRAdditionalUserInfo;
@class FIRAuthCredential;
@class FIRAuthDataResult;
@protocol FIRAuthUIDelegate;
@class FIRAuthUIDelegate;
@class FIREmailAuthProvider;
@class FIRFacebookAuthProvider;
@class FIRGitHubAuthProvider;
@class FIRGoogleAuthProvider;
@class FIROAuthProvider;
@class FIRPhoneAuthCredential;
@class FIRTwitterAuthProvider;
@protocol FIRUserInfo;
@class FIRUserMetadata;
@class FIRAuth;
@class FIRPhoneAuthProvider;
@class FIRUser;
@class FIRUserProfileChangeRequest;
@class Xamarin_Controls_ProgressLabel;
@class Xamarin_Auth_NativeAuthSafariViewControllerDelegate;
@class Xamarin_Auth_FormAuthenticatorController_FormDelegate;
@class Xamarin_Auth_FormAuthenticatorController;
@class Xamarin_Auth_WebAuthenticatorController_UIWebViewDelegate;
@class Xamarin_Auth_WebAuthenticatorController_WKWebViewUIDelegate;
@class Xamarin_Auth_WebAuthenticatorController_WKWebViewNavigationDelegate;
@class Xamarin_Auth_WebAuthenticatorController_WKWebViewJacascriptMessageHandler;
@class Xamarin_Auth_WebAuthenticatorController;
@class Xamarin_Auth_FormAuthenticatorController_FieldCell;
@class Xamarin_Auth_FormAuthenticatorController_FormDataSource;
@class System_Net_Http_NSUrlSessionHandler_WrappedNSInputStream;
@class System_Net_Http_NSUrlSessionHandler_NSUrlSessionHandlerDelegate;
@class OpenTK_Platform_iPhoneOS_CADisplayLinkTimeSource;
@class OpenTK_Platform_iPhoneOS_iPhoneOSGameView;

@interface UIApplicationDelegate : NSObject<UIApplicationDelegate> {
}
	-(id) init;
@end

@interface UIScrollViewDelegate : NSObject<UIScrollViewDelegate> {
}
	-(id) init;
@end

@interface UITableViewSource : NSObject<UIScrollViewDelegate> {
}
	-(id) init;
@end

@interface SFSpeechRecognitionTaskDelegate : NSObject<SFSpeechRecognitionTaskDelegate> {
}
	-(id) init;
@end

@interface SFSpeechRecognizerDelegate : NSObject<SFSpeechRecognizerDelegate> {
}
	-(id) init;
@end

@interface SFSafariViewControllerDelegate : NSObject<SFSafariViewControllerDelegate> {
}
	-(id) init;
@end

@interface QLPreviewControllerDataSource : NSObject<QLPreviewControllerDataSource> {
}
	-(id) init;
@end

@interface QLPreviewControllerDelegate : NSObject<QLPreviewControllerDelegate> {
}
	-(id) init;
@end

@interface QLPreviewItem : NSObject<QLPreviewItem> {
}
	-(id) init;
@end

@interface PKPushRegistryDelegate : NSObject<PKPushRegistryDelegate> {
}
	-(id) init;
@end

@interface NCWidgetProviding : NSObject<NCWidgetProviding> {
}
	-(id) init;
@end

@interface MSStickerBrowserViewDataSource : NSObject<MSStickerBrowserViewDataSource> {
}
	-(id) init;
@end

@interface ADBannerViewDelegate : NSObject<ADBannerViewDelegate> {
}
	-(id) init;
@end

@interface ADInterstitialAdDelegate : NSObject<ADInterstitialAdDelegate> {
}
	-(id) init;
@end

@interface EAAccessoryDelegate : NSObject<EAAccessoryDelegate> {
}
	-(id) init;
@end

@interface EAWiFiUnconfiguredAccessoryBrowserDelegate : NSObject<EAWiFiUnconfiguredAccessoryBrowserDelegate> {
}
	-(id) init;
@end

@interface NFCNDEFReaderSessionDelegate : NSObject<NFCNDEFReaderSessionDelegate> {
}
	-(id) init;
@end

@interface NFCReaderSessionDelegate : NSObject<NFCReaderSessionDelegate> {
}
	-(id) init;
@end

@interface CNContactPickerDelegate : NSObject<CNContactPickerDelegate> {
}
	-(id) init;
@end

@interface CNContactViewControllerDelegate : NSObject<CNContactViewControllerDelegate> {
}
	-(id) init;
@end

@interface WCSessionDelegate : NSObject<WCSessionDelegate> {
}
	-(id) init;
@end

@interface PHContentEditingController : NSObject<PHContentEditingController> {
}
	-(id) init;
@end

@interface PHLivePhotoViewDelegate : NSObject<PHLivePhotoViewDelegate> {
}
	-(id) init;
@end

@interface VSAccountManagerDelegate : NSObject<VSAccountManagerDelegate> {
}
	-(id) init;
@end

@interface UNUserNotificationCenterDelegate : NSObject<UNUserNotificationCenterDelegate> {
}
	-(id) init;
@end

@interface SKPaymentTransactionObserver : NSObject<SKPaymentTransactionObserver> {
}
	-(id) init;
@end

@interface SKCloudServiceSetupViewControllerDelegate : NSObject<SKCloudServiceSetupViewControllerDelegate> {
}
	-(id) init;
@end

@interface SKRequestDelegate : NSObject<SKRequestDelegate> {
}
	-(id) init;
@end

@interface SKProductsRequestDelegate : NSObject<SKProductsRequestDelegate, SKRequestDelegate> {
}
	-(id) init;
@end

@interface SKStoreProductViewControllerDelegate : NSObject<SKStoreProductViewControllerDelegate> {
}
	-(id) init;
@end

@interface RPBroadcastActivityViewControllerDelegate : NSObject<RPBroadcastActivityViewControllerDelegate> {
}
	-(id) init;
@end

@interface RPBroadcastControllerDelegate : NSObject<RPBroadcastControllerDelegate> {
}
	-(id) init;
@end

@interface RPPreviewViewControllerDelegate : NSObject<RPPreviewViewControllerDelegate> {
}
	-(id) init;
@end

@interface RPScreenRecorderDelegate : NSObject<RPScreenRecorderDelegate> {
}
	-(id) init;
@end

@interface PHPhotoLibraryChangeObserver : NSObject<PHPhotoLibraryChangeObserver> {
}
	-(id) init;
@end

@interface PDFDocumentDelegate : NSObject<PDFDocumentDelegate> {
}
	-(id) init;
@end

@interface PDFViewDelegate : NSObject<PDFViewDelegate> {
}
	-(id) init;
@end

@interface PKAddPassesViewControllerDelegate : NSObject<PKAddPassesViewControllerDelegate> {
}
	-(id) init;
@end

@interface PKAddPaymentPassViewControllerDelegate : NSObject<PKAddPaymentPassViewControllerDelegate> {
}
	-(id) init;
@end

@interface PKPaymentAuthorizationControllerDelegate : NSObject<PKPaymentAuthorizationControllerDelegate> {
}
	-(id) init;
@end

@interface PKPaymentAuthorizationViewControllerDelegate : NSObject<PKPaymentAuthorizationViewControllerDelegate> {
}
	-(id) init;
@end

@interface NWTCPConnectionAuthenticationDelegate : NSObject<NWTCPConnectionAuthenticationDelegate> {
}
	-(id) init;
@end

@interface MCAdvertiserAssistantDelegate : NSObject<MCAdvertiserAssistantDelegate> {
}
	-(id) init;
@end

@interface MCBrowserViewControllerDelegate : NSObject<MCBrowserViewControllerDelegate> {
}
	-(id) init;
@end

@interface MCNearbyServiceAdvertiserDelegate : NSObject<MCNearbyServiceAdvertiserDelegate> {
}
	-(id) init;
@end

@interface MCNearbyServiceBrowserDelegate : NSObject<MCNearbyServiceBrowserDelegate> {
}
	-(id) init;
@end

@interface MCSessionDelegate : NSObject<MCSessionDelegate> {
}
	-(id) init;
@end

@interface MDLLightProbeIrradianceDataSource : NSObject<MDLLightProbeIrradianceDataSource> {
}
	-(id) init;
@end

@interface UINavigationControllerDelegate : NSObject<UINavigationControllerDelegate> {
}
	-(id) init;
@end

@interface MFMailComposeViewControllerDelegate : NSObject<MFMailComposeViewControllerDelegate, UINavigationControllerDelegate> {
}
	-(id) init;
@end

@interface MFMessageComposeViewControllerDelegate : NSObject<MFMessageComposeViewControllerDelegate> {
}
	-(id) init;
@end

@interface MPPlayableContentDelegate : NSObject<MPPlayableContentDelegate> {
}
	-(id) init;
@end

@interface MPPlayableContentDataSource : NSObject<MPPlayableContentDataSource> {
}
	-(id) init;
@end

@interface MPMediaPickerControllerDelegate : NSObject<MPMediaPickerControllerDelegate> {
}
	-(id) init;
@end

@interface MKAnnotation : NSObject<MKAnnotation> {
}
	-(id) init;
@end

@interface MKLocalSearchCompleterDelegate : NSObject<MKLocalSearchCompleterDelegate> {
}
	-(id) init;
@end

@interface MKMapViewDelegate : NSObject<MKMapViewDelegate> {
}
	-(id) init;
@end

@interface MKOverlay : NSObject<MKOverlay, MKAnnotation> {
}
	-(id) init;
@end

@interface MKReverseGeocoderDelegate : NSObject<MKReverseGeocoderDelegate> {
}
	-(id) init;
@end

@interface Xamarin_iOS__JavaScriptCore_JSExport : NSObject<JSExport> {
}
	-(id) init;
@end

@interface HMAccessoryBrowserDelegate : NSObject<HMAccessoryBrowserDelegate> {
}
	-(id) init;
@end

@interface HMAccessoryDelegate : NSObject<HMAccessoryDelegate> {
}
	-(id) init;
@end

@interface HMCameraSnapshotControlDelegate : NSObject<HMCameraSnapshotControlDelegate> {
}
	-(id) init;
@end

@interface HMCameraStreamControlDelegate : NSObject<HMCameraStreamControlDelegate> {
}
	-(id) init;
@end

@interface HMHomeDelegate : NSObject<HMHomeDelegate> {
}
	-(id) init;
@end

@interface HMHomeManagerDelegate : NSObject<HMHomeManagerDelegate> {
}
	-(id) init;
@end

@interface GKAgentDelegate : NSObject<GKAgentDelegate> {
}
	-(id) init;
@end

@interface GLKNamedEffect : NSObject<GLKNamedEffect> {
}
	-(id) init;
@end

@interface GLKViewControllerDelegate : NSObject<GLKViewControllerDelegate> {
}
	-(id) init;
@end

@interface GLKViewDelegate : NSObject<GLKViewDelegate> {
}
	-(id) init;
@end

@interface EKCalendarChooserDelegate : NSObject<EKCalendarChooserDelegate> {
}
	-(id) init;
@end

@interface EKEventEditViewDelegate : NSObject<EKEventEditViewDelegate> {
}
	-(id) init;
@end

@interface EKEventViewDelegate : NSObject<EKEventViewDelegate> {
}
	-(id) init;
@end

@interface CSSearchableIndexDelegate : NSObject<CSSearchableIndexDelegate> {
}
	-(id) init;
@end

@interface CLLocationManagerDelegate : NSObject<CLLocationManagerDelegate> {
}
	-(id) init;
@end

@interface CoreImage_CIAccordionFoldTransition : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CICompositingFilter : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIAdditionCompositing : CoreImage_CICompositingFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIAffineFilter : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIAffineClamp : CoreImage_CIAffineFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIAffineTile : CoreImage_CIAffineFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIAffineTransform : CoreImage_CIAffineFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIAreaAverage : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIAreaHistogram : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIAreaMaximum : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIAreaMaximumAlpha : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIAreaMinimum : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIAreaMinimumAlpha : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIAreaMinMaxRed : CoreImage_CIAreaMaximum {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIImageGenerator : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIAttributedTextImageGenerator : CoreImage_CIImageGenerator {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CICodeGenerator : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIAztecCodeGenerator : CoreImage_CICodeGenerator {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIBarcodeGenerator : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CITransitionFilter : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIBarsSwipeTransition : CoreImage_CITransitionFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIBicubicScaleTransform : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIBlendFilter : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIBlendWithMask : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIBlendWithAlphaMask : CoreImage_CIBlendWithMask {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIBlendWithBlueMask : CoreImage_CIBlendWithMask {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIBlendWithRedMask : CoreImage_CIBlendWithMask {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIBloom : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CILinearBlur : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIBokehBlur : CoreImage_CILinearBlur {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIBoxBlur : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIDistortionFilter : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIBumpDistortion : CoreImage_CIDistortionFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIBumpDistortionLinear : CoreImage_CIDistortionFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CICheckerboardGenerator : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CICircleSplashDistortion : CoreImage_CIDistortionFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIScreenFilter : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CICircularScreen : CoreImage_CIScreenFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CICircularWrap : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIClamp : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CICmykHalftone : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CICode128BarcodeGenerator : CoreImage_CICodeGenerator {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColorBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColorBurnBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColorClamp : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColorControls : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColorCrossPolynomial : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColorCube : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColorCubesMixedWithMask : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColorCubeWithColorSpace : CoreImage_CIColorCube {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColorCurves : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColorDodgeBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColorInvert : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColorMap : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColorMatrix : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColorMonochrome : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColorPolynomial : CoreImage_CIColorCrossPolynomial {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColorPosterize : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIColumnAverage : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIComicEffect : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIConstantColorGenerator : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIConvolutionCore : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIConvolution3X3 : CoreImage_CIConvolutionCore {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIConvolution5X5 : CoreImage_CIConvolutionCore {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIConvolution7X7 : CoreImage_CIConvolutionCore {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIConvolution9Horizontal : CoreImage_CIConvolutionCore {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIConvolution9Vertical : CoreImage_CIConvolutionCore {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CICopyMachineTransition : CoreImage_CITransitionFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CICrop : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CICrystallize : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIDarkenBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIDepthBlurEffect : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIDepthDisparityConverter : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIDepthOfField : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIDepthToDisparity : CoreImage_CIDepthDisparityConverter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIDifferenceBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIDiscBlur : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIDisintegrateWithMaskTransition : CoreImage_CITransitionFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIDisparityToDepth : CoreImage_CIDepthDisparityConverter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIDisplacementDistortion : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIDissolveTransition : CoreImage_CITransitionFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIDivideBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIDotScreen : CoreImage_CIScreenFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIDroste : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIEdgePreserveUpsampleFilter : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIEdges : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIEdgeWork : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CITileFilter : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIEightfoldReflectedTile : CoreImage_CITileFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIExclusionBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIExposureAdjust : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIFaceBalance : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIFalseColor : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIFlashTransition : CoreImage_CITransitionFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIFourfoldReflectedTile : CoreImage_CITileFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIFourfoldRotatedTile : CoreImage_CITileFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIFourfoldTranslatedTile : CoreImage_CITileFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIGammaAdjust : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIGaussianBlur : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIGaussianGradient : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIGlassDistortion : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIGlassLozenge : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIGlideReflectedTile : CoreImage_CITileFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIGloom : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIHardLightBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIHatchedScreen : CoreImage_CIScreenFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIHeightFieldFromMask : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIHexagonalPixellate : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIHighlightShadowAdjust : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIHistogramDisplayFilter : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIHoleDistortion : CoreImage_CIDistortionFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIHueAdjust : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIHueBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIHueSaturationValueGradient : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@protocol CIImageProvider
	@required -(void) provideImageData:(void *)p0 bytesPerRow:(NSUInteger)p1 origin:(NSUInteger)p2 :(NSUInteger)p3 size:(NSUInteger)p4 :(NSUInteger)p5 userInfo:(NSObject *)p6;
@end

@interface CoreImage_CIKaleidoscope : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CILabDeltaE : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CILanczosScaleTransform : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CILenticularHaloGenerator : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CILightenBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CILightTunnel : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CILinearBurnBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CILinearDodgeBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CILinearGradient : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CILinearToSRGBToneCurve : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CILineOverlay : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CILineScreen : CoreImage_CIScreenFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CILuminosityBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIMaskedVariableBlur : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIMaskToAlpha : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIMaximumComponent : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIMaximumCompositing : CoreImage_CICompositingFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIMedianFilter : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIMinimumComponent : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIMinimumCompositing : CoreImage_CICompositingFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIModTransition : CoreImage_CITransitionFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIMorphology : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIMorphologyGradient : CoreImage_CIMorphology {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIMorphologyMaximum : CoreImage_CIMorphology {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIMorphologyMinimum : CoreImage_CIMorphology {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIMotionBlur : CoreImage_CILinearBlur {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIMultiplyBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIMultiplyCompositing : CoreImage_CICompositingFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CINinePartStretched : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CINinePartTiled : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CINoiseReduction : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIOpTile : CoreImage_CITileFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIOverlayBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPageCurlTransition : CoreImage_CITransitionFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPageCurlWithShadowTransition : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIParallelogramTile : CoreImage_CITileFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPdf417BarcodeGenerator : CoreImage_CICodeGenerator {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPerspectiveTransform : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPerspectiveCorrection : CoreImage_CIPerspectiveTransform {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPerspectiveTile : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPerspectiveTransformWithExtent : CoreImage_CIPerspectiveTransform {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPhotoEffect : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPhotoEffectChrome : CoreImage_CIPhotoEffect {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPhotoEffectFade : CoreImage_CIPhotoEffect {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPhotoEffectInstant : CoreImage_CIPhotoEffect {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPhotoEffectMono : CoreImage_CIPhotoEffect {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPhotoEffectNoir : CoreImage_CIPhotoEffect {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPhotoEffectProcess : CoreImage_CIPhotoEffect {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPhotoEffectTonal : CoreImage_CIPhotoEffect {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPhotoEffectTransfer : CoreImage_CIPhotoEffect {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPinchDistortion : CoreImage_CIDistortionFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPinLightBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPixellate : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIPointillize : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIQRCodeGenerator : CoreImage_CICodeGenerator {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIRadialGradient : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIRandomGenerator : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIRippleTransition : CoreImage_CITransitionFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIRowAverage : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISaturationBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIScreenBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISepiaTone : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIShadedMaterial : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISharpenLuminance : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISixfoldReflectedTile : CoreImage_CITileFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISixfoldRotatedTile : CoreImage_CITileFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISmoothLinearGradient : CoreImage_CILinearGradient {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISoftLightBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISourceAtopCompositing : CoreImage_CICompositingFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISourceInCompositing : CoreImage_CICompositingFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISourceOutCompositing : CoreImage_CICompositingFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISourceOverCompositing : CoreImage_CICompositingFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISpotColor : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISpotLight : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISRGBToneCurveToLinear : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIStarShineGenerator : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIStraightenFilter : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIStretchCrop : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIStripesGenerator : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISubtractBlendMode : CoreImage_CIBlendFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISunbeamsGenerator : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CISwipeTransition : CoreImage_CITransitionFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CITemperatureAndTint : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CITextImageGenerator : CoreImage_CIImageGenerator {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIThermal : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIToneCurve : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CITorusLensDistortion : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CITriangleKaleidoscope : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CITriangleTile : CoreImage_CITileFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CITwelvefoldReflectedTile : CoreImage_CITileFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CITwirlDistortion : CoreImage_CIDistortionFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIUnsharpMask : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIVibrance : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIVignette : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIVignetteEffect : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIVortexDistortion : CoreImage_CIDistortionFilter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIWhitePointAdjust : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIXRay : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface CoreImage_CIZoomBlur : CIFilter {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface NSFetchedResultsControllerDelegate : NSObject<NSFetchedResultsControllerDelegate> {
}
	-(id) init;
@end

@interface NSFetchedResultsSectionInfo : NSObject<NSFetchedResultsSectionInfo> {
}
	-(id) init;
@end

@interface CALayerDelegate : NSObject<CALayerDelegate> {
}
	-(id) init;
@end

@interface CAAnimationDelegate : NSObject<CAAnimationDelegate> {
}
	-(id) init;
@end

@interface CAMediaTiming : NSObject<CAMediaTiming> {
}
	-(id) init;
@end

@interface CKRecordValue : NSObject<CKRecordValue> {
}
	-(id) init;
@end

@interface CXCallDirectoryExtensionContextDelegate : NSObject<CXCallDirectoryExtensionContextDelegate> {
}
	-(id) init;
@end

@interface CXCallObserverDelegate : NSObject<CXCallObserverDelegate> {
}
	-(id) init;
@end

@interface CXProviderDelegate : NSObject<CXProviderDelegate> {
}
	-(id) init;
@end

@interface ARSCNViewDelegate : NSObject<ARSCNViewDelegate> {
}
	-(id) init;
@end

@interface ARSessionDelegate : NSObject<ARSessionDelegate> {
}
	-(id) init;
@end

@interface ARSKViewDelegate : NSObject<ARSKViewDelegate> {
}
	-(id) init;
@end

@interface ABNewPersonViewControllerDelegate : NSObject<ABNewPersonViewControllerDelegate> {
}
	-(id) init;
@end

@interface ABPeoplePickerNavigationControllerDelegate : NSObject<ABPeoplePickerNavigationControllerDelegate, UINavigationControllerDelegate> {
}
	-(id) init;
@end

@interface ABPersonViewControllerDelegate : NSObject<ABPersonViewControllerDelegate> {
}
	-(id) init;
@end

@interface ABUnknownPersonViewControllerDelegate : NSObject<ABUnknownPersonViewControllerDelegate> {
}
	-(id) init;
@end

@interface SKPhysicsContactDelegate : NSObject<SKPhysicsContactDelegate> {
}
	-(id) init;
@end

@interface SKSceneDelegate : NSObject<SKSceneDelegate> {
}
	-(id) init;
@end

@interface SKViewDelegate : NSObject<SKViewDelegate> {
}
	-(id) init;
@end

@interface SCNAnimatable : NSObject<SCNAnimatable> {
}
	-(id) init;
@end

@interface SCNSceneRenderer : NSObject<SCNSceneRenderer> {
}
	-(id) init;
@end

@interface SCNActionable : NSObject<SCNActionable> {
}
	-(id) init;
@end

@interface SCNAvoidOccluderConstraintDelegate : NSObject<SCNAvoidOccluderConstraintDelegate> {
}
	-(id) init;
@end

@interface SCNBoundingVolume : NSObject<SCNBoundingVolume> {
}
	-(id) init;
@end

@interface SCNCameraControllerDelegate : NSObject<SCNCameraControllerDelegate> {
}
	-(id) init;
@end

@interface SCNNodeRendererDelegate : NSObject<SCNNodeRendererDelegate> {
}
	-(id) init;
@end

@interface SCNPhysicsContactDelegate : NSObject<SCNPhysicsContactDelegate> {
}
	-(id) init;
@end

@interface SCNProgramDelegate : NSObject<SCNProgramDelegate> {
}
	-(id) init;
@end

@interface SCNSceneExportDelegate : NSObject<SCNSceneExportDelegate> {
}
	-(id) init;
@end

@interface SCNSceneRendererDelegate : NSObject<SCNSceneRendererDelegate> {
}
	-(id) init;
@end

@interface SCNShadable : NSObject<SCNShadable> {
}
	-(id) init;
@end

@interface SCNTechniqueSupport : NSObject<SCNTechniqueSupport> {
}
	-(id) init;
@end

@interface GKLocalPlayerListener : NSObject<GKLocalPlayerListener> {
}
	-(id) init;
@end

@interface GKSessionDelegate : NSObject<GKSessionDelegate> {
}
	-(id) init;
@end

@interface GKAchievementViewControllerDelegate : NSObject<GKAchievementViewControllerDelegate> {
}
	-(id) init;
@end

@interface GKChallengeEventHandlerDelegate : NSObject<GKChallengeEventHandlerDelegate> {
}
	-(id) init;
@end

@interface GKChallengeListener : NSObject<GKChallengeListener> {
}
	-(id) init;
@end

@interface GKFriendRequestComposeViewControllerDelegate : NSObject<GKFriendRequestComposeViewControllerDelegate> {
}
	-(id) init;
@end

@interface GKGameCenterControllerDelegate : NSObject<GKGameCenterControllerDelegate> {
}
	-(id) init;
@end

@interface GKInviteEventListener : NSObject<GKInviteEventListener> {
}
	-(id) init;
@end

@interface GKLeaderboardViewControllerDelegate : NSObject<GKLeaderboardViewControllerDelegate> {
}
	-(id) init;
@end

@interface GKMatchDelegate : NSObject<GKMatchDelegate> {
}
	-(id) init;
@end

@interface GKMatchmakerViewControllerDelegate : NSObject<GKMatchmakerViewControllerDelegate> {
}
	-(id) init;
@end

@interface GKPeerPickerControllerDelegate : NSObject<GKPeerPickerControllerDelegate> {
}
	-(id) init;
@end

@interface GKSavedGameListener : NSObject<GKSavedGameListener> {
}
	-(id) init;
@end

@interface GKTurnBasedEventHandlerDelegate : NSObject<GKTurnBasedEventHandlerDelegate> {
}
	-(id) init;
@end

@interface GKTurnBasedEventListener : NSObject<GKTurnBasedEventListener> {
}
	-(id) init;
@end

@interface GKTurnBasedMatchmakerViewControllerDelegate : NSObject<GKTurnBasedMatchmakerViewControllerDelegate> {
}
	-(id) init;
@end

@interface GKVoiceChatClient : NSObject<GKVoiceChatClient> {
}
	-(id) init;
@end

@interface WKNavigationDelegate : NSObject<WKNavigationDelegate> {
}
	-(id) init;
@end

@interface WKScriptMessageHandler : NSObject<WKScriptMessageHandler> {
}
	-(id) init;
@end

@interface WKUIDelegate : NSObject<WKUIDelegate> {
}
	-(id) init;
@end

@interface UIAdaptivePresentationControllerDelegate : NSObject<UIAdaptivePresentationControllerDelegate> {
}
	-(id) init;
@end

@interface UIPopoverPresentationControllerDelegate : NSObject<UIPopoverPresentationControllerDelegate, UIAdaptivePresentationControllerDelegate> {
}
	-(id) init;
@end

@interface NSLayoutManagerDelegate : NSObject<NSLayoutManagerDelegate> {
}
	-(id) init;
@end

@interface NSTextAttachmentContainer : NSObject<NSTextAttachmentContainer> {
}
	-(id) init;
@end

@interface NSTextStorageDelegate : NSObject<NSTextStorageDelegate> {
}
	-(id) init;
@end

@interface UIAccelerometerDelegate : NSObject<UIAccelerometerDelegate> {
}
	-(id) init;
@end

@protocol UIAccessibilityContainer
@end

@interface UIAccessibilityContainerDataTable : NSObject<UIAccessibilityContainerDataTable> {
}
	-(id) init;
@end

@interface UIActionSheetDelegate : NSObject<UIActionSheetDelegate> {
}
	-(id) init;
@end

@interface UIActivityItemSource : NSObject<UIActivityItemSource> {
}
	-(id) init;
@end

@interface UIAlertViewDelegate : NSObject<UIAlertViewDelegate> {
}
	-(id) init;
@end

@interface UIAppearanceContainer : NSObject<UIAppearanceContainer> {
}
	-(id) init;
@end

@interface UIBarPositioning : NSObject<UIBarPositioning> {
}
	-(id) init;
@end

@interface UIBarPositioningDelegate : NSObject<UIBarPositioningDelegate> {
}
	-(id) init;
@end

@interface UICloudSharingControllerDelegate : NSObject<UICloudSharingControllerDelegate> {
}
	-(id) init;
@end

@protocol UICollectionViewSource<UICollectionViewDataSource, UICollectionViewDelegate>
@end

@interface UICollectionViewDataSource : NSObject<UICollectionViewDataSource> {
}
	-(id) init;
@end

@interface UICollectionViewDelegate : NSObject<UICollectionViewDelegate> {
}
	-(id) init;
@end

@interface UICollectionViewDelegateFlowLayout : NSObject<UICollectionViewDelegateFlowLayout, UICollectionViewDelegate> {
}
	-(id) init;
@end

@interface UICollectionViewDragDelegate : NSObject<UICollectionViewDragDelegate> {
}
	-(id) init;
@end

@interface UICollectionViewDropDelegate : NSObject<UICollectionViewDropDelegate> {
}
	-(id) init;
@end

@interface UICollectionViewSource : NSObject<UICollectionViewDataSource, UICollectionViewDelegate> {
}
	-(id) init;
@end

@interface UICollisionBehaviorDelegate : NSObject<UICollisionBehaviorDelegate> {
}
	-(id) init;
@end

@interface UIContentContainer : NSObject<UIContentContainer> {
}
	-(id) init;
@end

@interface UICoordinateSpace : NSObject<UICoordinateSpace> {
}
	-(id) init;
@end

@interface UIDocumentBrowserViewControllerDelegate : NSObject<UIDocumentBrowserViewControllerDelegate> {
}
	-(id) init;
@end

@interface UIDocumentInteractionControllerDelegate : NSObject<UIDocumentInteractionControllerDelegate> {
}
	-(id) init;
@end

@interface UIDocumentMenuDelegate : NSObject<UIDocumentMenuDelegate> {
}
	-(id) init;
@end

@interface UIDocumentPickerDelegate : NSObject<UIDocumentPickerDelegate> {
}
	-(id) init;
@end

@interface UIDragInteractionDelegate : NSObject<UIDragInteractionDelegate> {
}
	-(id) init;
@end

@interface UIDropInteractionDelegate : NSObject<UIDropInteractionDelegate> {
}
	-(id) init;
@end

@interface UIDynamicAnimatorDelegate : NSObject<UIDynamicAnimatorDelegate> {
}
	-(id) init;
@end

@interface UIDynamicItem : NSObject<UIDynamicItem> {
}
	-(id) init;
@end

@interface UIGestureRecognizerDelegate : NSObject<UIGestureRecognizerDelegate> {
}
	-(id) init;
@end

@interface UIImagePickerControllerDelegate : NSObject<UIImagePickerControllerDelegate, UINavigationControllerDelegate> {
}
	-(id) init;
@end

@interface UILayoutSupport : NSObject<UILayoutSupport> {
}
	-(id) init;
@end

@interface UINavigationBarDelegate : NSObject<UINavigationBarDelegate, UIBarPositioningDelegate> {
}
	-(id) init;
@end

@interface UIObjectRestoration : NSObject<UIObjectRestoration> {
}
	-(id) init;
@end

@interface UIPageViewControllerDataSource : NSObject<UIPageViewControllerDataSource> {
}
	-(id) init;
@end

@interface UIPageViewControllerDelegate : NSObject<UIPageViewControllerDelegate> {
}
	-(id) init;
@end

@interface UIPickerViewDelegate : NSObject<UIPickerViewDelegate> {
}
	-(id) init;
@end

@interface UIPickerViewAccessibilityDelegate : NSObject<UIPickerViewAccessibilityDelegate, UIPickerViewDelegate> {
}
	-(id) init;
@end

@interface UIPickerViewDataSource : NSObject<UIPickerViewDataSource> {
}
	-(id) init;
@end

@protocol UIPickerViewModel<UIPickerViewDataSource, UIPickerViewDelegate>
@end

@interface UIPickerViewModel : NSObject<UIPickerViewDataSource, UIPickerViewDelegate> {
}
	-(id) init;
@end

@interface UIPopoverControllerDelegate : NSObject<UIPopoverControllerDelegate> {
}
	-(id) init;
@end

@interface UIPreviewInteractionDelegate : NSObject<UIPreviewInteractionDelegate> {
}
	-(id) init;
@end

@interface UIPrinterPickerControllerDelegate : NSObject<UIPrinterPickerControllerDelegate> {
}
	-(id) init;
@end

@interface UIPrintInteractionControllerDelegate : NSObject<UIPrintInteractionControllerDelegate> {
}
	-(id) init;
@end

@interface UIScrollViewAccessibilityDelegate : NSObject<UIScrollViewAccessibilityDelegate, UIScrollViewDelegate> {
}
	-(id) init;
@end

@interface UISearchBarDelegate : NSObject<UISearchBarDelegate, UIBarPositioningDelegate> {
}
	-(id) init;
@end

@interface UISearchControllerDelegate : NSObject<UISearchControllerDelegate> {
}
	-(id) init;
@end

@interface UISearchDisplayDelegate : NSObject<UISearchDisplayDelegate> {
}
	-(id) init;
@end

@interface UISearchResultsUpdating : NSObject<UISearchResultsUpdating> {
}
	-(id) init;
@end

@interface UISplitViewControllerDelegate : NSObject<UISplitViewControllerDelegate> {
}
	-(id) init;
@end

@interface UIStateRestoring : NSObject<UIStateRestoring> {
}
	-(id) init;
@end

@interface UITabBarControllerDelegate : NSObject<UITabBarControllerDelegate> {
}
	-(id) init;
@end

@interface UITabBarDelegate : NSObject<UITabBarDelegate> {
}
	-(id) init;
@end

@interface Xamarin_iOS__UIKit_UITableViewDataSource : NSObject<UITableViewDataSource> {
}
	-(id) init;
@end

@interface UITableViewDelegate : NSObject<UITableViewDelegate, UIScrollViewDelegate> {
}
	-(id) init;
@end

@interface UITableViewDragDelegate : NSObject<UITableViewDragDelegate> {
}
	-(id) init;
@end

@interface UITableViewDropDelegate : NSObject<UITableViewDropDelegate> {
}
	-(id) init;
@end

@interface UITextDocumentProxy : NSObject<UITextDocumentProxy> {
}
	-(id) init;
@end

@interface UITextDragDelegate : NSObject<UITextDragDelegate> {
}
	-(id) init;
@end

@interface UITextDropDelegate : NSObject<UITextDropDelegate> {
}
	-(id) init;
@end

@interface UITextFieldDelegate : NSObject<UITextFieldDelegate> {
}
	-(id) init;
@end

@interface UITextInputDelegate : NSObject<UITextInputDelegate> {
}
	-(id) init;
@end

@interface UITextInputTokenizer : NSObject<UITextInputTokenizer> {
}
	-(id) init;
@end

@interface UITextPasteDelegate : NSObject<UITextPasteDelegate> {
}
	-(id) init;
@end

@interface UITextViewDelegate : NSObject<UITextViewDelegate, UIScrollViewDelegate> {
}
	-(id) init;
@end

@interface UIToolbarDelegate : NSObject<UIToolbarDelegate, UIBarPositioningDelegate> {
}
	-(id) init;
@end

@interface UITraitEnvironment : NSObject<UITraitEnvironment> {
}
	-(id) init;
@end

@interface UIVideoEditorControllerDelegate : NSObject<UIVideoEditorControllerDelegate, UINavigationControllerDelegate> {
}
	-(id) init;
@end

@interface UIViewControllerAnimatedTransitioning : NSObject<UIViewControllerAnimatedTransitioning> {
}
	-(id) init;
@end

@interface UIViewControllerContextTransitioning : NSObject<UIViewControllerContextTransitioning> {
}
	-(id) init;
@end

@interface UIViewControllerInteractiveTransitioning : NSObject<UIViewControllerInteractiveTransitioning> {
}
	-(id) init;
@end

@interface UIViewControllerPreviewingDelegate : NSObject<UIViewControllerPreviewingDelegate> {
}
	-(id) init;
@end

@interface UIViewControllerTransitioningDelegate : NSObject<UIViewControllerTransitioningDelegate> {
}
	-(id) init;
@end

@interface UIWebViewDelegate : NSObject<UIWebViewDelegate> {
}
	-(id) init;
@end

@interface NSFileManagerDelegate : NSObject<NSFileManagerDelegate> {
}
	-(id) init;
@end

@interface NSCacheDelegate : NSObject<NSCacheDelegate> {
}
	-(id) init;
@end

@interface NSCoding : NSObject<NSCoding> {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface NSCopying : NSObject<NSCopying> {
}
	-(id) init;
@end

@interface NSExtensionRequestHandling : NSObject<NSExtensionRequestHandling> {
}
	-(id) init;
@end

@interface NSFilePresenter : NSObject<NSFilePresenter> {
}
	-(id) init;
@end

@interface NSKeyedArchiverDelegate : NSObject<NSKeyedArchiverDelegate> {
}
	-(id) init;
@end

@interface NSKeyedUnarchiverDelegate : NSObject<NSKeyedUnarchiverDelegate> {
}
	-(id) init;
@end

@interface NSPortDelegate : NSObject<NSPortDelegate> {
}
	-(id) init;
@end

@interface NSMachPortDelegate : NSObject<NSMachPortDelegate, NSPortDelegate> {
}
	-(id) init;
@end

@interface NSMetadataQueryDelegate : NSObject<NSMetadataQueryDelegate> {
}
	-(id) init;
@end

@interface NSMutableCopying : NSObject<NSMutableCopying> {
}
	-(id) init;
@end

@interface NSNetServiceBrowserDelegate : NSObject<NSNetServiceBrowserDelegate> {
}
	-(id) init;
@end

@interface NSNetServiceDelegate : NSObject<NSNetServiceDelegate> {
}
	-(id) init;
@end

@interface NSStreamDelegate : NSObject<NSStreamDelegate> {
}
	-(id) init;
@end

@interface NSURLAuthenticationChallengeSender : NSObject<NSURLAuthenticationChallengeSender> {
}
	-(id) init;
@end

@interface NSURLConnectionDelegate : NSObject<NSURLConnectionDelegate> {
}
	-(id) init;
@end

@interface NSURLConnectionDataDelegate : NSObject<NSURLConnectionDataDelegate, NSURLConnectionDelegate> {
}
	-(id) init;
@end

@interface NSURLConnectionDownloadDelegate : NSObject<NSURLConnectionDownloadDelegate, NSURLConnectionDelegate> {
}
	-(id) init;
@end

@interface NSURLSessionDelegate : NSObject<NSURLSessionDelegate> {
}
	-(id) init;
@end

@interface NSURLSessionTaskDelegate : NSObject<NSURLSessionTaskDelegate, NSURLSessionDelegate> {
}
	-(id) init;
@end

@interface NSURLSessionDataDelegate : NSObject<NSURLSessionDataDelegate, NSURLSessionTaskDelegate, NSURLSessionDelegate> {
}
	-(id) init;
@end

@interface NSURLSessionDownloadDelegate : NSObject<NSURLSessionDownloadDelegate, NSURLSessionTaskDelegate, NSURLSessionDelegate> {
}
	-(id) init;
@end

@interface NSURLSessionStreamDelegate : NSObject<NSURLSessionStreamDelegate, NSURLSessionTaskDelegate, NSURLSessionDelegate> {
}
	-(id) init;
@end

@interface NSUserActivityDelegate : NSObject<NSUserActivityDelegate> {
}
	-(id) init;
@end

@interface CBCentralManagerDelegate : NSObject<CBCentralManagerDelegate> {
}
	-(id) init;
@end

@interface CBPeripheralDelegate : NSObject<CBPeripheralDelegate> {
}
	-(id) init;
@end

@interface CBPeripheralManagerDelegate : NSObject<CBPeripheralManagerDelegate> {
}
	-(id) init;
@end

@interface AVPictureInPictureControllerDelegate : NSObject<AVPictureInPictureControllerDelegate> {
}
	-(id) init;
@end

@interface AVPlayerViewControllerDelegate : NSObject<AVPlayerViewControllerDelegate> {
}
	-(id) init;
@end

@interface AVRoutePickerViewDelegate : NSObject<AVRoutePickerViewDelegate> {
}
	-(id) init;
@end

@interface AVCaptureAudioDataOutputSampleBufferDelegate : NSObject<AVCaptureAudioDataOutputSampleBufferDelegate> {
}
	-(id) init;
@end

@interface AVAudioPlayerDelegate : NSObject<AVAudioPlayerDelegate> {
}
	-(id) init;
@end

@interface AVAudioRecorderDelegate : NSObject<AVAudioRecorderDelegate> {
}
	-(id) init;
@end

@interface AVAudioSessionDelegate : NSObject<AVAudioSessionDelegate> {
}
	-(id) init;
@end

@interface AVAssetDownloadDelegate : NSObject<AVAssetDownloadDelegate> {
}
	-(id) init;
@end

@interface AVAssetResourceLoaderDelegate : NSObject<AVAssetResourceLoaderDelegate> {
}
	-(id) init;
@end

@interface AVAsynchronousKeyValueLoading : NSObject<AVAsynchronousKeyValueLoading> {
}
	-(id) init;
@end

@interface AVAudio3DMixing : NSObject<AVAudio3DMixing> {
}
	-(id) init;
@end

@interface AVAudioStereoMixing : NSObject<AVAudioStereoMixing> {
}
	-(id) init;
@end

@interface AVCaptureDataOutputSynchronizerDelegate : NSObject<AVCaptureDataOutputSynchronizerDelegate> {
}
	-(id) init;
@end

@interface AVCaptureDepthDataOutputDelegate : NSObject<AVCaptureDepthDataOutputDelegate> {
}
	-(id) init;
@end

@interface AVCaptureFileOutputRecordingDelegate : NSObject<AVCaptureFileOutputRecordingDelegate> {
}
	-(id) init;
@end

@interface AVCaptureMetadataOutputObjectsDelegate : NSObject<AVCaptureMetadataOutputObjectsDelegate> {
}
	-(id) init;
@end

@interface AVCapturePhotoCaptureDelegate : NSObject<AVCapturePhotoCaptureDelegate> {
}
	-(id) init;
@end

@interface AVCaptureVideoDataOutputSampleBufferDelegate : NSObject<AVCaptureVideoDataOutputSampleBufferDelegate> {
}
	-(id) init;
@end

@interface AVContentKeySessionDelegate : NSObject<AVContentKeySessionDelegate> {
}
	-(id) init;
@end

@interface AVPlayerItemOutputPushDelegate : NSObject<AVPlayerItemOutputPushDelegate> {
}
	-(id) init;
@end

@interface AVPlayerItemLegibleOutputPushDelegate : NSObject<AVPlayerItemLegibleOutputPushDelegate, AVPlayerItemOutputPushDelegate> {
}
	-(id) init;
@end

@interface AVPlayerItemMetadataCollectorPushDelegate : NSObject<AVPlayerItemMetadataCollectorPushDelegate> {
}
	-(id) init;
@end

@interface AVPlayerItemMetadataOutputPushDelegate : NSObject<AVPlayerItemMetadataOutputPushDelegate> {
}
	-(id) init;
@end

@interface AVPlayerItemOutputPullDelegate : NSObject<AVPlayerItemOutputPullDelegate> {
}
	-(id) init;
@end

@interface AVSpeechSynthesizerDelegate : NSObject<AVSpeechSynthesizerDelegate> {
}
	-(id) init;
@end

@interface AVVideoCompositing : NSObject<AVVideoCompositing> {
}
	-(id) init;
@end

@interface AppDelegate : NSObject<UIApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIWindow *) window;
	-(void) setWindow:(UIWindow *)p0;
	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1;
	-(void) applicationWillResignActive:(UIApplication *)p0;
	-(void) applicationDidEnterBackground:(UIApplication *)p0;
	-(void) applicationWillEnterForeground:(UIApplication *)p0;
	-(void) applicationDidBecomeActive:(UIApplication *)p0;
	-(void) applicationWillTerminate:(UIApplication *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface checkResultViewController : UIViewController {
}
	@property (nonatomic, assign) UITextField * categoryTextField;
	@property (nonatomic, assign) UITableView * checkResultTableView;
	@property (nonatomic, assign) UIView * checkResultView;
	@property (nonatomic, assign) UIButton * commitButton;
	@property (nonatomic, assign) UITextField * dateTextField;
	@property (nonatomic, assign) UITextField * distanceTextField;
	@property (nonatomic, assign) UITextField * handicapBufTextField;
	@property (nonatomic, assign) UITextField * handicapDetTextField;
	@property (nonatomic, assign) UITextField * handicapFacTextField;
	@property (nonatomic, assign) UITextField * locationTextField;
	@property (nonatomic, assign) UITextField * numLegsTextField;
	@property (nonatomic, assign) UITextField * relayTextField;
	@property (nonatomic, assign) UITextField * surfaceTypeTextField;
	@property (nonatomic, assign) UITextField * unitTextField;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UITextField *) categoryTextField;
	-(void) setCategoryTextField:(UITextField *)p0;
	-(UITableView *) checkResultTableView;
	-(void) setCheckResultTableView:(UITableView *)p0;
	-(UIView *) checkResultView;
	-(void) setCheckResultView:(UIView *)p0;
	-(UIButton *) commitButton;
	-(void) setCommitButton:(UIButton *)p0;
	-(UITextField *) dateTextField;
	-(void) setDateTextField:(UITextField *)p0;
	-(UITextField *) distanceTextField;
	-(void) setDistanceTextField:(UITextField *)p0;
	-(UITextField *) handicapBufTextField;
	-(void) setHandicapBufTextField:(UITextField *)p0;
	-(UITextField *) handicapDetTextField;
	-(void) setHandicapDetTextField:(UITextField *)p0;
	-(UITextField *) handicapFacTextField;
	-(void) setHandicapFacTextField:(UITextField *)p0;
	-(UITextField *) locationTextField;
	-(void) setLocationTextField:(UITextField *)p0;
	-(UITextField *) numLegsTextField;
	-(void) setNumLegsTextField:(UITextField *)p0;
	-(UITextField *) relayTextField;
	-(void) setRelayTextField:(UITextField *)p0;
	-(UITextField *) surfaceTypeTextField;
	-(void) setSurfaceTypeTextField:(UITextField *)p0;
	-(UITextField *) unitTextField;
	-(void) setUnitTextField:(UITextField *)p0;
	-(void) viewDidLoad;
	-(void) CommitButton_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface contactController : UIViewController {
}
	@property (nonatomic, assign) UIButton * contactEditButton;
	@property (nonatomic, assign) UISearchBar * contactSearchBar;
	@property (nonatomic, assign) UITableView * contactsTableView;
	@property (nonatomic, assign) UITextField * contactVAddress;
	@property (nonatomic, assign) UITextField * contactVANSWNumber;
	@property (nonatomic, assign) UITextField * contactVAsterID;
	@property (nonatomic, assign) UITextField * contactVBirthday;
	@property (nonatomic, assign) UITextField * contactVCity;
	@property (nonatomic, assign) UITextField * contactVClubName;
	@property (nonatomic, assign) UITextField * contactVCountry;
	@property (nonatomic, assign) UITextField * contactVDietaryCondition;
	@property (nonatomic, assign) UITextField * contactVEContact;
	@property (nonatomic, assign) UITextField * contactVEContactNum;
	@property (nonatomic, assign) UITextField * contactVEmail;
	@property (nonatomic, assign) UITextField * contactVFirst;
	@property (nonatomic, assign) UITextField * contactVFirstAid;
	@property (nonatomic, assign) UITextField * contactVGender;
	@property (nonatomic, assign) UITextField * contactVID;
	@property (nonatomic, assign) UIView * contactView;
	@property (nonatomic, assign) UITextField * contactVLast;
	@property (nonatomic, assign) UITextField * contactVLifeMember;
	@property (nonatomic, assign) UITextField * contactVMarshallID;
	@property (nonatomic, assign) UITextField * contactVMedicalCondition;
	@property (nonatomic, assign) UITextField * contactVMemberID;
	@property (nonatomic, assign) UITextField * contactVPost;
	@property (nonatomic, assign) UISearchDisplayController * searchDisplayController;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) contactEditButton;
	-(void) setContactEditButton:(UIButton *)p0;
	-(UISearchBar *) contactSearchBar;
	-(void) setContactSearchBar:(UISearchBar *)p0;
	-(UITableView *) contactsTableView;
	-(void) setContactsTableView:(UITableView *)p0;
	-(UITextField *) contactVAddress;
	-(void) setContactVAddress:(UITextField *)p0;
	-(UITextField *) contactVANSWNumber;
	-(void) setContactVANSWNumber:(UITextField *)p0;
	-(UITextField *) contactVAsterID;
	-(void) setContactVAsterID:(UITextField *)p0;
	-(UITextField *) contactVBirthday;
	-(void) setContactVBirthday:(UITextField *)p0;
	-(UITextField *) contactVCity;
	-(void) setContactVCity:(UITextField *)p0;
	-(UITextField *) contactVClubName;
	-(void) setContactVClubName:(UITextField *)p0;
	-(UITextField *) contactVCountry;
	-(void) setContactVCountry:(UITextField *)p0;
	-(UITextField *) contactVDietaryCondition;
	-(void) setContactVDietaryCondition:(UITextField *)p0;
	-(UITextField *) contactVEContact;
	-(void) setContactVEContact:(UITextField *)p0;
	-(UITextField *) contactVEContactNum;
	-(void) setContactVEContactNum:(UITextField *)p0;
	-(UITextField *) contactVEmail;
	-(void) setContactVEmail:(UITextField *)p0;
	-(UITextField *) contactVFirst;
	-(void) setContactVFirst:(UITextField *)p0;
	-(UITextField *) contactVFirstAid;
	-(void) setContactVFirstAid:(UITextField *)p0;
	-(UITextField *) contactVGender;
	-(void) setContactVGender:(UITextField *)p0;
	-(UITextField *) contactVID;
	-(void) setContactVID:(UITextField *)p0;
	-(UIView *) contactView;
	-(void) setContactView:(UIView *)p0;
	-(UITextField *) contactVLast;
	-(void) setContactVLast:(UITextField *)p0;
	-(UITextField *) contactVLifeMember;
	-(void) setContactVLifeMember:(UITextField *)p0;
	-(UITextField *) contactVMarshallID;
	-(void) setContactVMarshallID:(UITextField *)p0;
	-(UITextField *) contactVMedicalCondition;
	-(void) setContactVMedicalCondition:(UITextField *)p0;
	-(UITextField *) contactVMemberID;
	-(void) setContactVMemberID:(UITextField *)p0;
	-(UITextField *) contactVPost;
	-(void) setContactVPost:(UITextField *)p0;
	-(UISearchDisplayController *) searchDisplayController;
	-(void) setSearchDisplayController:(UISearchDisplayController *)p0;
	-(void) viewDidLayoutSubviews;
	-(void) viewDidLoad;
	-(void) ContactEditButton_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface filterParticipationViewController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface filterRaceViewController : UIViewController {
}
	@property (nonatomic, assign) UITextField * filterCourseTextField;
	@property (nonatomic, assign) UITextField * filterDateTextField;
	@property (nonatomic, assign) UITextField * filterLocationTextField;
	@property (nonatomic, assign) UIView * filterRaceController;
	@property (nonatomic, assign) UITableView * filterRaceTableView;
	@property (nonatomic, assign) UILabel * testlabel;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UITextField *) filterCourseTextField;
	-(void) setFilterCourseTextField:(UITextField *)p0;
	-(UITextField *) filterDateTextField;
	-(void) setFilterDateTextField:(UITextField *)p0;
	-(UITextField *) filterLocationTextField;
	-(void) setFilterLocationTextField:(UITextField *)p0;
	-(UIView *) filterRaceController;
	-(void) setFilterRaceController:(UIView *)p0;
	-(UITableView *) filterRaceTableView;
	-(void) setFilterRaceTableView:(UITableView *)p0;
	-(UILabel *) testlabel;
	-(void) setTestlabel:(UILabel *)p0;
	-(void) viewDidLoad;
	-(void) DoneAction;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface menuViewController : UIViewController {
}
	@property (nonatomic, assign) UIImageView * menuBackgroundImage;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIImageView *) menuBackgroundImage;
	-(void) setMenuBackgroundImage:(UIImageView *)p0;
	-(void) viewDidLoad;
	-(void) UIButton2250_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface RaceResultViewController : UIViewController {
}
	@property (nonatomic, assign) UITableView * RaceResultsTableView;
	@property (nonatomic, assign) UIView * RaceResultView;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UITableView *) RaceResultsTableView;
	-(void) setRaceResultsTableView:(UITableView *)p0;
	-(UIView *) RaceResultView;
	-(void) setRaceResultView:(UIView *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface RaceResultsCell : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * dateLabel;
	@property (nonatomic, assign) UILabel * memberIDLabel;
	@property (nonatomic, assign) UILabel * nameLabel;
	@property (nonatomic, assign) UILabel * positionLabel;
	@property (nonatomic, assign) UILabel * timeLabel;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) dateLabel;
	-(void) setDateLabel:(UILabel *)p0;
	-(UILabel *) memberIDLabel;
	-(void) setMemberIDLabel:(UILabel *)p0;
	-(UILabel *) nameLabel;
	-(void) setNameLabel:(UILabel *)p0;
	-(UILabel *) positionLabel;
	-(void) setPositionLabel:(UILabel *)p0;
	-(UILabel *) timeLabel;
	-(void) setTimeLabel:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface reportController : UIViewController {
}
	@property (nonatomic, assign) UIImageView * reportBackgroundImage;
	@property (nonatomic, assign) UIView * scrollView;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIImageView *) reportBackgroundImage;
	-(void) setReportBackgroundImage:(UIImageView *)p0;
	-(UIView *) scrollView;
	-(void) setScrollView:(UIView *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface settingController : UIViewController {
}
	@property (nonatomic, assign) UIImageView * settingBackgroundImage;
	@property (nonatomic, assign) UIView * settingView;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIImageView *) settingBackgroundImage;
	-(void) setSettingBackgroundImage:(UIImageView *)p0;
	-(UIView *) settingView;
	-(void) setSettingView:(UIView *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ViewController : UIViewController {
}
	@property (nonatomic, assign) UIImageView * backgroundImage;
	@property (nonatomic, assign) UIImageView * kemblaLogo;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIImageView *) backgroundImage;
	-(void) setBackgroundImage:(UIImageView *)p0;
	-(UIImageView *) kemblaLogo;
	-(void) setKemblaLogo:(UIImageView *)p0;
	-(void) viewDidLoad;
	-(void) didReceiveMemoryWarning;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface viewRaceRecordViewController : UIViewController {
}
	@property (nonatomic, assign) UILabel * courseLabel;
	@property (nonatomic, assign) UILabel * locationLabel;
	@property (nonatomic, assign) UITableView * RaceRecordTableView;
	@property (nonatomic, assign) UIView * viewRaceRecordView;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) courseLabel;
	-(void) setCourseLabel:(UILabel *)p0;
	-(UILabel *) locationLabel;
	-(void) setLocationLabel:(UILabel *)p0;
	-(UITableView *) RaceRecordTableView;
	-(void) setRaceRecordTableView:(UITableView *)p0;
	-(UIView *) viewRaceRecordView;
	-(void) setViewRaceRecordView:(UIView *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface viewSeriesRecordViewController : UIViewController {
}
	@property (nonatomic, assign) UILabel * seriesLabel;
	@property (nonatomic, assign) UITableView * seriesRecordTableView;
	@property (nonatomic, assign) UIView * viewSeriesRecordView;
	@property (nonatomic, assign) UILabel * yearLabel;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) seriesLabel;
	-(void) setSeriesLabel:(UILabel *)p0;
	-(UITableView *) seriesRecordTableView;
	-(void) setSeriesRecordTableView:(UITableView *)p0;
	-(UIView *) viewSeriesRecordView;
	-(void) setViewSeriesRecordView:(UIView *)p0;
	-(UILabel *) yearLabel;
	-(void) setYearLabel:(UILabel *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface handicapViewController : UIViewController {
}
	@property (nonatomic, assign) UITableView * handicapDateTableView;
	@property (nonatomic, assign) UITableView * handicapTimeTableView;
	@property (nonatomic, assign) UIView * handicapView;
	@property (nonatomic, assign) UISearchDisplayController * searchDisplayController;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UITableView *) handicapDateTableView;
	-(void) setHandicapDateTableView:(UITableView *)p0;
	-(UITableView *) handicapTimeTableView;
	-(void) setHandicapTimeTableView:(UITableView *)p0;
	-(UIView *) handicapView;
	-(void) setHandicapView:(UIView *)p0;
	-(UISearchDisplayController *) searchDisplayController;
	-(void) setSearchDisplayController:(UISearchDisplayController *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface KemblaJoggers_TableSource : NSObject<UIScrollViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface timeEventViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * lapButton;
	@property (nonatomic, assign) UITableView * lapTimings;
	@property (nonatomic, assign) UIButton * startButton;
	@property (nonatomic, assign) UILabel * timerLabel;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) lapButton;
	-(void) setLapButton:(UIButton *)p0;
	-(UITableView *) lapTimings;
	-(void) setLapTimings:(UITableView *)p0;
	-(UIButton *) startButton;
	-(void) setStartButton:(UIButton *)p0;
	-(UILabel *) timerLabel;
	-(void) setTimerLabel:(UILabel *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ParticipationViewController : UIViewController {
}
	@property (nonatomic, assign) UITableView * participationTableView;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UITableView *) participationTableView;
	-(void) setParticipationTableView:(UITableView *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface addNewRecordViewController : UIViewController {
}
	@property (nonatomic, assign) UIView * leftView;
	@property (nonatomic, assign) UIView * rightView;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIView *) leftView;
	-(void) setLeftView:(UIView *)p0;
	-(UIView *) rightView;
	-(void) setRightView:(UIView *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface CheckResultCell : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * nameLabel;
	@property (nonatomic, assign) UILabel * positionLabel;
	@property (nonatomic, assign) UILabel * timeLabel;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) nameLabel;
	-(void) setNameLabel:(UILabel *)p0;
	-(UILabel *) positionLabel;
	-(void) setPositionLabel:(UILabel *)p0;
	-(UILabel *) timeLabel;
	-(void) setTimeLabel:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface KemblaJoggers_checkResultDataSource : NSObject<UIScrollViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface KemblaJoggers_filterRaceDataSource : NSObject<UIScrollViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(void) tableView:(UITableView *)p0 didSelectRowAtIndexPath:(NSIndexPath *)p1;
	-(void) tableView:(UITableView *)p0 didDeselectRowAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface HandicapCell : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * handicapTimeLabel;
	@property (nonatomic, assign) UILabel * memberLabel;
	@property (nonatomic, assign) UILabel * nameLabel;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) handicapTimeLabel;
	-(void) setHandicapTimeLabel:(UILabel *)p0;
	-(UILabel *) memberLabel;
	-(void) setMemberLabel:(UILabel *)p0;
	-(UILabel *) nameLabel;
	-(void) setNameLabel:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface LapCell : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * positionLabel;
	@property (nonatomic, assign) UILabel * timeLabel;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) positionLabel;
	-(void) setPositionLabel:(UILabel *)p0;
	-(UILabel *) timeLabel;
	-(void) setTimeLabel:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface KemblaJoggers_LapDataSource : NSObject<UIScrollViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ParticipationCell : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * ageGroupLabel;
	@property (nonatomic, assign) UILabel * nameLabel;
	@property (nonatomic, assign) UILabel * raceCountLabel;
	@property (nonatomic, assign) UILabel * slopeLabel;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) ageGroupLabel;
	-(void) setAgeGroupLabel:(UILabel *)p0;
	-(UILabel *) nameLabel;
	-(void) setNameLabel:(UILabel *)p0;
	-(UILabel *) raceCountLabel;
	-(void) setRaceCountLabel:(UILabel *)p0;
	-(UILabel *) slopeLabel;
	-(void) setSlopeLabel:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface KemblaJoggers_ParticipationDataSource : NSObject<UIScrollViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface RaceRecordCell : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * ageGroupLabel;
	@property (nonatomic, assign) UILabel * dateLabel;
	@property (nonatomic, assign) UILabel * nameLabel;
	@property (nonatomic, assign) UILabel * positionLabel;
	@property (nonatomic, assign) UILabel * timeLabel;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) ageGroupLabel;
	-(void) setAgeGroupLabel:(UILabel *)p0;
	-(UILabel *) dateLabel;
	-(void) setDateLabel:(UILabel *)p0;
	-(UILabel *) nameLabel;
	-(void) setNameLabel:(UILabel *)p0;
	-(UILabel *) positionLabel;
	-(void) setPositionLabel:(UILabel *)p0;
	-(UILabel *) timeLabel;
	-(void) setTimeLabel:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface KemblaJoggers_RaceRecordsDataSource : NSObject<UIScrollViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface SeriesRecordCell : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * ageGroupLabel;
	@property (nonatomic, assign) UILabel * dateLabel;
	@property (nonatomic, assign) UILabel * nameLabel;
	@property (nonatomic, assign) UILabel * positionLabel;
	@property (nonatomic, assign) UILabel * timeLabel;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) ageGroupLabel;
	-(void) setAgeGroupLabel:(UILabel *)p0;
	-(UILabel *) dateLabel;
	-(void) setDateLabel:(UILabel *)p0;
	-(UILabel *) nameLabel;
	-(void) setNameLabel:(UILabel *)p0;
	-(UILabel *) positionLabel;
	-(void) setPositionLabel:(UILabel *)p0;
	-(UILabel *) timeLabel;
	-(void) setTimeLabel:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface KemblaJoggers_SeriesRecordDataSource : NSObject<UIScrollViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface eventViewController : UIViewController {
}
	@property (nonatomic, assign) UIImageView * eventBackgroundImage;
	@property (nonatomic, assign) UIView * eventView;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIImageView *) eventBackgroundImage;
	-(void) setEventBackgroundImage:(UIImageView *)p0;
	-(UIView *) eventView;
	-(void) setEventView:(UIView *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface courseManagementViewController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface pointScoresViewController : UIViewController {
}
	@property (nonatomic, assign) UIView * leftView;
	@property (nonatomic, assign) UIView * rightView;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIView *) leftView;
	-(void) setLeftView:(UIView *)p0;
	-(UIView *) rightView;
	-(void) setRightView:(UIView *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface loginController : UIViewController {
}
	@property (nonatomic, assign) UIImageView * kemblaLogo;
	@property (nonatomic, assign) UIImageView * loginBackgroundImage;
	@property (nonatomic, assign) UIButton * loginButton;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIImageView *) kemblaLogo;
	-(void) setKemblaLogo:(UIImageView *)p0;
	-(UIImageView *) loginBackgroundImage;
	-(void) setLoginBackgroundImage:(UIImageView *)p0;
	-(UIButton *) loginButton;
	-(void) setLoginButton:(UIButton *)p0;
	-(void) viewDidLoad;
	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1;
	-(void) didReceiveMemoryWarning;
	-(void) LoginButton_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface KemblaJoggers_ContactDataSource : NSObject<UIScrollViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSArray *) sectionIndexTitlesForTableView:(UITableView *)p0;
	-(NSString *) tableView:(UITableView *)p0 titleForHeaderInSection:(NSInteger)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(void) tableView:(UITableView *)p0 didSelectRowAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface KemblaJoggers_HandicapDataSource : NSObject<UIScrollViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface chooseLocationViewController : UIViewController {
}
	@property (nonatomic, assign) UITextField * addressTextField;
	@property (nonatomic, assign) UIImageView * locationImage;
	@property (nonatomic, assign) MKMapView * locationMap;
	@property (nonatomic, assign) UIButton * setLocationButton;
	@property (nonatomic, assign) UIButton * zoomToUserButton;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UITextField *) addressTextField;
	-(void) setAddressTextField:(UITextField *)p0;
	-(UIImageView *) locationImage;
	-(void) setLocationImage:(UIImageView *)p0;
	-(MKMapView *) locationMap;
	-(void) setLocationMap:(MKMapView *)p0;
	-(UIButton *) setLocationButton;
	-(void) setSetLocationButton:(UIButton *)p0;
	-(UIButton *) zoomToUserButton;
	-(void) setZoomToUserButton:(UIButton *)p0;
	-(void) viewDidLoad;
	-(void) didReceiveMemoryWarning;
	-(void) SetLocationButton_TouchUpInside:(UIButton *)p0;
	-(void) ZoomToUserButton_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface selectRecordTypeViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * viewRaceRecordButton;
	@property (nonatomic, assign) UIButton * viewSeriesRecordButton;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) viewRaceRecordButton;
	-(void) setViewRaceRecordButton:(UIButton *)p0;
	-(UIButton *) viewSeriesRecordButton;
	-(void) setViewSeriesRecordButton:(UIButton *)p0;
	-(void) viewDidLoad;
	-(void) ViewRaceRecordButton_TouchUpInside:(UIButton *)p0;
	-(void) ViewSeriesRecordButton_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface UIKit_UIView_UIViewAppearance : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIColor *) backgroundColor;
	-(void) setBackgroundColor:(UIColor *)p0;
	-(UIColor *) tintColor;
	-(void) setTintColor:(UIColor *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface Messages_MSStickerBrowserView_MSStickerBrowserViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface Messages_MSStickerView_MSStickerViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface iAd_ADBannerView_ADBannerViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface HealthKitUI_HKActivityRingView_HKActivityRingViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface CoreAudioKit_CAInterAppAudioSwitcherView_CAInterAppAudioSwitcherViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface CoreAudioKit_CAInterAppAudioTransportView_CAInterAppAudioTransportViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface PhotosUI_PHLivePhotoView_PHLivePhotoViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface PdfKit_PdfThumbnailView_PdfThumbnailViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface PdfKit_PdfView_PdfViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UIControl_UIControlAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UIButton_UIButtonAppearance : UIKit_UIControl_UIControlAppearance {
}
	-(UIImage *) backgroundImageForState:(NSUInteger)p0;
	-(UIImage *) currentBackgroundImage;
	-(UIImage *) currentImage;
	-(UIColor *) currentTitleColor;
	-(UIColor *) currentTitleShadowColor;
	-(UIImage *) imageForState:(NSUInteger)p0;
	-(void) setBackgroundImage:(UIImage *)p0 forState:(NSUInteger)p1;
	-(void) setImage:(UIImage *)p0 forState:(NSUInteger)p1;
	-(void) setTitleColor:(UIColor *)p0 forState:(NSUInteger)p1;
	-(void) setTitleShadowColor:(UIColor *)p0 forState:(NSUInteger)p1;
	-(UIColor *) titleColorForState:(NSUInteger)p0;
	-(UIColor *) titleShadowColorForState:(NSUInteger)p0;
@end

@interface PassKit_PKAddPassButton_PKAddPassButtonAppearance : UIKit_UIButton_UIButtonAppearance {
}
	-(NSInteger) addPassButtonStyle;
	-(void) setAddPassButtonStyle:(NSInteger)p0;
@end

@interface PassKit_PKPaymentButton_PKPaymentButtonAppearance : UIKit_UIButton_UIButtonAppearance {
}
@end

@interface MetalKit_MTKView_MTKViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface MessageUI_MFMailComposeViewController_MFMailComposeViewControllerAppearance : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface MessageUI_MFMessageComposeViewController_MFMessageComposeViewControllerAppearance : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface MediaPlayer_MPVolumeView_MPVolumeViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface MapKit_MKOverlayView_MKOverlayViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface MapKit_MKAnnotationView_MKAnnotationViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface MapKit_MKOverlayPathView_MKOverlayPathViewAppearance : MapKit_MKOverlayView_MKOverlayViewAppearance {
}
@end

@interface MapKit_MKCircleView_MKCircleViewAppearance : MapKit_MKOverlayPathView_MKOverlayPathViewAppearance {
}
@end

@interface MapKit_MKCompassButton_MKCompassButtonAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface MapKit_MKMapView_MKMapViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface MapKit_MKMarkerAnnotationView_MKMarkerAnnotationViewAppearance : MapKit_MKAnnotationView_MKAnnotationViewAppearance {
}
	-(UIImage *) glyphImage;
	-(void) setGlyphImage:(UIImage *)p0;
	-(NSString *) glyphText;
	-(void) setGlyphText:(NSString *)p0;
	-(UIColor *) glyphTintColor;
	-(void) setGlyphTintColor:(UIColor *)p0;
	-(UIColor *) markerTintColor;
	-(void) setMarkerTintColor:(UIColor *)p0;
	-(UIImage *) selectedGlyphImage;
	-(void) setSelectedGlyphImage:(UIImage *)p0;
@end

@interface MapKit_MKPinAnnotationView_MKPinAnnotationViewAppearance : MapKit_MKAnnotationView_MKAnnotationViewAppearance {
}
	-(UIColor *) pinTintColor;
	-(void) setPinTintColor:(UIColor *)p0;
@end

@interface MapKit_MKPolygonView_MKPolygonViewAppearance : MapKit_MKOverlayPathView_MKOverlayPathViewAppearance {
}
@end

@interface MapKit_MKPolylineView_MKPolylineViewAppearance : MapKit_MKOverlayPathView_MKOverlayPathViewAppearance {
}
@end

@interface MapKit_MKScaleView_MKScaleViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UIBarItem_UIBarItemAppearance : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSDictionary *) titleTextAttributesForState:(NSUInteger)p0;
	-(void) setTitleTextAttributes:(NSDictionary *)p0 forState:(NSUInteger)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface UIKit_UIBarButtonItem_UIBarButtonItemAppearance : UIKit_UIBarItem_UIBarItemAppearance {
}
	-(UIImage *) backButtonBackgroundImageForState:(NSUInteger)p0 barMetrics:(NSInteger)p1;
	-(CGFloat) backButtonBackgroundVerticalPositionAdjustmentForBarMetrics:(NSInteger)p0;
	-(UIOffset) backButtonTitlePositionAdjustmentForBarMetrics:(NSInteger)p0;
	-(UIImage *) backgroundImageForState:(NSUInteger)p0 barMetrics:(NSInteger)p1;
	-(UIImage *) backgroundImageForState:(NSUInteger)p0 style:(NSInteger)p1 barMetrics:(NSInteger)p2;
	-(CGFloat) backgroundVerticalPositionAdjustmentForBarMetrics:(NSInteger)p0;
	-(UIOffset) titlePositionAdjustmentForBarMetrics:(NSInteger)p0;
	-(void) setBackButtonBackgroundImage:(UIImage *)p0 forState:(NSUInteger)p1 barMetrics:(NSInteger)p2;
	-(void) setBackButtonBackgroundVerticalPositionAdjustment:(CGFloat)p0 forBarMetrics:(NSInteger)p1;
	-(void) setBackButtonTitlePositionAdjustment:(UIOffset)p0 forBarMetrics:(NSInteger)p1;
	-(void) setBackgroundImage:(UIImage *)p0 forState:(NSUInteger)p1 barMetrics:(NSInteger)p2;
	-(void) setBackgroundImage:(UIImage *)p0 forState:(NSUInteger)p1 style:(NSInteger)p2 barMetrics:(NSInteger)p3;
	-(void) setBackgroundVerticalPositionAdjustment:(CGFloat)p0 forBarMetrics:(NSInteger)p1;
	-(void) setTitlePositionAdjustment:(UIOffset)p0 forBarMetrics:(NSInteger)p1;
	-(UIColor *) tintColor;
	-(void) setTintColor:(UIColor *)p0;
@end

@interface MapKit_MKUserTrackingBarButtonItem_MKUserTrackingBarButtonItemAppearance : UIKit_UIBarButtonItem_UIBarButtonItemAppearance {
}
@end

@interface MapKit_MKUserTrackingButton_MKUserTrackingButtonAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface HomeKit_HMCameraView_HMCameraViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface GLKit_GLKView_GLKViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface EventKitUI_EKEventEditViewController_EKEventEditViewControllerAppearance : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface BusinessChat_BCChatButton_BCChatButtonAppearance : UIKit_UIControl_UIControlAppearance {
}
@end

@interface SceneKit_SCNView_SCNViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface ARKit_ARSCNView_ARSCNViewAppearance : SceneKit_SCNView_SCNViewAppearance {
}
@end

@interface SpriteKit_SKView_SKViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface ARKit_ARSKView_ARSKViewAppearance : SpriteKit_SKView_SKViewAppearance {
}
@end

@interface AddressBookUI_ABPeoplePickerNavigationController_ABPeoplePickerNavigationControllerAppearance : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface GameKit_GKAchievementViewController_GKAchievementViewControllerAppearance : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface GameKit_GKFriendRequestComposeViewController_GKFriendRequestComposeViewControllerAppearance : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface GameKit_GKLeaderboardViewController_GKLeaderboardViewControllerAppearance : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface GameKit_GKTurnBasedMatchmakerViewController_GKTurnBasedMatchmakerViewControllerAppearance : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WebKit_WKWebView_WKWebViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UIActionSheet_UIActionSheetAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UIAlertView_UIAlertViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UIScrollView_UIScrollViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UICollectionView_UICollectionViewAppearance : UIKit_UIScrollView_UIScrollViewAppearance {
}
@end

@interface __UIGestureRecognizerToken : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface __UIGestureRecognizerParameterlessToken : __UIGestureRecognizerToken {
}
	-(void) target;
@end

@interface __UIGestureRecognizerParametrizedToken : __UIGestureRecognizerToken {
}
	-(void) target:(UIGestureRecognizer *)p0;
@end

@interface UIKit_UINavigationBar_UINavigationBarAppearance : UIKit_UIView_UIViewAppearance {
}
	-(UIImage *) backIndicatorImage;
	-(void) setBackIndicatorImage:(UIImage *)p0;
	-(UIImage *) backIndicatorTransitionMaskImage;
	-(void) setBackIndicatorTransitionMaskImage:(UIImage *)p0;
	-(NSInteger) barStyle;
	-(void) setBarStyle:(NSInteger)p0;
	-(UIColor *) barTintColor;
	-(void) setBarTintColor:(UIColor *)p0;
	-(UIImage *) backgroundImageForBarMetrics:(NSInteger)p0;
	-(UIImage *) backgroundImageForBarPosition:(NSInteger)p0 barMetrics:(NSInteger)p1;
	-(CGFloat) titleVerticalPositionAdjustmentForBarMetrics:(NSInteger)p0;
	-(void) setBackgroundImage:(UIImage *)p0 forBarMetrics:(NSInteger)p1;
	-(void) setBackgroundImage:(UIImage *)p0 forBarPosition:(NSInteger)p1 barMetrics:(NSInteger)p2;
	-(void) setTitleVerticalPositionAdjustment:(CGFloat)p0 forBarMetrics:(NSInteger)p1;
	-(UIImage *) shadowImage;
	-(void) setShadowImage:(UIImage *)p0;
	-(BOOL) isTranslucent;
	-(void) setTranslucent:(BOOL)p0;
	-(NSDictionary *) largeTitleTextAttributes;
	-(void) setLargeTitleTextAttributes:(NSDictionary *)p0;
	-(NSDictionary *) titleTextAttributes;
	-(void) setTitleTextAttributes:(NSDictionary *)p0;
@end

@interface UIKit_UIPickerView_UIPickerViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UISearchBar_UISearchBarAppearance : UIKit_UIView_UIViewAppearance {
}
	-(UIImage *) backgroundImage;
	-(void) setBackgroundImage:(UIImage *)p0;
	-(UIImage *) backgroundImageForBarPosition:(NSInteger)p0 barMetrics:(NSInteger)p1;
	-(UIColor *) barTintColor;
	-(void) setBarTintColor:(UIColor *)p0;
	-(UIImage *) imageForSearchBarIcon:(NSInteger)p0 state:(NSUInteger)p1;
	-(UIImage *) scopeBarButtonBackgroundImageForState:(NSUInteger)p0;
	-(UIImage *) scopeBarButtonDividerImageForLeftSegmentState:(NSUInteger)p0 rightSegmentState:(NSUInteger)p1;
	-(UIImage *) searchFieldBackgroundImageForState:(NSUInteger)p0;
	-(UIImage *) scopeBarBackgroundImage;
	-(void) setScopeBarBackgroundImage:(UIImage *)p0;
	-(void) setBackgroundImage:(UIImage *)p0 forBarPosition:(NSInteger)p1 barMetrics:(NSInteger)p2;
	-(void) setImage:(UIImage *)p0 forSearchBarIcon:(NSInteger)p1 state:(NSUInteger)p2;
	-(void) setScopeBarButtonBackgroundImage:(UIImage *)p0 forState:(NSUInteger)p1;
	-(void) setScopeBarButtonDividerImage:(UIImage *)p0 forLeftSegmentState:(NSUInteger)p1 rightSegmentState:(NSUInteger)p2;
	-(void) setSearchFieldBackgroundImage:(UIImage *)p0 forState:(NSUInteger)p1;
	-(NSDictionary *) scopeBarButtonTitleTextAttributesForState:(NSUInteger)p0;
	-(void) setScopeBarButtonTitleTextAttributes:(NSDictionary *)p0 forState:(NSUInteger)p1;
@end

@interface UIKit_UISegmentedControl_UISegmentedControlAppearance : UIKit_UIControl_UIControlAppearance {
}
	-(UIOffset) contentPositionAdjustmentForSegmentType:(NSInteger)p0 barMetrics:(NSInteger)p1;
	-(UIImage *) dividerImageForLeftSegmentState:(NSUInteger)p0 rightSegmentState:(NSUInteger)p1 barMetrics:(NSInteger)p2;
	-(UIImage *) backgroundImageForState:(NSUInteger)p0 barMetrics:(NSInteger)p1;
	-(void) setBackgroundImage:(UIImage *)p0 forState:(NSUInteger)p1 barMetrics:(NSInteger)p2;
	-(void) setContentPositionAdjustment:(UIOffset)p0 forSegmentType:(NSInteger)p1 barMetrics:(NSInteger)p2;
	-(void) setDividerImage:(UIImage *)p0 forLeftSegmentState:(NSUInteger)p1 rightSegmentState:(NSUInteger)p2 barMetrics:(NSInteger)p3;
	-(NSDictionary *) titleTextAttributesForState:(NSUInteger)p0;
	-(void) setTitleTextAttributes:(NSDictionary *)p0 forState:(NSUInteger)p1;
@end

@interface UIKit_UITableView_UITableViewAppearance : UIKit_UIScrollView_UIScrollViewAppearance {
}
	-(UIColor *) sectionIndexBackgroundColor;
	-(void) setSectionIndexBackgroundColor:(UIColor *)p0;
	-(UIColor *) sectionIndexColor;
	-(void) setSectionIndexColor:(UIColor *)p0;
	-(UIColor *) sectionIndexTrackingBackgroundColor;
	-(void) setSectionIndexTrackingBackgroundColor:(UIColor *)p0;
	-(UIColor *) separatorColor;
	-(void) setSeparatorColor:(UIColor *)p0;
	-(UIVisualEffect *) separatorEffect;
	-(void) setSeparatorEffect:(UIVisualEffect *)p0;
	-(UIEdgeInsets) separatorInset;
	-(void) setSeparatorInset:(UIEdgeInsets)p0;
@end

@interface UIKit_UITableViewCell_UITableViewCellAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UITextField_UITextFieldAppearance : UIKit_UIControl_UIControlAppearance {
}
@end

@interface UIKit_UITextView_UITextViewAppearance : UIKit_UIScrollView_UIScrollViewAppearance {
}
@end

@interface UIKit_UIToolbar_UIToolbarAppearance : UIKit_UIView_UIViewAppearance {
}
	-(UIColor *) barTintColor;
	-(void) setBarTintColor:(UIColor *)p0;
	-(UIImage *) backgroundImageForToolbarPosition:(NSInteger)p0 barMetrics:(NSInteger)p1;
	-(UIImage *) shadowImageForToolbarPosition:(NSInteger)p0;
	-(void) setBackgroundImage:(UIImage *)p0 forToolbarPosition:(NSInteger)p1 barMetrics:(NSInteger)p2;
	-(void) setShadowImage:(UIImage *)p0 forToolbarPosition:(NSInteger)p1;
@end

@interface UIKit_UIWindow_UIWindowAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UIActivityIndicatorView_UIActivityIndicatorViewAppearance : UIKit_UIView_UIViewAppearance {
}
	-(UIColor *) color;
	-(void) setColor:(UIColor *)p0;
@end

@interface UIKit_UICollectionReusableView_UICollectionReusableViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UICollectionViewCell_UICollectionViewCellAppearance : UIKit_UICollectionReusableView_UICollectionReusableViewAppearance {
}
@end

@interface UIKit_UIDatePicker_UIDatePickerAppearance : UIKit_UIControl_UIControlAppearance {
}
@end

@interface UIKit_UIImageView_UIImageViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UIInputView_UIInputViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UILabel_UILabelAppearance : UIKit_UIView_UIViewAppearance {
}
	-(UIFont *) font;
	-(void) setFont:(UIFont *)p0;
	-(UIColor *) highlightedTextColor;
	-(void) setHighlightedTextColor:(UIColor *)p0;
	-(UIColor *) shadowColor;
	-(void) setShadowColor:(UIColor *)p0;
	-(CGSize) shadowOffset;
	-(void) setShadowOffset:(CGSize)p0;
	-(UIColor *) textColor;
	-(void) setTextColor:(UIColor *)p0;
@end

@interface UIKit_UIPageControl_UIPageControlAppearance : UIKit_UIControl_UIControlAppearance {
}
	-(UIColor *) currentPageIndicatorTintColor;
	-(void) setCurrentPageIndicatorTintColor:(UIColor *)p0;
	-(UIColor *) pageIndicatorTintColor;
	-(void) setPageIndicatorTintColor:(UIColor *)p0;
@end

@interface UIKit_UIPopoverBackgroundView_UIPopoverBackgroundViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UIProgressView_UIProgressViewAppearance : UIKit_UIView_UIViewAppearance {
}
	-(UIImage *) progressImage;
	-(void) setProgressImage:(UIImage *)p0;
	-(UIColor *) progressTintColor;
	-(void) setProgressTintColor:(UIColor *)p0;
	-(UIImage *) trackImage;
	-(void) setTrackImage:(UIImage *)p0;
	-(UIColor *) trackTintColor;
	-(void) setTrackTintColor:(UIColor *)p0;
@end

@interface UIKit_UIRefreshControl_UIRefreshControlAppearance : UIKit_UIControl_UIControlAppearance {
}
	-(NSAttributedString *) attributedTitle;
	-(void) setAttributedTitle:(NSAttributedString *)p0;
@end

@interface UIKit_UISlider_UISliderAppearance : UIKit_UIControl_UIControlAppearance {
}
	-(UIImage *) maximumTrackImageForState:(NSUInteger)p0;
	-(UIImage *) maximumValueImage;
	-(void) setMaximumValueImage:(UIImage *)p0;
	-(UIColor *) maximumTrackTintColor;
	-(void) setMaximumTrackTintColor:(UIColor *)p0;
	-(UIImage *) minimumTrackImageForState:(NSUInteger)p0;
	-(UIImage *) minimumValueImage;
	-(void) setMinimumValueImage:(UIImage *)p0;
	-(UIColor *) minimumTrackTintColor;
	-(void) setMinimumTrackTintColor:(UIColor *)p0;
	-(void) setMaximumTrackImage:(UIImage *)p0 forState:(NSUInteger)p1;
	-(void) setMinimumTrackImage:(UIImage *)p0 forState:(NSUInteger)p1;
	-(void) setThumbImage:(UIImage *)p0 forState:(NSUInteger)p1;
	-(UIImage *) thumbImageForState:(NSUInteger)p0;
	-(UIColor *) thumbTintColor;
	-(void) setThumbTintColor:(UIColor *)p0;
@end

@interface UIKit_UIStackView_UIStackViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UIStepper_UIStepperAppearance : UIKit_UIControl_UIControlAppearance {
}
	-(UIImage *) backgroundImageForState:(NSUInteger)p0;
	-(UIImage *) decrementImageForState:(NSUInteger)p0;
	-(UIImage *) dividerImageForLeftSegmentState:(NSUInteger)p0 rightSegmentState:(NSUInteger)p1;
	-(UIImage *) incrementImageForState:(NSUInteger)p0;
	-(void) setBackgroundImage:(UIImage *)p0 forState:(NSUInteger)p1;
	-(void) setDecrementImage:(UIImage *)p0 forState:(NSUInteger)p1;
	-(void) setDividerImage:(UIImage *)p0 forLeftSegmentState:(NSUInteger)p1 rightSegmentState:(NSUInteger)p2;
	-(void) setIncrementImage:(UIImage *)p0 forState:(NSUInteger)p1;
@end

@interface UIKit_UISwitch_UISwitchAppearance : UIKit_UIControl_UIControlAppearance {
}
	-(UIImage *) offImage;
	-(void) setOffImage:(UIImage *)p0;
	-(UIImage *) onImage;
	-(void) setOnImage:(UIImage *)p0;
	-(UIColor *) onTintColor;
	-(void) setOnTintColor:(UIColor *)p0;
	-(UIColor *) thumbTintColor;
	-(void) setThumbTintColor:(UIColor *)p0;
@end

@interface UIKit_UITabBar_UITabBarAppearance : UIKit_UIView_UIViewAppearance {
}
	-(UIImage *) backgroundImage;
	-(void) setBackgroundImage:(UIImage *)p0;
	-(UIColor *) barTintColor;
	-(void) setBarTintColor:(UIColor *)p0;
	-(UIColor *) selectedImageTintColor;
	-(void) setSelectedImageTintColor:(UIColor *)p0;
	-(UIImage *) selectionIndicatorImage;
	-(void) setSelectionIndicatorImage:(UIImage *)p0;
	-(UIImage *) shadowImage;
	-(void) setShadowImage:(UIImage *)p0;
@end

@interface UIKit_UITabBarItem_UITabBarItemAppearance : UIKit_UIBarItem_UIBarItemAppearance {
}
	-(UIOffset) titlePositionAdjustment;
	-(void) setTitlePositionAdjustment:(UIOffset)p0;
@end

@interface UIKit_UITableViewHeaderFooterView_UITableViewHeaderFooterViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UIVisualEffectView_UIVisualEffectViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UIWebView_UIWebViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface AVKit_AVRoutePickerView_AVRoutePickerViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface FIRDatabaseQuery : NSObject {
}
	-(id) queryEndingAtValue:(NSObject *)p0;
	-(id) queryEndingAtValue:(NSObject *)p0 childKey:(NSString *)p1;
	-(id) queryEqualToValue:(NSObject *)p0;
	-(id) queryEqualToValue:(NSObject *)p0 childKey:(NSString *)p1;
	-(id) queryLimitedToFirst:(NSUInteger)p0;
	-(id) queryLimitedToLast:(NSUInteger)p0;
	-(id) queryOrderedByChild:(NSString *)p0;
	-(id) queryOrderedByKey;
	-(id) queryOrderedByPriority;
	-(id) queryOrderedByValue;
	-(id) queryStartingAtValue:(NSObject *)p0;
	-(id) queryStartingAtValue:(NSObject *)p0 childKey:(NSString *)p1;
	-(void) keepSynced:(BOOL)p0;
	-(NSUInteger) observeEventType:(NSInteger)p0 withBlock:(id)p1;
	-(NSUInteger) observeEventType:(NSInteger)p0 andPreviousSiblingKeyWithBlock:(id)p1;
	-(NSUInteger) observeEventType:(NSInteger)p0 withBlock:(id)p1 withCancelBlock:(id)p2;
	-(NSUInteger) observeEventType:(NSInteger)p0 andPreviousSiblingKeyWithBlock:(id)p1 withCancelBlock:(id)p2;
	-(void) observeSingleEventOfType:(NSInteger)p0 withBlock:(id)p1;
	-(void) observeSingleEventOfType:(NSInteger)p0 andPreviousSiblingKeyWithBlock:(id)p1;
	-(void) observeSingleEventOfType:(NSInteger)p0 withBlock:(id)p1 withCancelBlock:(id)p2;
	-(void) observeSingleEventOfType:(NSInteger)p0 andPreviousSiblingKeyWithBlock:(id)p1 withCancelBlock:(id)p2;
	-(void) removeAllObservers;
	-(void) removeObserverWithHandle:(NSUInteger)p0;
	-(id) ref;
	-(id) init;
@end

@interface FIRDatabaseReference : FIRDatabaseQuery {
}
	-(void) cancelDisconnectOperations;
	-(void) cancelDisconnectOperationsWithCompletionBlock:(id)p0;
	-(id) child:(NSString *)p0;
	-(id) childByAppendingPath:(NSString *)p0;
	-(id) childByAutoId;
	-(id) queryEndingAtValue:(NSObject *)p0;
	-(id) queryEndingAtValue:(NSObject *)p0 childKey:(NSString *)p1;
	-(id) queryEqualToValue:(NSObject *)p0;
	-(id) queryEqualToValue:(NSObject *)p0 childKey:(NSString *)p1;
	-(id) queryLimitedToFirst:(NSUInteger)p0;
	-(id) queryLimitedToLast:(NSUInteger)p0;
	-(id) queryOrderedByChild:(NSString *)p0;
	-(id) queryOrderedByKey;
	-(id) queryOrderedByPriority;
	-(id) queryStartingAtValue:(NSObject *)p0;
	-(id) queryStartingAtValue:(NSObject *)p0 childKey:(NSString *)p1;
	-(void) keepSynced:(BOOL)p0;
	-(NSUInteger) observeEventType:(NSInteger)p0 withBlock:(id)p1;
	-(NSUInteger) observeEventType:(NSInteger)p0 andPreviousSiblingKeyWithBlock:(id)p1;
	-(NSUInteger) observeEventType:(NSInteger)p0 withBlock:(id)p1 withCancelBlock:(id)p2;
	-(NSUInteger) observeEventType:(NSInteger)p0 andPreviousSiblingKeyWithBlock:(id)p1 withCancelBlock:(id)p2;
	-(void) observeSingleEventOfType:(NSInteger)p0 withBlock:(id)p1;
	-(void) observeSingleEventOfType:(NSInteger)p0 andPreviousSiblingKeyWithBlock:(id)p1;
	-(void) observeSingleEventOfType:(NSInteger)p0 withBlock:(id)p1 withCancelBlock:(id)p2;
	-(void) observeSingleEventOfType:(NSInteger)p0 andPreviousSiblingKeyWithBlock:(id)p1 withCancelBlock:(id)p2;
	-(void) removeAllObservers;
	-(void) removeObserverWithHandle:(NSUInteger)p0;
	-(void) removeValue;
	-(void) removeValueWithCompletionBlock:(id)p0;
	-(void) onDisconnectRemoveValue;
	-(void) onDisconnectRemoveValueWithCompletionBlock:(id)p0;
	-(void) runTransactionBlock:(id)p0;
	-(void) runTransactionBlock:(id)p0 andCompletionBlock:(id)p1;
	-(void) runTransactionBlock:(id)p0 andCompletionBlock:(id)p1 withLocalEvents:(BOOL)p2;
	-(void) setPriority:(NSObject *)p0;
	-(void) setPriority:(NSObject *)p0 withCompletionBlock:(id)p1;
	-(void) updateChildValues:(NSDictionary *)p0;
	-(void) updateChildValues:(NSDictionary *)p0 withCompletionBlock:(id)p1;
	-(void) onDisconnectUpdateChildValues:(NSDictionary *)p0;
	-(void) onDisconnectUpdateChildValues:(NSDictionary *)p0 withCompletionBlock:(id)p1;
	-(void) setValue:(NSObject *)p0;
	-(void) setValue:(NSObject *)p0 withCompletionBlock:(id)p1;
	-(void) setValue:(NSObject *)p0 andPriority:(NSObject *)p1;
	-(void) setValue:(NSObject *)p0 andPriority:(NSObject *)p1 withCompletionBlock:(id)p2;
	-(void) onDisconnectSetValue:(NSObject *)p0;
	-(void) onDisconnectSetValue:(NSObject *)p0 withCompletionBlock:(id)p1;
	-(void) onDisconnectSetValue:(NSObject *)p0 andPriority:(NSObject *)p1;
	-(void) onDisconnectSetValue:(NSObject *)p0 andPriority:(NSObject *)p1 withCompletionBlock:(id)p2;
	-(id) database;
	-(NSString *) description;
	-(NSString *) key;
	-(id) parent;
	-(id) root;
	-(NSString *) URL;
	-(id) init;
@end

@interface FIRDataSnapshot : NSObject {
}
	-(id) childSnapshotForPath:(NSString *)p0;
	-(BOOL) hasChild:(NSString *)p0;
	-(NSEnumerator *) children;
	-(NSUInteger) childrenCount;
	-(BOOL) exists;
	-(BOOL) hasChildren;
	-(NSString *) key;
	-(NSObject *) priority;
	-(id) ref;
	-(NSObject *) valueInExportFormat;
	-(void *) value;
	-(id) init;
@end

@interface FIRMutableData : NSObject {
}
	-(id) childDataByAppendingPath:(NSString *)p0;
	-(BOOL) hasChildAtPath:(NSString *)p0;
	-(NSEnumerator *) children;
	-(NSUInteger) childrenCount;
	-(BOOL) hasChildren;
	-(NSString *) key;
	-(NSObject *) priority;
	-(void) setPriority:(NSObject *)p0;
	-(void *) value;
	-(void) setValue:(void *)p0;
	-(id) init;
@end

@interface FIRDatabase : NSObject {
}
	-(id) referenceWithPath:(NSString *)p0;
	-(id) referenceFromURL:(NSString *)p0;
	-(id) reference;
	-(void) goOffline;
	-(void) goOnline;
	-(void) purgeOutstandingWrites;
	-(id) app;
	-(id) callbackQueue;
	-(void) setCallbackQueue:(id)p0;
	-(NSUInteger) persistenceCacheSizeBytes;
	-(void) setPersistenceCacheSizeBytes:(NSUInteger)p0;
	-(BOOL) persistenceEnabled;
	-(void) setPersistenceEnabled:(BOOL)p0;
@end

@interface FIRServerValue : NSObject {
}
@end

@interface FIRTransactionResult : NSObject {
}
@end

@interface FIRAnalyticsConfiguration : NSObject {
}
	-(void) setAnalyticsCollectionEnabled:(BOOL)p0;
	-(void) setMinimumSessionInterval:(double)p0;
	-(void) setSessionTimeoutInterval:(double)p0;
@end

@interface FIRApp : NSObject {
}
	-(void) deleteApp:(id)p0;
	-(NSString *) name;
	-(id) options;
@end

@interface FIRConfiguration : NSObject {
}
	-(void) setLoggerLevel:(NSInteger)p0;
	-(id) analyticsConfiguration;
	-(void) setAnalyticsConfiguration:(id)p0;
	-(NSInteger) logLevel;
	-(void) setLogLevel:(NSInteger)p0;
@end

@interface FIROptions : NSObject {
}
	-(NSObject *) copyWithZone:(id)p0;
	-(NSString *) androidClientID;
	-(void) setAndroidClientID:(NSString *)p0;
	-(NSString *) APIKey;
	-(void) setAPIKey:(NSString *)p0;
	-(NSString *) bundleID;
	-(void) setBundleID:(NSString *)p0;
	-(NSString *) clientID;
	-(void) setClientID:(NSString *)p0;
	-(NSString *) databaseURL;
	-(void) setDatabaseURL:(NSString *)p0;
	-(NSString *) deepLinkURLScheme;
	-(void) setDeepLinkURLScheme:(NSString *)p0;
	-(NSString *) GCMSenderID;
	-(void) setGCMSenderID:(NSString *)p0;
	-(NSString *) googleAppID;
	-(void) setGoogleAppID:(NSString *)p0;
	-(NSString *) projectID;
	-(void) setProjectID:(NSString *)p0;
	-(NSString *) storageBucket;
	-(void) setStorageBucket:(NSString *)p0;
	-(NSString *) trackingID;
	-(void) setTrackingID:(NSString *)p0;
	-(id) initWithGoogleAppID:(NSString *)p0 bundleID:(NSString *)p1 GCMSenderID:(NSString *)p2 APIKey:(NSString *)p3 clientID:(NSString *)p4 trackingID:(NSString *)p5 androidClientID:(NSString *)p6 databaseURL:(NSString *)p7 storageBucket:(NSString *)p8 deepLinkURLScheme:(NSString *)p9;
	-(id) initWithContentsOfFile:(NSString *)p0;
	-(id) initWithGoogleAppID:(NSString *)p0 GCMSenderID:(NSString *)p1;
@end

@interface FIRInstanceID : NSObject {
}
	-(void) deleteIDWithHandler:(id)p0;
	-(void) deleteTokenWithAuthorizedEntity:(NSString *)p0 scope:(NSString *)p1 handler:(id)p2;
	-(void) getIDWithHandler:(id)p0;
	-(void) tokenWithAuthorizedEntity:(NSString *)p0 scope:(NSString *)p1 options:(NSDictionary *)p2 handler:(id)p3;
	-(void) setAPNSToken:(NSData *)p0 type:(NSInteger)p1;
	-(NSString *) token;
@end

@interface FIRAnalytics : NSObject {
}
	-(NSString *) appInstanceID;
	-(id) init;
@end

@interface FIRActionCodeInfo : NSObject {
}
	-(NSString *) dataForKey:(NSInteger)p0;
	-(NSInteger) operation;
@end

@interface FIRActionCodeSettings : NSObject {
}
	-(void) setAndroidPackageName:(NSString *)p0 installIfNotAvailable:(BOOL)p1 minimumVersion:(NSString *)p2;
	-(BOOL) androidInstallIfNotAvailable;
	-(NSString *) androidMinimumVersion;
	-(NSString *) androidPackageName;
	-(BOOL) handleCodeInApp;
	-(void) setHandleCodeInApp:(BOOL)p0;
	-(NSString *) iOSBundleID;
	-(void) setIOSBundleID:(NSString *)p0;
	-(NSURL *) URL;
	-(void) setURL:(NSURL *)p0;
	-(id) init;
@end

@interface FIRAdditionalUserInfo : NSObject {
}
	-(BOOL) isNewUser;
	-(NSDictionary <NSString *, NSObject *>*) profile;
	-(NSString *) providerID;
	-(NSString *) username;
@end

@interface FIRAuthCredential : NSObject {
}
	-(NSString *) provider;
@end

@interface FIRAuthDataResult : NSObject {
}
	-(id) additionalUserInfo;
	-(id) user;
@end

@protocol FIRAuthUIDelegate
	@required -(void) presentViewController:(UIViewController *)p0 animated:(BOOL)p1 completion:(id)p2;
	@required -(void) dismissViewControllerAnimated:(BOOL)p0 completion:(id)p1;
@end

@interface FIRAuthUIDelegate : NSObject<FIRAuthUIDelegate> {
}
	-(id) init;
@end

@interface FIREmailAuthProvider : NSObject {
}
@end

@interface FIRFacebookAuthProvider : NSObject {
}
@end

@interface FIRGitHubAuthProvider : NSObject {
}
@end

@interface FIRGoogleAuthProvider : NSObject {
}
@end

@interface FIROAuthProvider : NSObject {
}
@end

@interface FIRPhoneAuthCredential : FIRAuthCredential {
}
@end

@interface FIRTwitterAuthProvider : NSObject {
}
@end

@protocol FIRUserInfo
	@required @property (nonatomic, assign, readonly) NSString * uid;
	@required @property (nonatomic, assign, readonly) NSString * displayName;
	@required @property (nonatomic, assign, readonly) NSString * email;
	@required @property (nonatomic, assign, readonly) NSString * providerID;
	@required @property (nonatomic, assign, readonly) NSString * phoneNumber;
	@required @property (nonatomic, copy, readonly) NSURL * photoURL;
@end

@interface FIRUserMetadata : NSObject {
}
	-(NSDate *) creationDate;
	-(NSDate *) lastSignInDate;
@end

@interface FIRAuth : NSObject {
}
	-(NSObject *) addAuthStateDidChangeListener:(id)p0;
	-(NSObject *) addIDTokenDidChangeListener:(id)p0;
	-(void) applyActionCode:(NSString *)p0 completion:(id)p1;
	-(BOOL) canHandleNotification:(NSDictionary *)p0;
	-(BOOL) canHandleURL:(NSURL *)p0;
	-(void) checkActionCode:(NSString *)p0 completion:(id)p1;
	-(void) confirmPasswordResetWithCode:(NSString *)p0 newPassword:(NSString *)p1 completion:(id)p2;
	-(void) createUserWithEmail:(NSString *)p0 password:(NSString *)p1 completion:(id)p2;
	-(void) createUserAndRetrieveDataWithEmail:(NSString *)p0 password:(NSString *)p1 completion:(id)p2;
	-(void) fetchProvidersForEmail:(NSString *)p0 completion:(id)p1;
	-(void) removeAuthStateDidChangeListener:(NSObject *)p0;
	-(void) removeIDTokenDidChangeListener:(NSObject *)p0;
	-(void) sendPasswordResetWithEmail:(NSString *)p0 completion:(id)p1;
	-(void) sendPasswordResetWithEmail:(NSString *)p0 actionCodeSettings:(id)p1 completion:(id)p2;
	-(void) setAPNSToken:(NSData *)p0 type:(NSInteger)p1;
	-(void) signInWithEmail:(NSString *)p0 password:(NSString *)p1 completion:(id)p2;
	-(void) signInWithCredential:(id)p0 completion:(id)p1;
	-(void) signInWithCustomToken:(NSString *)p0 completion:(id)p1;
	-(void) signInAndRetrieveDataWithEmail:(NSString *)p0 password:(NSString *)p1 completion:(id)p2;
	-(void) signInAndRetrieveDataWithCredential:(id)p0 completion:(id)p1;
	-(void) signInAndRetrieveDataWithCustomToken:(NSString *)p0 completion:(id)p1;
	-(void) signInAnonymouslyWithCompletion:(id)p0;
	-(void) signInAnonymouslyAndRetrieveDataWithCompletion:(id)p0;
	-(BOOL) signOut:(NSError **)p0;
	-(void) useAppLanguage;
	-(void) verifyPasswordResetCode:(NSString *)p0 completion:(id)p1;
	-(NSData *) APNSToken;
	-(void) setAPNSToken:(NSData *)p0;
	-(id) app;
	-(id) currentUser;
	-(NSString *) languageCode;
	-(void) setLanguageCode:(NSString *)p0;
@end

@interface FIRPhoneAuthProvider : NSObject {
}
	-(id) credentialWithVerificationID:(NSString *)p0 verificationCode:(NSString *)p1;
	-(void) verifyPhoneNumber:(NSString *)p0 completion:(id)p1;
	-(void) verifyPhoneNumber:(NSString *)p0 UIDelegate:(id)p1 completion:(id)p2;
@end

@interface FIRUser : NSObject {
}
	-(void) deleteWithCompletion:(id)p0;
	-(void) getIDTokenWithCompletion:(id)p0;
	-(void) getIDTokenForcingRefresh:(BOOL)p0 completion:(id)p1;
	-(void) getTokenWithCompletion:(id)p0;
	-(void) getTokenForcingRefresh:(BOOL)p0 completion:(id)p1;
	-(void) linkWithCredential:(id)p0 completion:(id)p1;
	-(void) linkAndRetrieveDataWithCredential:(id)p0 completion:(id)p1;
	-(id) profileChangeRequest;
	-(void) reauthenticateWithCredential:(id)p0 completion:(id)p1;
	-(void) reauthenticateAndRetrieveDataWithCredential:(id)p0 completion:(id)p1;
	-(void) reloadWithCompletion:(id)p0;
	-(void) sendEmailVerificationWithCompletion:(id)p0;
	-(void) sendEmailVerificationWithActionCodeSettings:(id)p0 completion:(id)p1;
	-(void) unlinkFromProvider:(NSString *)p0 completion:(id)p1;
	-(void) updateEmail:(NSString *)p0 completion:(id)p1;
	-(void) updatePassword:(NSString *)p0 completion:(id)p1;
	-(void) updatePhoneNumberCredential:(id)p0 completion:(id)p1;
	-(NSString *) displayName;
	-(NSString *) email;
	-(BOOL) isAnonymous;
	-(BOOL) isEmailVerified;
	-(id) metadata;
	-(NSString *) phoneNumber;
	-(NSURL *) photoURL;
	-(NSArray *) providerData;
	-(NSString *) providerID;
	-(NSString *) refreshToken;
	-(NSString *) uid;
@end

@interface FIRUserProfileChangeRequest : NSObject {
}
	-(void) commitChangesWithCompletion:(id)p0;
	-(NSString *) displayName;
	-(void) setDisplayName:(NSString *)p0;
	-(NSURL *) photoURL;
	-(void) setPhotoURL:(NSURL *)p0;
@end

@interface Xamarin_Auth_NativeAuthSafariViewControllerDelegate : NSObject<SFSafariViewControllerDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) safariViewController:(SFSafariViewController *)p0 didCompleteInitialLoad:(BOOL)p1;
	-(void) safariViewControllerDidFinish:(SFSafariViewController *)p0;
	-(NSArray *) safariViewController:(SFSafariViewController *)p0 activityItemsForURL:(NSURL *)p1 title:(NSString *)p2;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface Xamarin_Auth_WebAuthenticatorController_WKWebViewJacascriptMessageHandler : NSObject<WKScriptMessageHandler> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) userContentController:(WKUserContentController *)p0 didReceiveScriptMessage:(WKScriptMessage *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface OpenTK_Platform_iPhoneOS_iPhoneOSGameView : UIView {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	+(Class) layerClass;
	-(void) layoutSubviews;
	-(void) willMoveToWindow:(UIWindow *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithFrame:(CGRect)p0;
@end


