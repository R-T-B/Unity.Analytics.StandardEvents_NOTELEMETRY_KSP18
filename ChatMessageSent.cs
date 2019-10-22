using System.Runtime.InteropServices;

namespace UnityEngine.Analytics
{
  [StandardEventName("chat_message_sent", "ISPY", "Spy time...")]
  [StructLayout(LayoutKind.Sequential, Size = 1)]
  public struct ChatMessageSent
  {
  }
}
