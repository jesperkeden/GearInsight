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
                if (TheCharacter.UltimateCharacter.PlayedClass == "Warrior" || TheCharacter.UltimateCharacter.PlayedClass == "Death Knight" || TheCharacter.UltimateCharacter.ActiveSpec == "Retribution" || TheCharacter.UltimateCharacter.ActiveSpec == "Protection")
                {
                    TheCharacter.UltimateCharacter.Strength.Rating = stats.Value.Strength.Effective;

                    TheCharacter.UltimateCharacter.BackgroundImage = "bg_1.png";

                    TheCharacter.UltimateCharacter.MeleeCrit.Rating = Helpers.ExtractRatingFromStats(stats.Value.MeleeCrit.ToString());
                    TheCharacter.UltimateCharacter.MeleeCrit.Percent = Helpers.ExtractPercentFromStats(stats.Value.MeleeCrit.ToString());

                    TheCharacter.UltimateCharacter.MeleeHaste.Rating = Helpers.ExtractRatingFromStats(stats.Value.MeleeHaste.ToString());
                    TheCharacter.UltimateCharacter.MeleeHaste.Percent = Helpers.ExtractPercentFromStats(stats.Value.MeleeHaste.ToString());
                }
                else if (TheCharacter.UltimateCharacter.PlayedClass == "Rogue" || TheCharacter.UltimateCharacter.PlayedClass == "Demon Hunter" || (TheCharacter.UltimateCharacter.PlayedClass == "Hunter" && TheCharacter.UltimateCharacter.ActiveSpec == "Survival") || TheCharacter.UltimateCharacter.ActiveSpec == "Windwalker" || TheCharacter.UltimateCharacter.ActiveSpec == "Brewmaster" || TheCharacter.UltimateCharacter.ActiveSpec == "Enhancement" || TheCharacter.UltimateCharacter.ActiveSpec == "Feral" || TheCharacter.UltimateCharacter.ActiveSpec == "Guardian")
                {
                    TheCharacter.UltimateCharacter.Agility.Rating = stats.Value.Agility.Effective;

                    TheCharacter.UltimateCharacter.BackgroundImage = "bg_2.png";

                    TheCharacter.UltimateCharacter.MeleeCrit.Rating = Helpers.ExtractRatingFromStats(stats.Value.MeleeCrit.ToString());
                    TheCharacter.UltimateCharacter.MeleeCrit.Percent = Helpers.ExtractPercentFromStats(stats.Value.MeleeCrit.ToString());

                    TheCharacter.UltimateCharacter.MeleeHaste.Rating = Helpers.ExtractRatingFromStats(stats.Value.MeleeHaste.ToString());
                    TheCharacter.UltimateCharacter.MeleeHaste.Percent = Helpers.ExtractPercentFromStats(stats.Value.MeleeHaste.ToString());
                }
                else if (TheCharacter.UltimateCharacter.PlayedClass == "Hunter")
                {
                    TheCharacter.UltimateCharacter.Agility.Rating = stats.Value.Agility.Effective;

                    TheCharacter.UltimateCharacter.BackgroundImage = "bg_3.png";

                    TheCharacter.UltimateCharacter.RangeHaste.Rating = Helpers.ExtractRatingFromStats(stats.Value.RangedHaste.ToString());
                    TheCharacter.UltimateCharacter.RangeHaste.Percent = Helpers.ExtractPercentFromStats(stats.Value.RangedHaste.ToString());

                    TheCharacter.UltimateCharacter.RangeCrit.Rating = Helpers.ExtractRatingFromStats(stats.Value.RangedCrit.ToString());
                    TheCharacter.UltimateCharacter.RangeCrit.Percent = Helpers.ExtractPercentFromStats(stats.Value.RangedCrit.ToString());

                }
                else if (TheCharacter.UltimateCharacter.PlayedClass == "Mage" || TheCharacter.UltimateCharacter.PlayedClass == "Warlock" || TheCharacter.UltimateCharacter.PlayedClass == "Priest" || TheCharacter.UltimateCharacter.PlayedClass == "Evoker" || TheCharacter.UltimateCharacter.ActiveSpec == "Mistweaver" || TheCharacter.UltimateCharacter.PlayedClass == "Shaman" || TheCharacter.UltimateCharacter.ActiveSpec == "Balance" || TheCharacter.UltimateCharacter.ActiveSpec == "Restoration" || TheCharacter.UltimateCharacter.ActiveSpec == "Holy")
                {
                    TheCharacter.UltimateCharacter.Intellect.Rating = stats.Value.Intellect.Effective;

                    TheCharacter.UltimateCharacter.BackgroundImage = "bg_3.png";

                    TheCharacter.UltimateCharacter.SpellHaste.Rating = Helpers.ExtractRatingFromStats(stats.Value.SpellHaste.ToString());
                    TheCharacter.UltimateCharacter.SpellHaste.Percent = Helpers.ExtractPercentFromStats(stats.Value.SpellHaste.ToString());

                    TheCharacter.UltimateCharacter.SpellCrit.Rating = Helpers.ExtractRatingFromStats(stats.Value.SpellCrit.ToString());
                    TheCharacter.UltimateCharacter.SpellCrit.Percent = Helpers.ExtractPercentFromStats(stats.Value.SpellCrit.ToString());

                }

                TheCharacter.UltimateCharacter.Mastery.Rating = Helpers.ExtractRatingFromStats(stats.Value.Mastery.ToString());
                TheCharacter.UltimateCharacter.Mastery.Percent = Helpers.ExtractPercentFromStats(stats.Value.Mastery.ToString());
                TheCharacter.UltimateCharacter.Versatility = stats.Value.Versatility.ToString();
                TheCharacter.UltimateCharacter.Health = stats.Value.Health.ToString();
                TheCharacter.UltimateCharacter.Power.Rating = stats.Value.Power;
            }

        }
    }
}
