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
            // En första felhantering för att kolla om det ens finns en karaktär med detta namn på den här servern
            var characterExist = CharacterProfile.CheckIfCharacterExist(CharacterName, Realm);

            // Om hämtningen lyckas går vi vidare, annars får vi error msg
            if (await characterExist == true)
            {
                Error = "";
                Task GC = Mongo.CreateCharacter(CharacterName, Realm);
                await GC;               
                await Shell.Current.GoToAsync(nameof(CharacterPage));
            }
            else
            {
                Error = $"Character not found. Try again";
            }
            
        }
    }
}
