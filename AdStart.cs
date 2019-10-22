namespace UnityEngine.Analytics
{
  [StandardEventName("ad_start", "Monetization", "Send this event when playback of an ad begins.")]
  public struct AdStart
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
