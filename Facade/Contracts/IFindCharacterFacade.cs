using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearInsight.Facade.Contracts
{
    internal interface IFindCharacterFacade
    {
        Task<bool> ValidCharacter(string characterName, string realm);
    }
}
