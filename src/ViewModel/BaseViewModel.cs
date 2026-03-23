using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace MyGoodDiary.src.ViewModel;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string nombrePropiedad = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombrePropiedad));
    }

    protected bool SetProperty<T>(ref T campo, T valor, [CallerMemberName] string nombre = "")
    {
        // Si el valor no cambia → no hacemos nada
        if (EqualityComparer<T>.Default.Equals(campo, valor))
            return false;

        // Actualizamos el valor
        campo = valor;

        // Notificamos a la UI
        OnPropertyChanged(nombre);

        return true;
    }
}
