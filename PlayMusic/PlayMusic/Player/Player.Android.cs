#if __ANDROID__
using Android.Content.Res;
using Android.Media;
using Java.IO;

namespace PlayMusic;

internal class Player : IPlayer
{
    private MediaPlayer _player;

    public Player()
    {
        _player = new MediaPlayer();
        AssetFileDescriptor fd = Android.App.Application.Context.Assets.OpenFd("sample_music.mp3");
        _player.SetDataSource(fd);
        _player.Prepare();
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