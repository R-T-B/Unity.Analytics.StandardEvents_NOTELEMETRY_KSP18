namespace UnityEngine.Analytics
{
  [StandardEventName("first_interaction", "Onboarding", "It's like snowboarding but different.")]
  public struct FirstInteraction
  {
    [OptionalParameter("action_id", "The action ID")]
    public string actionId;
  }
}
