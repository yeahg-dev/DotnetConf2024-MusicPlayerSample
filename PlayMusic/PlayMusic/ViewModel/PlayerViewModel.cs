using System;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Uno;

namespace PlayMusic.ViewModel;

public class PlayerViewModel : ObservableObject
{
    private string _title = "Antifreeze";
    private string _artist = "백예린";
    private string _albumName = "Our Love is Great";
    private string _albumCover = "ms-appx:///PlayMusic/Assets/album_cover.jpeg";
    private bool _isPlaying = false;
    private IPlayer _player;

    public string Title 
    {
        get => _title;
        set => SetProperty(ref _title, value);
    }

    public string Artist    
    {
        get => _artist;
        set => SetProperty(ref _artist, value);
    }

    public string AlbumName 
    {
        get => _albumName;
        set => SetProperty(ref _albumName, value);
    }

    public string AlbumCover 
    {
        get => _albumCover;
        set => SetProperty(ref _albumName, value);
    }

    public bool IsPlaying   
    {
        get => _isPlaying;
        set => SetProperty(ref _isPlaying, value);
    }

    public PlayerViewModel(IPlayer player)
    {
    _player = player;
    }
    
    public ICommand PlayCommand => new RelayCommand(Play);


    private void Play()
    {
        if (IsPlaying)
            _player.Pause();
        else
            _player.Play();
        IsPlaying = !IsPlaying;
    }
}
