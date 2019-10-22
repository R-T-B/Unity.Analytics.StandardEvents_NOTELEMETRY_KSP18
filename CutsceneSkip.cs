namespace UnityEngine.Analytics
{
  [StandardEventName("cutscene_skip", "Application", "Spy on the screen?")]
  public struct CutsceneSkip
  {
    [RequiredParameter("scene_name", "What porn were they watching?", null)]
    public string name;
  }
}
