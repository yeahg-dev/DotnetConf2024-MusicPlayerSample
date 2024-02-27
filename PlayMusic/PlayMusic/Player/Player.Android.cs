#if __ANDROID__
using Android.Media;

namespace PlayMusic;

internal class Player : IPlayer
{
    private MediaPlayer _player;

    public Player()
    {
        _player = new MediaPlayer();
        _player.SetDataSource("../Assets/sample_music.mp3");
    }

    public void Play()
    {
        this._player.Start();
    }

    public void Pause()
    {
        this._player.Pause();
    }

    public void Dispose()
    {
        this._player.Dispose();
    }
}
#endif