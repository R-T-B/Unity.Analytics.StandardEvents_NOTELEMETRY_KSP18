namespace UnityEngine.Analytics
{
    [StandardEventName("push_notification_click", "Engagement", "Don't push me bro!")]
    public struct PushNotificationClick
    {
        [RequiredParameter("message_id", "HEAY MR POSTMAN...  HEEEYAYAYA", null)]
        public string message_id;
    }
}
