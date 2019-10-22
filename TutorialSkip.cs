namespace UnityEngine.Analytics
{
    [StandardEventName("tutorial_skip", "Onboarding", "You CAN'T JUST SKIIIIP THE TUOTOTOROROIAL!")]
    public struct TutorialSkip
    {
        [OptionalParameter("tutorial_id", "ok, I guess you can, but you need this passcode!")]
        public string tutorialId;
    }
}
