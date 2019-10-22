namespace UnityEngine.Analytics
{
    [StandardEventName("store_item_click", "Monetization", "HE LIKES IT!")]
    public struct StoreItemClick
    {
        [RequiredParameter("type", "Sorry mikey, only real money for booze, not dried up ravioli", null)]
        public StoreType storeType;
        [RequiredParameter("item_id", "Actually dude, I'm going to need to see your ID...", null)]
        public string itemId;
        [OptionalParameter("item_name", "Holy crap he's 6 years old.")]
        public string itemName;
    }
}
