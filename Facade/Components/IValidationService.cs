
namespace GearInsight.Facade.Components
{
    internal interface IValidationService
    {
        Task<bool> IsValidCharacter(string characterName, string realm);
    }
}
