using ArgentPonyWarcraftClient;
using System;
using System.Collections.Generic;
using GearInsight.Services;

namespace GearInsight.Models
{
    public class CharacterProfile
    {
        // Metod för att hämta karaktär-profilen som behövs längre fram
        public static async Task FetchCharacterProfileAsync(string character, string realm)
        {
            character = character.ToLower();
            realm = realm.ToLower();
            string clientId = "c2409be1a9e2473890d079632a06a265";
            string clientSecret = "XDO1WbK2BJ36OfLyo90nYVnUyGj5yHNd";
            var warcraftClient = new WarcraftClient(clientId, clientSecret, ArgentPonyWarcraftClient.Region.Europe, ArgentPonyWarcraftClient.Locale.en_GB);

            RequestResult<CharacterProfileSummary> profile = await warcraftClient.GetCharacterProfileSummaryAsync(realm, character, "profile-eu");
            RequestResult<CharacterMediaSummary> charMedia = await warcraftClient.GetCharacterMediaSummaryAsync(realm, character, "profile-eu");

            App.UltimateCharacter.CharacterName = Helpers.FirstLetterCapital(character);
            App.UltimateCharacter.Realm = Helpers.FirstLetterCapital(realm);

            // Activespec behövs för att köra stats (bestämmer vilka stats som hämtas).
            App.UltimateCharacter.ActiveSpec = profile.Value.ActiveSpec.Name;
            App.UltimateCharacter.Faction = profile.Value.Faction.Name;
            App.UltimateCharacter.LastLogin = profile.Value.LastLoginTimestamp;
            App.UltimateCharacter.AchievementPoints = profile.Value.AchievementPoints;
            App.UltimateCharacter.AvgIlvl = profile.Value.EquippedItemLevel;
            App.UltimateCharacter.PlayedRace = profile.Value.Race.Name;
            App.UltimateCharacter.Level = profile.Value.Level;
            App.UltimateCharacter.PlayedClass = profile.Value.CharacterClass.Name;

            if (profile.Value.Guild != null)
            {
                App.UltimateCharacter.CurrentGuild = profile.Value.Guild.Name;
            }

            App.UltimateCharacter.CharacterImage = charMedia.Value.Assets[3].Value.AbsoluteUri;       
        }

        
    }
}
