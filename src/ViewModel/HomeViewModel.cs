using System.Windows.Input;


namespace MyGoodDiary.src.ViewModel;

public class HomeViewModel : BaseViewModel
{
    private INavigation _navigation;
    public ICommand AbrirCommand { get; }

    public HomeViewModel(INavigation navigation)
    {
        _navigation = navigation;

        AbrirCommand = new Command(async () =>
        {
            await _navigation.PushAsync(new View.CalendarPage());
        });
    }
}
