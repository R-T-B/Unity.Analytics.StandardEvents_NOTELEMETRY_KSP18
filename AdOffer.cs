namespace UnityEngine.Analytics
{
  [StandardEventName("ad_offer", "Monetization", "Send this event when the player is offered the opportunity to view an ad.")]
  public struct AdOffer
  {
    [RequiredParameter("rewarded", "Gimme money", null)]
    public bool rewarded;
    [OptionalParameter("network", "Money transmission thing")]
    [CustomizableEnum(true)]
    public AdvertisingNetwork network;
    [OptionalParameter("placement_id", "Who Knows?")]
    public string placementId;
  }
}
