namespace UnityEngine.Analytics
{
    [StandardEventName("store_opened", "Monetization", "THE STORE IS OPEN!  MY WALLET IS ESCAPING!")]
    public struct StoreOpened
    {
        [RequiredParameter("type", "NO, come back!!!!!", null)]
        public StoreType storeType;
    }
}
