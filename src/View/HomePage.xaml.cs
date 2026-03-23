namespace MyGoodDiary.src.View;
public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new ViewModel.HomeViewModel(Navigation);
	}
}