namespace UnityEngine.Analytics
{
  [StandardEventName("achievement_step", "Engagement", "Send this event when a requirement or step toward completing a multi-part achievement is complete.")]
  public struct AchievementStep
  {
    [RequiredParameter("step_index", "index", null)]
    public int stepIndex;
    [RequiredParameter("achievement_id", "An id?.", null)]
    public string achievementId;
  }
}
