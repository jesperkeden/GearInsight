namespace GearInsight.Facade.Contracts
{
    internal interface IFindCharacterFacade
    {
        Task<bool> ValidCharacter(string characterName, string realm);
    }
}
