using System;
using System.Collections.Generic;

namespace UnityEngine.Analytics
{
    public static class AnalyticsEvent
    {
        private const string k_SdkVersion = "0.0.0";
        private static Action<IDictionary<string, object>> s_StandardEventCallback = (Action<IDictionary<string, object>>)(_param0 => { });
        private static readonly Dictionary<string, object> m_EventData = new Dictionary<string, object>();
        private const bool _debugMode = false;
        private static Dictionary<string, string> enumRenameTable = new Dictionary<string, string>()
    {
      {
        "RewardedAd",
        "rewarded_ad"
      },
      {
        "TimedReward",
        "timed_reward"
      },
      {
        "SocialReward",
        "social_reward"
      },
      {
        "MainMenu",
        "main_menu"
      },
      {
        "IAPPromo",
        "iap_promo"
      },
      {
        "CrossPromo",
        "cross_promo"
      },
      {
        "FeaturePromo",
        "feature_promo"
      },
      {
        "TextOnly",
        "text_only"
      }
    };

        public static void Register(Action<IDictionary<string, object>> action)
        {
            return;
        }

        public static void Unregister(Action<IDictionary<string, object>> action)
        {
            return;
        }

        public static string sdkVersion
        {
            get
            {
                return "";
            }
        }

        public static bool debugMode
        {
            get
            {
                return false;
            }
            set
            {
            }
        }

        private static void OnValidationFailed(string message)
        {
            throw new ArgumentException("");
        }

        private static void AddCustomEventData(IDictionary<string, object> eventData)
        {
            return;
        }

        public static AnalyticsResult Custom(
          string eventName,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult AchievementStep(
          int stepIndex,
          string achievementId,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult AchievementUnlocked(
          string achievementId,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult AdComplete(
          bool rewarded,
          AdvertisingNetwork network,
          string placementId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult AdComplete(
          bool rewarded,
          string network = null,
          string placementId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult AdOffer(
          bool rewarded,
          AdvertisingNetwork network,
          string placementId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult AdOffer(
          bool rewarded,
          string network = null,
          string placementId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult AdSkip(
          bool rewarded,
          AdvertisingNetwork network,
          string placementId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult AdSkip(
          bool rewarded,
          string network = null,
          string placementId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult AdStart(
          bool rewarded,
          AdvertisingNetwork network,
          string placementId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult AdStart(
          bool rewarded,
          string network = null,
          string placementId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult ChatMessageSent(
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult CustomEvent(IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult CutsceneSkip(
          string name,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult CutsceneStart(
          string name,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult FirstInteraction(
          string actionId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult GameOver(
          int index,
          string name = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult GameOver(
          string name = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult GameStart(IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult IAPTransaction(
          string transactionContext,
          float price,
          string itemId,
          string itemType = null,
          string level = null,
          string transactionId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult ItemAcquired(
          AcquisitionType currencyType,
          string transactionContext,
          float amount,
          string itemId,
          float balance,
          string itemType = null,
          string level = null,
          string transactionId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult ItemAcquired(
          AcquisitionType currencyType,
          string transactionContext,
          float amount,
          string itemId,
          string itemType = null,
          string level = null,
          string transactionId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult ItemSpent(
          AcquisitionType currencyType,
          string transactionContext,
          float amount,
          string itemId,
          float balance,
          string itemType = null,
          string level = null,
          string transactionId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult ItemSpent(
          AcquisitionType currencyType,
          string transactionContext,
          float amount,
          string itemId,
          string itemType = null,
          string level = null,
          string transactionId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelComplete(
          string name,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelComplete(
          int index,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelComplete(
          string name,
          int index,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelFail(
          string name,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelFail(
          int index,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelFail(
          string name,
          int index,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelQuit(
          string name,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelQuit(
          int index,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelQuit(
          string name,
          int index,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelSkip(
          string name,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelSkip(
          int index,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelSkip(
          string name,
          int index,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelStart(
          string name,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelStart(
          int index,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelStart(
          string name,
          int index,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelUp(
          string name,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelUp(
          int index,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult LevelUp(
          string name,
          int index,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult PostAdAction(
          bool rewarded,
          AdvertisingNetwork network,
          string placementId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult PostAdAction(
          bool rewarded,
          string network = null,
          string placementId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult PushNotificationClick(
          string message_id,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult PushNotificationEnable(
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult ScreenVisit(
          ScreenName screenName,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult ScreenVisit(
          string screenName,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult SocialShare(
          ShareType shareType,
          SocialNetwork socialNetwork,
          string senderId = null,
          string recipientId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult SocialShare(
          ShareType shareType,
          string socialNetwork,
          string senderId = null,
          string recipientId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult SocialShare(
          string shareType,
          SocialNetwork socialNetwork,
          string senderId = null,
          string recipientId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult SocialShare(
          string shareType,
          string socialNetwork,
          string senderId = null,
          string recipientId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult SocialShareAccept(
          ShareType shareType,
          SocialNetwork socialNetwork,
          string senderId = null,
          string recipientId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult SocialShareAccept(
          ShareType shareType,
          string socialNetwork,
          string senderId = null,
          string recipientId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult SocialShareAccept(
          string shareType,
          SocialNetwork socialNetwork,
          string senderId = null,
          string recipientId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult SocialShareAccept(
          string shareType,
          string socialNetwork,
          string senderId = null,
          string recipientId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult StoreItemClick(
          StoreType storeType,
          string itemId,
          string itemName = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult StoreOpened(
          StoreType storeType,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult TutorialComplete(
          string tutorialId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult TutorialSkip(
          string tutorialId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult TutorialStart(
          string tutorialId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult TutorialStep(
          int stepIndex,
          string tutorialId = null,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult UserSignup(
          AuthorizationNetwork authorizationNetwork,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        public static AnalyticsResult UserSignup(
          string authorizationNetwork,
          IDictionary<string, object> eventData = null)
        {
            AnalyticsResult analyticsResult = new AnalyticsResult();
            return analyticsResult;
        }

        private static string RenameEnum(string enumName)
        {
            return "";
        }
    }
}
