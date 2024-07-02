using SQLite;

namespace BAIPetRegMobileApp.Views;

public partial class PetRegisterPage : ContentPage
{
 



    public PetRegisterPage()
    {
        InitializeComponent();

        List<string> listOwnership = new List<string>()
        {
            "Ownership001",
            "Ownership002",
            "Ownership003"
        };
        ownershipList.ItemsSource = listOwnership;

        List<string> listSpecies = new List<string>()
        {
            "Species001",
            "Species002",
            "Species003"
        };
        speciesList.ItemsSource = listSpecies;

        List<string> listBreed = new List<string>()
        {
            "Breed001",
            "Breed002",
            "Breed003"
        };
        breedList.ItemsSource = listBreed;

        List<string> listSex = new List<string>()
        {
            "Male",
            "Female"
        };
        sexList.ItemsSource = listSex;

    }

   

    //private void Picker_Focused(object sender, FocusEventArgs e)
    //{

    //}

    private void BtnSubmit_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(FinalCheckingPage));
    }


  
}
