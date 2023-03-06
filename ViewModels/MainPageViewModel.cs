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

namespace GearInsight.ViewModels
{

    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string characterName;
        [ObservableProperty]
        string realm;

        [RelayCommand]
        public async Task GetCharacterAsync()
        {
            Task GC = Mongo.CreateCharacter(CharacterName, Realm);
            await GC;
            //var page = new CharacterPage();
            //page.BindingContext = TheCharacter.UltimateCharacter;
            await Shell.Current.GoToAsync(nameof(CharacterPage));
        }
    }
}
