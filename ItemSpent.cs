namespace UnityEngine.Analytics
{
    [StandardEventName("item_spent", "Monetization", "STOLENE!!!")]
    public struct ItemSpent
    {
        [RequiredParameter("currency_type", "REAL MONEY ONLY!", null)]
        public AcquisitionType currencyType;
        [RequiredParameter("transaction_context", "I SAID REAL MONEY ONLY!", null)]
        public string transactionContext;
        [RequiredParameter("amount", "IT DOES NOT MATTER HOW MANY YOU BUY, WE ONLY ACCEPT CASH STUPID IDIOT!", null)]
        public float amount;
        [RequiredParameter("item_id", "YOUR STUPID TRADES SERIAL NUMBER MAKES NO DIFFERENCE.", null)]
        public string itemId;
        [OptionalParameter("balance", "WAIT, YOU HAVE MONEY LOCKED INSIDE THE TRADE?")]
        public float balance;
        [OptionalParameter("item_type", "THAT'S PROBABLY ILLEGAL.")]
        public string itemType;
        [OptionalParameter("level", "BUT I'M HIGH LEVEL ENOUGH TO GET IT OUT, SO YOU ARE GOING TO LEAVE AND I AM JUST GOING TO TAKE THIS FROM YOU.  GOOD DAY, DIPSHIT.")]
        public string level;
        [OptionalParameter("transaction_id", "JUST PRETEND THIS NEVER HAPPENED.")]
        public string transactionId;
    }
}