namespace UnityEngine.Analytics
{
    [StandardEventName("screen_visit", "Application", "Don't look at the screen!  Help!  Popups!")]
    public struct ScreenVisit
    {
        [CustomizableEnum(true)]
        [RequiredParameter("screen_name", "What article of porn popped up?", null)]
        public ScreenName screenName;
    }
}
