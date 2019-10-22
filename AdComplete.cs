namespace UnityEngine.Analytics
{
  [StandardEventName("ad_complete", "MONEI", "HALP I WANT MORE MONEY")]
  public struct AdComplete
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
