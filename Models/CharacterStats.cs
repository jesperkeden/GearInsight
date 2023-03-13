using ArgentPonyWarcraftClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GearInsight.Services;

namespace GearInsight.Models
{
    public class CharacterStats
    {
        public static async Task FetcStatsAsync(string character, string realm)
        {
            string clientId = "c2409be1a9e2473890d079632a06a265";
            string clientSecret = "XDO1WbK2BJ36OfLyo90nYVnUyGj5yHNd";
            var warcraftClient = new WarcraftClient(clientId, clientSecret, ArgentPonyWarcraftClient.Region.Europe, ArgentPonyWarcraftClient.Locale.en_GB);


            RequestResult<CharacterStatisticsSummary> stats = await warcraftClient.GetCharacterStatisticsSummaryAsync(realm, character, "profile-eu");

            if (stats.Success)
            {
                App.UltimateCharacter.Mastery.Rating = Helpers.ExtractRatingFromStats(stats.Value.Mastery.ToString());
                App.UltimateCharacter.Mastery.Percent = Helpers.ExtractPercentFromStats(stats.Value.Mastery.ToString());
                App.UltimateCharacter.Versatility = stats.Value.Versatility.ToString();
                App.UltimateCharacter.Health = stats.Value.Health.ToString();
                App.UltimateCharacter.Stamina = stats.Value.Stamina.Effective.ToString();
                App.UltimateCharacter.Power.Rating = stats.Value.Power;

                if (App.UltimateCharacter.PlayedClass == "Warrior" || App.UltimateCharacter.PlayedClass == "Death Knight" || 
                    App.UltimateCharacter.ActiveSpec == "Retribution" || App.UltimateCharacter.ActiveSpec == "Protection")
                {
                    App.UltimateCharacter.Strength.Rating = stats.Value.Strength.Effective;
                    App.UltimateCharacter.MeleeCrit.Rating = Helpers.ExtractRatingFromStats(stats.Value.MeleeCrit.ToString());
                    App.UltimateCharacter.MeleeCrit.Percent = Helpers.ExtractPercentFromStats(stats.Value.MeleeCrit.ToString());
                    App.UltimateCharacter.MeleeHaste.Rating = Helpers.ExtractRatingFromStats(stats.Value.MeleeHaste.ToString());
                    App.UltimateCharacter.MeleeHaste.Percent = Helpers.ExtractPercentFromStats(stats.Value.MeleeHaste.ToString());
                    App.UltimateCharacter.VersatilityPercent = Math.Round(stats.Value.Versatility / 200).ToString();
                    App.UltimateCharacter.BackgroundImage = "bg_1.png"; 
                }

                else if (App.UltimateCharacter.PlayedClass == "Rogue" || App.UltimateCharacter.PlayedClass == "Demon Hunter" || 
                    (App.UltimateCharacter.PlayedClass == "Hunter" && App.UltimateCharacter.ActiveSpec == "Survival") || 
                    App.UltimateCharacter.ActiveSpec == "Windwalker" || App.UltimateCharacter.ActiveSpec == "Brewmaster" || 
                    App.UltimateCharacter.ActiveSpec == "Enhancement" || App.UltimateCharacter.ActiveSpec == "Feral" || App.UltimateCharacter.ActiveSpec == "Guardian")
                {
                    App.UltimateCharacter.Agility.Rating = stats.Value.Agility.Effective;
                    App.UltimateCharacter.MeleeCrit.Rating = Helpers.ExtractRatingFromStats(stats.Value.MeleeCrit.ToString());
                    App.UltimateCharacter.MeleeCrit.Percent = Helpers.ExtractPercentFromStats(stats.Value.MeleeCrit.ToString());
                    App.UltimateCharacter.MeleeHaste.Rating = Helpers.ExtractRatingFromStats(stats.Value.MeleeHaste.ToString());
                    App.UltimateCharacter.MeleeHaste.Percent = Helpers.ExtractPercentFromStats(stats.Value.MeleeHaste.ToString());
                    App.UltimateCharacter.VersatilityPercent = Math.Round(stats.Value.Versatility / 200).ToString();
                    App.UltimateCharacter.BackgroundImage = "bg_2.png";
                }

                else if (App.UltimateCharacter.PlayedClass == "Hunter")
                {
                    App.UltimateCharacter.Agility.Rating = stats.Value.Agility.Effective;
                    App.UltimateCharacter.RangeHaste.Rating = Helpers.ExtractRatingFromStats(stats.Value.RangedHaste.ToString());
                    App.UltimateCharacter.RangeHaste.Percent = Helpers.ExtractPercentFromStats(stats.Value.RangedHaste.ToString());
                    App.UltimateCharacter.RangeCrit.Rating = Helpers.ExtractRatingFromStats(stats.Value.RangedCrit.ToString());
                    App.UltimateCharacter.RangeCrit.Percent = Helpers.ExtractPercentFromStats(stats.Value.RangedCrit.ToString());
                    App.UltimateCharacter.VersatilityPercent = Math.Round(stats.Value.Versatility / 200).ToString();
                    App.UltimateCharacter.BackgroundImage = "bg_3.png";
                }

                else if (App.UltimateCharacter.PlayedClass == "Mage" || App.UltimateCharacter.PlayedClass == "Warlock" || 
                    App.UltimateCharacter.PlayedClass == "Priest" || App.UltimateCharacter.PlayedClass == "Evoker" || 
                    App.UltimateCharacter.ActiveSpec == "Mistweaver" || App.UltimateCharacter.PlayedClass == "Shaman" || 
                    App.UltimateCharacter.ActiveSpec == "Balance" || App.UltimateCharacter.PlayedClass == "Restoration" || App.UltimateCharacter.PlayedClass == "Holy")
                {
                    App.UltimateCharacter.Intellect.Rating = stats.Value.Intellect.Effective;
                    App.UltimateCharacter.SpellHaste.Rating = Helpers.ExtractRatingFromStats(stats.Value.SpellHaste.ToString());
                    App.UltimateCharacter.SpellHaste.Percent = Helpers.ExtractPercentFromStats(stats.Value.SpellHaste.ToString());
                    App.UltimateCharacter.SpellCrit.Rating = Helpers.ExtractRatingFromStats(stats.Value.SpellCrit.ToString());
                    App.UltimateCharacter.SpellCrit.Percent = Helpers.ExtractPercentFromStats(stats.Value.SpellCrit.ToString());
                    App.UltimateCharacter.VersatilityPercent = Math.Round(stats.Value.Versatility / 200).ToString();
                    App.UltimateCharacter.BackgroundImage = "bg_3.png";
                }                             
            }
        }     
    }
}
