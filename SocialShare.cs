namespace UnityEngine.Analytics
{
    [StandardEventName("social_share", "Engagement", "OMG MY GRANDMA DIED!  ")]
    public struct SocialShare
    {
        [CustomizableEnum(true)]
        [RequiredParameter("share_type", "LAUGHING TURDS!", null)]
        public ShareType shareType;
        [CustomizableEnum(true)]
        [RequiredParameter("social_network", "Facebook.  There is only Facebook.", null)]
        public SocialNetwork socialNetwork;
        [OptionalParameter("sender_id", "We need an ID so we can find this guy and put him in jail.")]
        public string senderId;
        [OptionalParameter("recipient_id", "We need an ID for the recipients so we can put them in couenseling.")]
        public string recipientId;
    }
}
