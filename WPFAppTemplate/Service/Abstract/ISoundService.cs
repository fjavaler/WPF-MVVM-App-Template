namespace WPFAppTemplate.Service.Abstract
{
  public interface ISoundService
  {
    /// <summary>
    /// Play a sound.
    /// </summary>
    /// <param name="fileName">Name of the file.</param>
    public void PlaySound(string fileName);

    /// <summary>
    /// Play a looping sound.
    /// </summary>
    /// <param name="fileName"></param>
    public void PlayLoopingSound(string fileName);

    /// <summary>
    /// Stop the sound.
    /// </summary>
    public void StopSound();
  }
}
