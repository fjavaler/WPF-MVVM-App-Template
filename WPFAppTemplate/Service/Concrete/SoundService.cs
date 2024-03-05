using System.Media;
using WPFAppTemplate.Service.Abstract;

namespace WPFAppTemplate.Service.Concrete
{
  public class SoundService : ISoundService
  {
    /// <summary>
    /// Sound player.
    /// </summary>
    public SoundPlayer Player { get; set; } = new SoundPlayer();

    /// <inheritdoc/>
    public void PlaySound(string fileName)
    {
      using (Player)
      {
        try
        {
          Player.SoundLocation = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"../../../Audio/{fileName}");
          Player.Load();
          Player.Play();
        }
        catch (Exception)
        {
          throw;
        }
      }
    }

    /// <inheritdoc/>
    public void PlayLoopingSound(string fileName)
    {
      using (Player)
      {
        try
        {
          Player.SoundLocation = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"../../../Audio/{fileName}");
          Player.Load();
          Player.PlayLooping();
        }
        catch (Exception)
        {
          throw;
        }
      }
    }

    /// <inheritdoc/>
    public void StopSound()
    {
      using (Player)
      {
        Player.Stop();
        Player.Dispose();
      }
    }

    /// <summary>
    /// Destructor for the SoundService.
    /// </summary>
    ~SoundService()
    {
      // Dispose of the player in order to avoid memory leaks.
      Player.Stop();
      Player.Dispose();
    }
  }
}
