#if !ANDROID && !IOS
namespace PlayMusic;

internal class Player : IPlayer
{
    public void Pause()
    {
        throw new NotImplementedException();
    }

    public void Play()
    {
        throw new NotImplementedException();
    }
}
#endif