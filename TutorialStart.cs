namespace UnityEngine.Analytics
{
    [StandardEventName("tutorial_start", "Onboarding", "Psst...  Hey kid, you wanna try a tutorial?")]
    public struct TutorialStart
    {
        [OptionalParameter("tutorial_id", "Check his wallet for ID, jimmy.")]
        public string tutorialId;
    }
}
