using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GearInsight.Models;

namespace GearInsight.Services
{
    public class Mongo
    {

        private static async Task<IMongoCollection<Character>> FetchDatabase()
        {

            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://Jesper:hejjesper@cluster0.wbk5q6r.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase("GearInsight");
            var myCollection = database.GetCollection<Character>("Characters");

            return myCollection;
        }

        private static async Task<Guid> CheckIfCharacterExist(string name, string realm, IMongoCollection<Character> allCharacters)
        {
            Guid guid = Guid.Empty;

            var charactersInDatabase = allCharacters.AsQueryable().ToList();

            foreach (Character c in charactersInDatabase)
            {
                if (c.CharacterName.ToLower() == name.ToLower() && c.Realm.ToLower() == realm.ToLower())
                {
                    guid = c.Id;
                    break;
                }
            }
            return guid;
        }

        public static async Task CreateCharacter(string name, string realm)
        {
            
            IMongoCollection<Character> fetchCharacterList = await FetchDatabase();
            var checkIfCharacterExist = CheckIfCharacterExist(name, realm, fetchCharacterList);


            App.UltimateCharacter = new Character();
            if (await checkIfCharacterExist != Guid.Empty)
            {
                var filter = Builders<Character>.Filter.Eq(x => x.Id, await CheckIfCharacterExist(name, realm, fetchCharacterList));
                App.UltimateCharacter = await fetchCharacterList.Find(filter).FirstOrDefaultAsync();
            }
            else
            {
                Task profile = CharacterProfile.FetchCharacterProfileAsync(name, realm);
                await profile;

                Task stats = CharacterStats.FetcStatsAsync(name, realm);
                Task items = CharacterItems.FetcItemsAsync(name, realm);
                await stats;
                await items;

                await fetchCharacterList.InsertOneAsync(App.UltimateCharacter);
            }
        }

        public static async Task RefreshData(string name, string realm)
        {
            var allCharacters = FetchDatabase();
            var id = CheckIfCharacterExist(name, realm, await allCharacters);

            Task deleteCharacter = DeleteOneCharacter(await allCharacters, await id);
            await deleteCharacter;
            Task createdCharacter = CreateAfterDelete(name, realm, await allCharacters);
            await createdCharacter;
        }

        private static async Task DeleteOneCharacter(IMongoCollection<Character> myCollection, Guid id)
        {
            var character = await myCollection.DeleteOneAsync(x => x.Id == id);
        }

        private static async Task CreateAfterDelete(string name, string realm, IMongoCollection<Character> allCharacters)
        {
            Task createAfterDelete = CreateCharacter(name, realm);
            await createAfterDelete;            

        }
    }
}
