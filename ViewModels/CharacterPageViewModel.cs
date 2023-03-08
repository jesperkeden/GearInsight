using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GearInsight.Services;

namespace GearInsight.ViewModels
{
    public partial class CharacterPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string headName;
        [ObservableProperty]
        Color headColor;        
        [ObservableProperty]
        string neckName;
        [ObservableProperty]
        Color neckColor;
        [ObservableProperty]
        string shoulderName;
        [ObservableProperty]
        Color shoulderColor;
        [ObservableProperty]
        string chestName;
        [ObservableProperty]
        Color chestColor;
        [ObservableProperty]
        string backName;
        [ObservableProperty]
        Color backColor;
        [ObservableProperty]
        string shirtName;
        [ObservableProperty]
        Color shirtColor;
        [ObservableProperty]
        string tabardName;
        [ObservableProperty]
        Color tabardColor;
        [ObservableProperty]
        string wristName;
        [ObservableProperty]
        Color wristColor;
        [ObservableProperty]
        string handsName;
        [ObservableProperty]
        Color handsColor;
        [ObservableProperty]
        string waistName;
        [ObservableProperty]
        Color waistColor;
        [ObservableProperty]
        string legsName;
        [ObservableProperty]
        Color legsColor;
        [ObservableProperty]
        string feetName;
        [ObservableProperty]
        Color feetColor;
        [ObservableProperty]
        string ring1Name;
        [ObservableProperty]
        Color ring1Color;
        [ObservableProperty]
        string ring2Name;
        [ObservableProperty]
        Color ring2Color;
        [ObservableProperty]
        string trinket1Name;
        [ObservableProperty]
        Color trinket1Color;
        [ObservableProperty]
        string trinket2Name;
        [ObservableProperty]
        Color trinket2Color;
        [ObservableProperty]
        string mainhandName;
        [ObservableProperty]
        Color mainhandColor;
        [ObservableProperty]
        string offhandName;
        [ObservableProperty]
        Color offhandColor;
        

        public async Task SetItems()
        {
            HeadName = Helpers.CheckItemIsNull(App.UltimateCharacter.Head);
            HeadColor = SetTextColor.SetColor(App.UltimateCharacter.Head.Quality);
            NeckName = Helpers.CheckItemIsNull(App.UltimateCharacter.Neck);
            NeckColor = SetTextColor.SetColor(App.UltimateCharacter.Neck.Quality);
            ShoulderName = Helpers.CheckItemIsNull(App.UltimateCharacter.Shoulder);
            ShoulderColor = SetTextColor.SetColor(App.UltimateCharacter.Shoulder.Quality);
            ChestName = Helpers.CheckItemIsNull(App.UltimateCharacter.Chest);
            ChestColor = SetTextColor.SetColor(App.UltimateCharacter.Chest.Quality);
            BackName = Helpers.CheckItemIsNull(App.UltimateCharacter.Back);
            BackColor = SetTextColor.SetColor(App.UltimateCharacter.Back.Quality);
            ShirtName = Helpers.CheckItemIsNull(App.UltimateCharacter.Shirt);
            ShirtColor = SetTextColor.SetColor(App.UltimateCharacter.Shirt.Quality);
            TabardName = Helpers.CheckItemIsNull(App.UltimateCharacter.Tabard);
            TabardColor = SetTextColor.SetColor(App.UltimateCharacter.Tabard.Quality);
            WristName = Helpers.CheckItemIsNull(App.UltimateCharacter.Wrist);
            WristColor = SetTextColor.SetColor(App.UltimateCharacter.Wrist.Quality);
            HandsName = Helpers.CheckItemIsNull(App.UltimateCharacter.Hands);
            HandsColor = SetTextColor.SetColor(App.UltimateCharacter.Hands.Quality);
            WaistName = Helpers.CheckItemIsNull(App.UltimateCharacter.Waist);
            WaistColor = SetTextColor.SetColor(App.UltimateCharacter.Waist.Quality);
            LegsName = Helpers.CheckItemIsNull(App.UltimateCharacter.Legs);
            LegsColor = SetTextColor.SetColor(App.UltimateCharacter.Legs.Quality);
            FeetName = Helpers.CheckItemIsNull(App.UltimateCharacter.Feet);
            FeetColor = SetTextColor.SetColor(App.UltimateCharacter.Feet.Quality);
            Ring1Name = Helpers.CheckItemIsNull(App.UltimateCharacter.Ring1);
            Ring1Color = SetTextColor.SetColor(App.UltimateCharacter.Ring1.Quality);
            Ring2Name = Helpers.CheckItemIsNull(App.UltimateCharacter.Ring2);
            Ring2Color = SetTextColor.SetColor(App.UltimateCharacter.Ring2.Quality);
            Trinket1Name = Helpers.CheckItemIsNull(App.UltimateCharacter.Trinket1);
            Trinket1Color = SetTextColor.SetColor(App.UltimateCharacter.Trinket1.Quality);
            Trinket2Name = Helpers.CheckItemIsNull(App.UltimateCharacter.Trinket2);
            Trinket2Color = SetTextColor.SetColor(App.UltimateCharacter.Trinket2.Quality);
            MainhandName = Helpers.CheckItemIsNull(App.UltimateCharacter.Mainhand);
            MainhandColor = SetTextColor.SetColor(App.UltimateCharacter.Mainhand.Quality);
            OffhandName = Helpers.CheckItemIsNull(App.UltimateCharacter.Offhand);
            OffhandColor = SetTextColor.SetColor(App.UltimateCharacter.Offhand.Quality);
        }
    }
}
