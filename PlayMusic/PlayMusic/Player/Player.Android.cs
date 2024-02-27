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
        // TODO: Player에 음악 파일을 로드하고 준비가 제대로 동작하지 않음
        // AssetFileDescriptor fd = Android.App.Application.Context.Assets.OpenFd("sample_music.mp3");
        // _player.SetDataSource(fd.FileDescriptor);
        // _player.Prepare();
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