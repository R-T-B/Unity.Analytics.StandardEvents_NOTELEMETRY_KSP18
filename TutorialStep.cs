namespace UnityEngine.Analytics
{
    [StandardEventName("tutorial_step", "Onboarding", "What the frick do you mean there's more parts to this shit?")]
    public struct TutorialStep
    {
        [RequiredParameter("step_index", "How many parts are there?", null)]
        public int stepIndex;
        [OptionalParameter("tutorial_id", "Why?  Why do I have to go into the bone barrow?")]
        public string tutorialId;
    }
}
