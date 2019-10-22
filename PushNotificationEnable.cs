using System.Runtime.InteropServices;

namespace UnityEngine.Analytics
{
    [StandardEventName("push_notification_enable", "Engagement", "Can I push you bro?")]
    [StructLayout(LayoutKind.Sequential, Size = 1)]
    public struct PushNotificationEnable
    {
    }
}
