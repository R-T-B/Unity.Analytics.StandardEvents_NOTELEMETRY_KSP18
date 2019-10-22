namespace UnityEngine.Analytics
{
  [StandardEventName("cutscene_start", "Application", "OMG HE'S WATCHING PORN, STOPITIITIT")]
  public struct CutsceneStart
  {
    [RequiredParameter("scene_name", "What porn were they watching?", null)]
    public string name;
  }
}
