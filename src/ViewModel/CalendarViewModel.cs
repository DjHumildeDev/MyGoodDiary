namespace MyGoodDiary.src.ViewModel;

public partial class CalendarViewModel : BaseViewModel
{
    private DateTime _fechaSeleccionada;

    public DateTime FechaSeleccionada
    {
        get => _fechaSeleccionada;
        set => SetProperty(ref _fechaSeleccionada, value);
    }

    public CalendarViewModel()
    {
        // Inicializamos con la fecha de hoy para que el calendario 
        // se abra en el mes actual automáticamente
        FechaSeleccionada = DateTime.Today;
    }
}