using Microsoft.UI.Xaml.Data;

namespace PlayMusic.View;

public class BoolToPlayButtonImageConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        bool isPlaying = (bool)value;
        return isPlaying ? "ms-appx:///PlayMusic/Assets/Icons/pause.png" : "ms-appx:///PlayMusic/Assets/Icons/play.png";
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}