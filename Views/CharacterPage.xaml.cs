using GearInsight.Models;
using GearInsight.Services;
using GearInsight.ViewModels;

namespace GearInsight.Views;

public partial class CharacterPage : ContentPage
{
    readonly CharacterPageViewModel viewModel = new();

    public CharacterPage()
	{
		InitializeComponent();
        BindingContext = viewModel;
    }

    private async void GoBackToMainPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        Task setAppereance = viewModel.SetItems();
        await setAppereance;


        // Ändrar vissa bilder och färger beroende på vilken klass man spelar

        if (App.UltimateCharacter.Faction == "Alliance")
        {
            FactionImg.Source = "logo_alliance.png";
        }

        CharacterName.TextColor = SetTextColor.SetClassColor();

        if (App.UltimateCharacter.PlayedClass == "Warrior" || App.UltimateCharacter.PlayedClass == "Death Knight" || 
            App.UltimateCharacter.ActiveSpec == "Retribution" || App.UltimateCharacter.ActiveSpec == "Protection" )
        {
            BaseLabel.Text = "Strength";
            BaseStatImg.Source = "strength.png";
            RoleImg.Source = "role_dmg.png";

            VersStat.Text = App.UltimateCharacter.VersatilityPercent + "%";
            MasteryStat.Text = Math.Round((double)App.UltimateCharacter.Mastery.Percent) + "%";
            CritStat.Text = Math.Round((double)App.UltimateCharacter.MeleeCrit.Percent).ToString() + "%";
            HasteStat.Text = Math.Round((double)App.UltimateCharacter.MeleeHaste.Percent).ToString() + "%";
            BaseStat.Text = App.UltimateCharacter.Strength.Rating.ToString();

            if (App.UltimateCharacter.PlayedClass == "Warrior")
            {
                PowerImg.Source = "rage.png";
                PowerLabel.Text = "Rage";

                if (App.UltimateCharacter.ActiveSpec == "Protection")
                {
                    RoleImg.Source = "role_tank.png";
                }
            }

            else if (App.UltimateCharacter.PlayedClass == "Death Knight")
            {
                PowerImg.Source = "runicpower.png";
                PowerLabel.Text = "Runic Power";

                if (App.UltimateCharacter.ActiveSpec == "Blood")
                {
                    RoleImg.Source = "role_tank.png";
                }
            }

            else
            {
                PowerImg.Source = "mana.png";
                PowerLabel.Text = "Mana";
            }
            
        }
        else if (App.UltimateCharacter.PlayedClass == "Rogue" || App.UltimateCharacter.PlayedClass == "Demon Hunter" || 
            App.UltimateCharacter.ActiveSpec == "Survival" || App.UltimateCharacter.ActiveSpec == "Windwalker" || 
            App.UltimateCharacter.ActiveSpec == "Brewmaster" || App.UltimateCharacter.ActiveSpec == "Feral" || 
            App.UltimateCharacter.ActiveSpec == "Enhancement" || App.UltimateCharacter.ActiveSpec == "Guardian")
        {
            BaseLabel.Text = "Agility";
            BaseStatImg.Source = "agility.png";
            RoleImg.Source = "role_dmg.png";

            VersStat.Text = App.UltimateCharacter.VersatilityPercent + "%";
            MasteryStat.Text = Math.Round((double)App.UltimateCharacter.Mastery.Percent) + "%";
            CritStat.Text = Math.Round((double)App.UltimateCharacter.MeleeCrit.Percent).ToString() + "%";
            HasteStat.Text = Math.Round((double)App.UltimateCharacter.MeleeHaste.Percent).ToString() + "%";
            BaseStat.Text = App.UltimateCharacter.Agility.Rating.ToString();

            if (App.UltimateCharacter.PlayedClass == "Rogue" || App.UltimateCharacter.ActiveSpec == "Windwalker" || 
                App.UltimateCharacter.ActiveSpec == "Brewmaster" || App.UltimateCharacter.ActiveSpec == "Feral")
            {
                PowerImg.Source = "energy.png";
                PowerLabel.Text = "Energy";

                if (App.UltimateCharacter.ActiveSpec == "Brewmaster")
                {
                    RoleImg.Source = "role_tank.png";
                }
            }

            else if (App.UltimateCharacter.PlayedClass == "Demon Hunter")
            {
                PowerImg.Source = "fury.png";
                PowerLabel.Text = "Fury";

                if (App.UltimateCharacter.ActiveSpec == "Vengeance")
                {
                    RoleImg.Source = "role_tank.png";
                    PowerLabel.Text = "Pain";
                }
            }

            else if (App.UltimateCharacter.ActiveSpec == "Survival")
            {
                PowerImg.Source = "focus.png";
                PowerLabel.Text = "Focus";
            }

            else if (App.UltimateCharacter.ActiveSpec == "Enhancement" || App.UltimateCharacter.ActiveSpec == "Guardian")
            {
                PowerImg.Source = "mana.png";
                PowerLabel.Text = "Mana";

                if (App.UltimateCharacter.ActiveSpec == "Guardian")
                {
                    RoleImg.Source = "role_tank.png";
                }
            }
        }

        else if (App.UltimateCharacter.PlayedClass == "Hunter")
        {
            BaseLabel.Text = "Agility";
            BaseStatImg.Source = "agility.png";
            PowerImg.Source = "focus.png";
            PowerLabel.Text = "Focus";
            RoleImg.Source = "role_dmg.png";

            VersStat.Text = App.UltimateCharacter.VersatilityPercent + "%";
            MasteryStat.Text = Math.Round((double)App.UltimateCharacter.Mastery.Percent) + "%";
            CritStat.Text = Math.Round((double)App.UltimateCharacter.RangeCrit.Percent).ToString() + "%";
            HasteStat.Text = Math.Round((double)App.UltimateCharacter.RangeHaste.Percent).ToString() + "%";
            BaseStat.Text = App.UltimateCharacter.Agility.Rating.ToString();
        }

        else
        {
            BaseLabel.Text = "Intellect";
            BaseStatImg.Source = "intellect.png";
            PowerImg.Source = "mana.png";
            PowerLabel.Text = "Mana";
            RoleImg.Source = "role_dmg.png";

            VersStat.Text = App.UltimateCharacter.VersatilityPercent + "%";
            MasteryStat.Text = Math.Round((double)App.UltimateCharacter.Mastery.Percent) + "%";
            CritStat.Text = Math.Round((double)App.UltimateCharacter.SpellCrit.Percent).ToString() + "%";
            HasteStat.Text = Math.Round((double)App.UltimateCharacter.SpellHaste.Percent).ToString() + "%";
            BaseStat.Text = App.UltimateCharacter.Intellect.Rating.ToString();

            if (App.UltimateCharacter.ActiveSpec == "Holy" || App.UltimateCharacter.ActiveSpec == "Restoration" || 
                App.UltimateCharacter.ActiveSpec == "Discipline" || App.UltimateCharacter.ActiveSpec == "Preservation" || App.UltimateCharacter.ActiveSpec == "Mistweaver")
            {
                RoleImg.Source = "role_healer.png";
            }
        }     
    }

    private async void RefreshCharacterPage_Clicked(object sender, EventArgs e)
    {
        Task refresh = Mongo.RefreshData(App.UltimateCharacter.CharacterName.ToLower(), App.UltimateCharacter.Realm.ToLower());
        await refresh;
        await Navigation.PopAsync();
    }
}