using System.Runtime.InteropServices;

namespace UnityEngine.Analytics
{
    [StandardEventName("game_start", "Progression", "Time to game!")]
    [StructLayout(LayoutKind.Sequential, Size = 1)]
    public struct GameStart
    {
    }
}
