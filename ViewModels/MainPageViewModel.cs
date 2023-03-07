using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GearInsight.Models;
using GearInsight.Services;
using GearInsight.Views;
using MongoDB.Driver;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Maui.Core.Views;
using CommunityToolkit.Maui.Core.Handlers;

namespace GearInsight.ViewModels
{

    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string characterName;
        [ObservableProperty]
        string realm;
        [ObservableProperty]
        string error;

        [RelayCommand]
        public async Task GetCharacterAsync()
        {
            var characterExist = CharacterProfile.CheckIfCharacterExist(CharacterName, Realm);
            if (await characterExist == true)
            {
                Error = "";
                Task GC = Mongo.CreateCharacter(CharacterName, Realm);
                await GC;
                //var page = new CharacterPage();
                //page.BindingContext = TheCharacter.UltimateCharacter;
                await Shell.Current.GoToAsync(nameof(CharacterPage));
            }
            else
            {
                Error = $"Character not found. Try again";
            }
            
        }
    }
}
