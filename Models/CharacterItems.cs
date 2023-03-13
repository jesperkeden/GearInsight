using ArgentPonyWarcraftClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GearInsight.Services;

namespace GearInsight.Models
{
    public class CharacterItems
    {
        public static async Task FetcItemsAsync(string character, string realm)
        {
            string clientId = "c2409be1a9e2473890d079632a06a265";
            string clientSecret = "XDO1WbK2BJ36OfLyo90nYVnUyGj5yHNd";
            var warcraftClient = new WarcraftClient(clientId, clientSecret, ArgentPonyWarcraftClient.Region.Europe, ArgentPonyWarcraftClient.Locale.en_GB);

            RequestResult<CharacterEquipmentSummary> armor = await warcraftClient.GetCharacterEquipmentSummaryAsync(realm, character, "profile-eu");

            if (armor.Success)
            {
                CharacterEquipmentSummary a = armor.Value;


                for (int i = 0; i < a.EquippedItems.Length; i++)
                {
                    if (a.EquippedItems[i].Slot.Name == "Head")
                    {
                        App.UltimateCharacter.Head.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Head.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Head.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Head.Quality = a.EquippedItems[i].Quality.Name;
                        
                        RequestResult<ItemMedia> headMedia = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Head.WowheadId, "static-eu");
                        ItemMedia headIcon = headMedia.Value;

                        foreach (var headUri in headIcon.Assets)
                        {
                            App.UltimateCharacter.Head.Icon = headUri.Value.AbsoluteUri;
                        }

                    }
                    if (a.EquippedItems[i].Slot.Name == "Neck")
                    {
                        App.UltimateCharacter.Neck.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Neck.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Neck.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Neck.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> neckMedia = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Neck.WowheadId, "static-eu");
                        ItemMedia neckIcon = neckMedia.Value;
                        foreach (var neckUri in neckIcon.Assets)
                        {
                            App.UltimateCharacter.Neck.Icon = neckUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Shoulders")
                    {
                        App.UltimateCharacter.Shoulder.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Shoulder.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Shoulder.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Shoulder.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> shouldersMedia = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Shoulder.WowheadId, "static-eu");
                        ItemMedia shouldersIcon = shouldersMedia.Value;
                        foreach (var shouldersUri in shouldersIcon.Assets)
                        {
                            App.UltimateCharacter.Shoulder.Icon = shouldersUri.Value.AbsoluteUri;
                        }
                    }

                    if (a.EquippedItems[i].Slot.Name == "Shirt")
                    {
                        App.UltimateCharacter.Shirt.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Shirt.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Shirt.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Shirt.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> shirtMedia = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Shirt.WowheadId, "static-eu");
                        ItemMedia shirtIcon = shirtMedia.Value;
                        foreach (var shirtUri in shirtIcon.Assets)
                        {
                            App.UltimateCharacter.Shirt.Icon = shirtUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Chest")
                    {
                        App.UltimateCharacter.Chest.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Chest.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Chest.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Chest.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> chestMedia = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Chest.WowheadId, "static-eu");
                        ItemMedia chestIcon = chestMedia.Value;
                        foreach (var chestUri in chestIcon.Assets)
                        {
                            App.UltimateCharacter.Chest.Icon = chestUri.Value.AbsoluteUri;
                        }
                    }

                    if (a.EquippedItems[i].Slot.Name == "Waist")
                    {
                        App.UltimateCharacter.Waist.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Waist.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Waist.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Waist.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> waistMedia = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Waist.WowheadId, "static-eu");
                        ItemMedia waistIcon = waistMedia.Value;
                        foreach (var waistUri in waistIcon.Assets)
                        {
                            App.UltimateCharacter.Waist.Icon = waistUri.Value.AbsoluteUri;
                        }
                    }

                    if (a.EquippedItems[i].Slot.Name == "Legs")
                    {
                        App.UltimateCharacter.Legs.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Legs.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Legs.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Legs.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> legsMedia = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Legs.WowheadId, "static-eu");
                        ItemMedia legsIcon = legsMedia.Value;
                        foreach (var legsUri in legsIcon.Assets)
                        {
                            App.UltimateCharacter.Legs.Icon = legsUri.Value.AbsoluteUri;
                        }
                    }

