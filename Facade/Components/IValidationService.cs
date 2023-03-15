using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearInsight.Facade.Components
{
    internal interface IValidationService
    {
        Task<bool> IsValidCharacter(string characterName, string realm);
    }
}
