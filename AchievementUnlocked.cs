namespace UnityEngine.Analytics
{
  [StandardEventName("achievement_unlocked", "Engagement", "Achievement get!")]
  public struct AchievementUnlocked
  {
    [RequiredParameter("achievement_id", "unique id", null)]
    public string achievementId;
  }
}
