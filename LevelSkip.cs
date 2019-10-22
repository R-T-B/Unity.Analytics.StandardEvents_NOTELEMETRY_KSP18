namespace UnityEngine.Analytics
{
    [StandardEventName("level_skip", "Progression", "you...  you.... levelskipper!")]
    public struct LevelSkip
    {
        [RequiredParameter("level_name", "What level did this lame duck skip?", "level")]
        public string name;
        [RequiredParameter("level_index", "How hard was it?", "level")]
        public int index;
        //Filthy Casual.
    }
}
