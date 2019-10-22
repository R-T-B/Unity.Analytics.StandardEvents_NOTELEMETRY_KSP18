namespace UnityEngine.Analytics
{
    [StandardEventName("level_quit", "Progression", "OH NOS, YOU CAN'T LEAVE!")]
    public struct LevelQuit
    {
        [RequiredParameter("level_name", "Look at the cool level you were on!", "level")]
        public string name;
        [RequiredParameter("level_index", "Think about how hard it will be to get back to level x!", "level")]
        public int index;
    }
}
