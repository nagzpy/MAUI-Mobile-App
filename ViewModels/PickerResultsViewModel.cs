using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    
    [QueryProperty(nameof(PickerSelection), "car")]
    [QueryProperty(nameof(RawImagePath), "image")]

    [QueryProperty(nameof(PickerSelection), "actorName")]
    [QueryProperty(nameof(RawImagePath), "actorImage")]
    public partial class PickerResultsViewModel : ObservableObject
    {
        
private string _pickerSelection;
    public string PickerSelection
    {
        get => _pickerSelection;
        // Shell navigation URL-encodes query parameters (spaces become %20, etc.)
        // UnescapeDataString converts the encoded value back into a usable filename
        set => SetProperty(ref _pickerSelection, Uri.UnescapeDataString(value ?? string.Empty));
    }
        
// Raw string path from ?actorImage=… OR ?image=…
private string _rawImagePath;
public string RawImagePath
{
    get => _rawImagePath;
    set
    {
        if (SetProperty(ref _rawImagePath, value))
        {
            // Whenever the raw path changes, convert it into an ImageSource
            if (!string.IsNullOrWhiteSpace(value))
            {
                // Shell navigation URL-encodes query parameters (spaces become %20, etc.)
                // UnescapeDataString converts the encoded value back into a usable filename
                var file = Uri.UnescapeDataString(value);
                ImageSrc = ImageSource.FromFile(file);
            }
            else
            {
                ImageSrc = null;
            }
        }
    }
}
        
// The real ImageSource your XAML binds against
private ImageSource _imageSrc;

public ImageSource ImageSrc
{
    get => _imageSrc;
    private set => SetProperty(ref _imageSrc, value);
}

    }
}
