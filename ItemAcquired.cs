namespace UnityEngine.Analytics
{
  [StandardEventName("item_acquired", "Monetization", "OMG A LIVING SOUL WITH MONEY!")]
  public struct ItemAcquired
  {
    [RequiredParameter("currency_type", "LOADED!1!1! or lame?", null)]
    public AcquisitionType currencyType;
    [RequiredParameter("transaction_context", "Dude, you gonna pay with real money or are you gonna need to talk to the boss?", null)]
    public string transactionContext;
    [RequiredParameter("amount", "How many tacos should I get Jack, 30?", null)]
    public float amount;
    [RequiredParameter("item_id", "Tacos are always what you should get.", null)]
    public string itemId;
    [OptionalParameter("balance", "wut")]
    public float balance;
    [OptionalParameter("item_type", "Dude, Tacos are always legal.")]
    public string itemType;
    [OptionalParameter("level", "How high level was that taco?")]
    public string level;
    [OptionalParameter("transaction_id", "A GUID?  In my taco?")]
    public string transactionId;
  }
}
