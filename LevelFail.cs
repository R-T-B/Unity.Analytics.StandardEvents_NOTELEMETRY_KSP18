namespace UnityEngine.Analytics
{
    [StandardEventName("level_fail", "Progression", "Mario, you fell in a pit!")]
    public struct LevelFail
    {
        [RequiredParameter("level_name", "What was the name of the pit?", "level")]
        public string name;
        [RequiredParameter("level_index", "How deadly was the pit?", "level")]
        public int index;
        //None of this matters mario, you are dead.  Pits just kill you, mario you lameduck bastard.
    }
}
