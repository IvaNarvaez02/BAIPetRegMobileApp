using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.Maui.Controls;
using BAIPetRegMobileApp.ViewModels;

namespace BAIPetRegMobileApp.Views;

public partial class PetRegisterPage : ContentPage
{
    private PetRegisterViewModel viewModel;
    public PetRegisterPage()
    {
        InitializeComponent();
        viewModel = new PetRegisterViewModel();
        BindingContext = viewModel;

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

        List<string> listRegion = new List<string>()
        {
            "Region001",
            "Region002",
            "Region003"
        };
        regionList.ItemsSource = listRegion;

        List<string> listProvince = new List<string>()
        {
            "Province001",
            "Province002",
            "Province003"
        };
        provinceList.ItemsSource = listProvince;

        List<string> listMunicipality = new List<string>()
        {
            "Municipality001",
            "Municipality002",
            "Municipality003"
        };
        municipalityList.ItemsSource = listMunicipality;

        List<string> listOwnerSex = new List<string>()
        {
            "Male",
            "Female"
        };
        ownerSexList.ItemsSource = listOwnerSex;

    }

    private bool IsAlphanumeric(string str)
    {
        return Regex.IsMatch(str, "^[a-zA-Z0-9]+$");
    }

    private string GetPetName()
    {
        if (IsAlphanumeric(EntryPetName.Text))
        {
            return EntryPetName.Text;
        }
        else
        {
            return null;
        }
    }

    private string GetSelectedOwnership()
    {
        if (ownershipList.SelectedIndex != -1)
        {
            return ownershipList.Items[ownershipList.SelectedIndex];
        }
        return null;
    }

    private string GetSelectedSpecies()
    {
        if (speciesList.SelectedIndex != -1)
        {
            return speciesList.Items[speciesList.SelectedIndex];
        }
        return null;
    }

    private string GetSelectedBreed()
    {
        if (breedList.SelectedIndex != -1)
        {
            return breedList.Items[breedList.SelectedIndex];
        }
        return null;
    }

    private string GetFormattedDate()
    {
        DateTime selectedDate = datePicker.Date;
        string formattedDate = selectedDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

        return formattedDate;
    }

    private string GetSelectedSex()
    {
        if (sexList.SelectedIndex != -1)
        {
            return sexList.Items[sexList.SelectedIndex];
        }
        return null;
    }

    private int GetPetAge()
    {
        if (int.TryParse(EntryPetAge.Text, out int age))
        {
            return age;
        }
        else
        {
            // Handle the case where parsing fails (e.g., invalid input)
            return -1; // Return a sentinel value indicating an invalid age
        }
    }

    private float GetPetWeight()
    {
        if (float.TryParse(PetWeight.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float age))
        {
            return age;
        }
        else
        {
            // Handle the case where parsing fails (e.g., invalid input)
            return -1f; // Return a sentinel value indicating an invalid age
        }
    }

    private string GetAnimalColor()
    {
        return EntryAnimalColor.Text;
    }

    private string GetTagNumber()
    {
        return EntryTagNumber.Text;
    }

    private string GetPEtRegion()
    {
        if (regionList.SelectedIndex != -1)
        {
            return regionList.Items[regionList.SelectedIndex];
        }
        else
        {
            return null;
        }
    }

    private string GetPetProvince()
    {
        if (provinceList.SelectedIndex != -1)
        {
            return provinceList.Items[provinceList.SelectedIndex];
        }
        else
        {
            return null;
        }
    }

    private string GetPetMunicipality()
    {
        if (municipalityList.SelectedIndex != -1)
        {
            return municipalityList.Items[municipalityList.SelectedIndex];
        }
        else
        {
            return null;
        }
    }

    private string GetOwnerName()
    {
        return EntryOwnerFullName.Text;
    }

    private string GetOwnerSex()
    {
        if (ownerSexList.SelectedIndex != -1)
        {
            return ownerSexList.Items[ownerSexList.SelectedIndex];
        }
        else
        {
            return null;
        }
    }

    private int GetOwnerPhoneNumber()
    {
        if (int.TryParse(EntryOwnerNumber.Text, out int phoneNumber))
        {
            return phoneNumber;
        }
        else
        {
            // Handle the case where parsing fails (e.g., invalid input)
            return -1; // Return a sentinel value indicating an invalid age
        }
    }

    private string GetOwnerEmail()
    {
        return EntryOwnerEmail.Text;
    }

    private void BtnSubmit_Clicked(object sender, EventArgs e)
    {
        if (petNameValidator.IsNotValid || !viewModel.BirthDate.HasValue)
        {
            DisplayAlert("Error", "Please select a date of birth.", "OK");
        }
        else
        {
            Shell.Current.GoToAsync(nameof(FinalCheckingPage));
        }
    }
}