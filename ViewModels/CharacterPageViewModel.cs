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
            HeadBorderColor = SetTextColor.SetColor(App.UltimateCharacter.Head.Quality);            
        }
    }
}
