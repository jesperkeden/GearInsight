using ArgentPonyWarcraftClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearInsight.Facade.Components
{
    internal class ValidationService : IValidationService
    {
        public async Task<bool> IsValidCharacter(string character, string realm)
        {
            bool characterExist = false;

            string clientId = "c2409be1a9e2473890d079632a06a265";
            string clientSecret = "XDO1WbK2BJ36OfLyo90nYVnUyGj5yHNd";
            var warcraftClient = new WarcraftClient(clientId, clientSecret, ArgentPonyWarcraftClient.Region.Europe, ArgentPonyWarcraftClient.Locale.en_GB);

            RequestResult<CharacterProfileSummary> profile = await warcraftClient.GetCharacterProfileSummaryAsync(realm.ToLower(), character.ToLower(), "profile-eu");

            if (profile.Success)
            {
                characterExist = true;
            }
            return characterExist;

        }
    }
}
