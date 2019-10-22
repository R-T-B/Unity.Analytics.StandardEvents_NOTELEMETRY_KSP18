namespace UnityEngine.Analytics
{
    [StandardEventName("tutorial_complete", "Onboarding", "TUTOR!")]
    public struct TutorialComplete
    {
        [OptionalParameter("tutorial_id", "Help, my tutor killed me!  He had this number on his forehead!")]
        public string tutorialId;
    }
}
