namespace UnityEngine.Analytics
{
  [StandardEventName("game_over", "Progression", "Gameover dude!")]
  public struct GameOver
  {
    [OptionalParameter("level_index", "WUTLEVEL?")]
    public int index;
    [OptionalParameter("level_name", "Oh man, that level is sooo hard...")]
    public string name;
  }
}
