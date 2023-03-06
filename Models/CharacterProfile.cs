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


            TheCharacter.UltimateCharacter.CharacterName = Helpers.FirstLetterCapital(character);
            TheCharacter.UltimateCharacter.Realm = Helpers.FirstLetterCapital(realm);

            //Activespec behövs för att köra stats
            TheCharacter.UltimateCharacter.ActiveSpec = profile.Value.ActiveSpec.Name;

            TheCharacter.UltimateCharacter.AchievementPoints = profile.Value.AchievementPoints;
            TheCharacter.UltimateCharacter.AvgIlvl = profile.Value.AverageItemLevel;
            TheCharacter.UltimateCharacter.PlayedRace = profile.Value.Race.Name;
            TheCharacter.UltimateCharacter.Level = profile.Value.Level;
            TheCharacter.UltimateCharacter.CurrentGuild = profile.Value.Guild.Name;
            TheCharacter.UltimateCharacter.PlayedClass = profile.Value.CharacterClass.Name;
            TheCharacter.UltimateCharacter.CharacterImage = charMedia.Value.Assets[3].Value.AbsoluteUri;

            
        }
    }
}
