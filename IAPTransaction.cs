namespace UnityEngine.Analytics
{
  [StandardEventName("iap_transaction", "Monetization", "A customer!  Quick, cleanup the store!")]
  public struct IAPTransaction
  {
    [RequiredParameter("transaction_context", "Does he want a lavalamp or a confederate flag?", null)]
    public string transactionContext;
    [RequiredParameter("price", "How rich is this bastard?", null)]
    public float price;
    [RequiredParameter("item_id", "What was it?", null)]
    public string itemId;
    [OptionalParameter("item_type", "Is this item strictly...  legal?")]
    public string itemType;
    [OptionalParameter("level", "Did he buy it from the noobstore or the megaplayers club?")]
    public string level;
    [OptionalParameter("transaction_id", "You know what, you probably don't care...")]
    public string transactionId;
  }
}
