using GearInsight.Facade.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearInsight.Facade.ApplicationFacade
{
    internal class FindCharacterFacade : Contracts.IFindCharacterFacade
    {
        // Facade för att validera att karaktären existerar

        private readonly IValidationService _validationService;

        public FindCharacterFacade()
        {
            _validationService = new ValidationService();
        }

        public async Task<bool> ValidCharacter(string characterName, string realm)
        {
            var isValidCharacter = _validationService.IsValidCharacter(characterName, realm);
            await isValidCharacter;            
            return isValidCharacter.Result;
        }
    }
}
