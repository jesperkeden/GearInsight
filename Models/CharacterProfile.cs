using ArgentPonyWarcraftClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GearInsight.Services;

namespace GearInsight.Models
{
    public class CharacterProfile
    {
        public static async Task FetchCharacterProfileAsync(string character, string realm)
        {

            string clientId = "c2409be1a9e2473890d079632a06a265";
            string clientSecret = "XDO1WbK2BJ36OfLyo90nYVnUyGj5yHNd";
            var warcraftClient = new WarcraftClient(clientId, clientSecret, ArgentPonyWarcraftClient.Region.Europe, ArgentPonyWarcraftClient.Locale.en_GB);

            RequestResult<CharacterProfileSummary> profile = await warcraftClient.GetCharacterProfileSummaryAsync(realm, character, "profile-eu");
            RequestResult<CharacterMediaSummary> charMedia = await warcraftClient.GetCharacterMediaSummaryAsync(realm, character, "profile-eu");
            //RequestResult<CharacterMythicKeystoneSeasonDetails> mythic = await warcraftClient.GetCharacterMythicKeystoneSeasonDetailsAsync(realm, character, 1, "profile-eu");


            App.UltimateCharacter.CharacterName = Helpers.FirstLetterCapital(character);
            App.UltimateCharacter.Realm = Helpers.FirstLetterCapital(realm);

            //Activespec behövs för att köra stats
            App.UltimateCharacter.ActiveSpec = profile.Value.ActiveSpec.Name;

            App.UltimateCharacter.AchievementPoints = profile.Value.AchievementPoints;
            App.UltimateCharacter.AvgIlvl = profile.Value.AverageItemLevel;
            App.UltimateCharacter.PlayedRace = profile.Value.Race.Name;
            App.UltimateCharacter.Level = profile.Value.Level;
            if (profile.Value.Guild != null)
            {
                App.UltimateCharacter.CurrentGuild = profile.Value.Guild.Name;

            }
            App.UltimateCharacter.PlayedClass = profile.Value.CharacterClass.Name;
            App.UltimateCharacter.CharacterImage = charMedia.Value.Assets[3].Value.AbsoluteUri;

            
        }

        public static async Task<bool> CheckIfCharacterExist(string character, string realm)
        {
            bool characterExist = false;

            string clientId = "c2409be1a9e2473890d079632a06a265";
            string clientSecret = "XDO1WbK2BJ36OfLyo90nYVnUyGj5yHNd";
            var warcraftClient = new WarcraftClient(clientId, clientSecret, ArgentPonyWarcraftClient.Region.Europe, ArgentPonyWarcraftClient.Locale.en_GB);

            RequestResult<CharacterProfileSummary> profile = await warcraftClient.GetCharacterProfileSummaryAsync(realm, character, "profile-eu");

            if (profile.Success)
            {
                characterExist = true;
            }
            return characterExist;

        }
    }
}
