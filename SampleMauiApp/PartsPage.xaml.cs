using SampleMauiApp.Data;
using SampleMauiApp.ViewModels;

namespace SampleMauiApp;

public partial class PartsPage : ContentPage
{
    public PartsPage()
    {
        InitializeComponent();
        BindingContext = new PartsViewModel();
    }
}