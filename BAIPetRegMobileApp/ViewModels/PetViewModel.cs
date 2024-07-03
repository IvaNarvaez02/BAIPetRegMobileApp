using System.ComponentModel;

namespace BAIPetRegMobileApp.ViewModels;

public class PetRegisterViewModel : INotifyPropertyChanged
{
    private DateTime? _birthDate;
    public DateTime? BirthDate
    {
        get => _birthDate;
        set
        {
            if (_birthDate != value)
            {
                _birthDate = value;
                OnPropertyChanged(nameof(BirthDate));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}