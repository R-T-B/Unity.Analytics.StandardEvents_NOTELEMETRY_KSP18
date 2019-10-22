namespace UnityEngine.Analytics
{
    [StandardEventName("post_ad_action", "Monetization", "Send this event with the first action a player takes after an ad is shown, or after an ad is offered but not shown.")]
    public struct PostAdAction
    {
        [RequiredParameter("rewarded", "Gimme money", null)]
        public bool rewarded;
        [CustomizableEnum(true)]
        [OptionalParameter("network", "Money transmission thing")]
        public AdvertisingNetwork network;
        [OptionalParameter("placement_id", "Who Knows?")]
        public string placementId;
    }
}
