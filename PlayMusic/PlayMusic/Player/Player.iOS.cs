#if __IOS__
using AVFoundation;
using Foundation;
using UIKit;

namespace PlayMusic;

internal class Player: IPlayer
{
    private AVAudioPlayer? _player;
    private string _musicURI = "Assets/sample_music.mp3";

    public Player()
    {
        AVAudioSession.SharedInstance().SetCategory(AVAudioSessionCategory.Playback);
        AVAudioSession.SharedInstance().SetActive(true);
        _player = AVAudioPlayer.FromUrl(NSUrl.FromFilename(_musicURI));
    }

    public void Play()
    {
        _player?.Play();
    }

    public void Pause()
    {
        _player?.Pause();
    }

    public void Dispose()
    {
        _player?.Dispose();
    }
} 
#endif