                    if (a.EquippedItems[i].Slot.Name == "Feet")
                    {
                        App.UltimateCharacter.Feet.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Feet.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Feet.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Feet.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> feetMedia = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Feet.WowheadId, "static-eu");
                        ItemMedia feetIcon = feetMedia.Value;
                        foreach (var feetUri in feetIcon.Assets)
                        {
                            App.UltimateCharacter.Feet.Icon = feetUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Wrist")
                    {
                        App.UltimateCharacter.Wrist.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Wrist.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Wrist.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Wrist.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> wristMedia = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Wrist.WowheadId, "static-eu");
                        ItemMedia wristIcon = wristMedia.Value;
                        foreach (var wristUri in wristIcon.Assets)
                        {
                            App.UltimateCharacter.Wrist.Icon = wristUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Hands")
                    {
                        App.UltimateCharacter.Hands.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Hands.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Hands.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Hands.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> handsMedia = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Hands.WowheadId, "static-eu");
                        ItemMedia handsIcon = handsMedia.Value;
                        foreach (var handsUri in handsIcon.Assets)
                        {
                            App.UltimateCharacter.Hands.Icon = handsUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Ring 1")
                    {
                        App.UltimateCharacter.Ring1.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Ring1.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Ring1.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Ring1.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> ring1Media = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Ring1.WowheadId, "static-eu");
                        ItemMedia ring1Icon = ring1Media.Value;
                        foreach (var ring1Uri in ring1Icon.Assets)
                        {
                            App.UltimateCharacter.Ring1.Icon = ring1Uri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Ring 2")
                    {
                        App.UltimateCharacter.Ring2.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Ring2.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Ring2.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Ring2.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> ring2Media = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Ring2.WowheadId, "static-eu");
                        ItemMedia ring2Icon = ring2Media.Value;
                        foreach (var ring2Uri in ring2Icon.Assets)
                        {
                            App.UltimateCharacter.Ring2.Icon = ring2Uri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Trinket 1")
                    {
                        App.UltimateCharacter.Trinket1.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Trinket1.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Trinket1.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Trinket1.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> trinket1Media = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Trinket1.WowheadId, "static-eu");
                        ItemMedia trinket1Icon = trinket1Media.Value;
                        foreach (var trinket1Uri in trinket1Icon.Assets)
                        {
                            App.UltimateCharacter.Trinket1.Icon = trinket1Uri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Trinket 2")
                    {
                        App.UltimateCharacter.Trinket2.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Trinket2.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Trinket2.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Trinket2.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> trinket2Media = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Trinket2.WowheadId, "static-eu");
                        ItemMedia trinket2Icon = trinket2Media.Value;
                        foreach (var trinket2Uri in trinket2Icon.Assets)
                        {
                            App.UltimateCharacter.Trinket2.Icon = trinket2Uri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Back")
                    {
                        App.UltimateCharacter.Back.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Back.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Back.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Back.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> backMedia = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Back.WowheadId, "static-eu");
                        ItemMedia backIcon = backMedia.Value;
                        foreach (var backUri in backIcon.Assets)
                        {
                            App.UltimateCharacter.Back.Icon = backUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Main Hand")
                    {
                        App.UltimateCharacter.Mainhand.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Mainhand.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Mainhand.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Mainhand.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> mainhandMedia = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Mainhand.WowheadId, "static-eu");
                        ItemMedia mainhandIcon = mainhandMedia.Value;
                        foreach (var mainhandUri in mainhandIcon.Assets)
                        {
                            App.UltimateCharacter.Mainhand.Icon = mainhandUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Off Hand")
                    {
                        App.UltimateCharacter.Offhand.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Offhand.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Offhand.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Offhand.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> offhandMedia = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Offhand.WowheadId, "static-eu");
                        ItemMedia offhandIcon = offhandMedia.Value;
                        foreach (var offhandUri in offhandIcon.Assets)
                        {
                            App.UltimateCharacter.Offhand.Icon = offhandUri.Value.AbsoluteUri;
                        }

                    }
                    if (a.EquippedItems[i].Slot.Name == "Tabard")
                    {
                        App.UltimateCharacter.Tabard.WowheadId = a.EquippedItems[i].Media.Id;
                        App.UltimateCharacter.Tabard.ItemName = a.EquippedItems[i].Name;
                        App.UltimateCharacter.Tabard.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());
                        App.UltimateCharacter.Tabard.Quality = a.EquippedItems[i].Quality.Name;

                        RequestResult<ItemMedia> tabardMedia = await warcraftClient.GetItemMediaAsync(App.UltimateCharacter.Tabard.WowheadId, "static-eu");
                        ItemMedia tabardIcon = tabardMedia.Value;
                        foreach (var tabardUri in tabardIcon.Assets)
                        {
                            App.UltimateCharacter.Tabard.Icon = tabardUri.Value.AbsoluteUri;
                        }
                    }
                }
            }
        }
    }
}
