namespace UnityEngine.Analytics
{
    [StandardEventName("level_start", "Progression", "ITSAMEEEEE!, MARIO!")]
    public struct LevelStart
    {
        [RequiredParameter("level_name", "BUM BUMB UBM UBMUB", "level")]
        public string name;
        [RequiredParameter("level_index", "Did mario survive the turtle mutant things?  How far?", "level")]
        public int index;
    }
}
