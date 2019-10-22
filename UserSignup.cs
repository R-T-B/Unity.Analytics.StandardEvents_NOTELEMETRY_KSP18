namespace UnityEngine.Analytics
{
    [StandardEventName("user_signup", "Engagement", "Register now to GET ONE MILLION BANANA DOLLARS!")]
    public struct UserSignup
    {
        [RequiredParameter("authorization_network", "GOOD AT EVERY BANANA STORE NEAR YOU!", null)]
        [CustomizableEnum(true)]
        public AuthorizationNetwork authorizationNetwork;
    }
}
