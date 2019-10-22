namespace UnityEngine.Analytics
{
    [StandardEventName("level_up", "Progression", "OMG I'M GOINNNANNA A LEVELL UP!")]
    public struct LevelUp
    {
        [RequiredParameter("new_level_name", "WHAT IS MY NEW POWER, BITCHES?", "level")]
        public string name;
        [RequiredParameter("new_level_index", "You're only level 2, calm down.  Now you can kill mangy wolves.", "level")]
        public int index;
    }
}
