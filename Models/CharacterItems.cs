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
                        TheCharacter.UltimateCharacter.Head.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Head.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Head.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> headMedia = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Head.WowheadId, "static-eu");
                        ItemMedia headIcon = headMedia.Value;

                        foreach (var headUri in headIcon.Assets)
                        {

                            TheCharacter.UltimateCharacter.Head.Icon = headUri.Value.AbsoluteUri;
                        }

                    }
                    if (a.EquippedItems[i].Slot.Name == "Neck")
                    {
                        TheCharacter.UltimateCharacter.Neck.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Neck.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Neck.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> neckMedia = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Neck.WowheadId, "static-eu");
                        ItemMedia neckIcon = neckMedia.Value;
                        foreach (var neckUri in neckIcon.Assets)
                        {

                            TheCharacter.UltimateCharacter.Neck.Icon = neckUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Shoulders")
                    {
                        TheCharacter.UltimateCharacter.Shoulder.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Shoulder.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Shoulder.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> shouldersMedia = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Shoulder.WowheadId, "static-eu");
                        ItemMedia shouldersIcon = shouldersMedia.Value;
                        foreach (var shouldersUri in shouldersIcon.Assets)
                        {

                            TheCharacter.UltimateCharacter.Shoulder.Icon = shouldersUri.Value.AbsoluteUri;
                        }
                    }

                    if (a.EquippedItems[i].Slot.Name == "Shirt")
                    {
                        TheCharacter.UltimateCharacter.Shirt.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Shirt.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Shirt.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> shirtMedia = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Shirt.WowheadId, "static-eu");
                        ItemMedia shirtIcon = shirtMedia.Value;
                        foreach (var shirtUri in shirtIcon.Assets)
                        {

                            TheCharacter.UltimateCharacter.Shirt.Icon = shirtUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Chest")
                    {
                        TheCharacter.UltimateCharacter.Chest.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Chest.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Chest.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> chestMedia = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Chest.WowheadId, "static-eu");
                        ItemMedia chestIcon = chestMedia.Value;
                        foreach (var chestUri in chestIcon.Assets)
                        {

                            TheCharacter.UltimateCharacter.Chest.Icon = chestUri.Value.AbsoluteUri;
                        }
                    }

                    if (a.EquippedItems[i].Slot.Name == "Waist")
                    {
                        TheCharacter.UltimateCharacter.Waist.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Waist.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Waist.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> waistMedia = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Waist.WowheadId, "static-eu");
                        ItemMedia waistIcon = waistMedia.Value;
                        foreach (var waistUri in waistIcon.Assets)
                        {

                            TheCharacter.UltimateCharacter.Waist.Icon = waistUri.Value.AbsoluteUri;
                        }
                    }

                    if (a.EquippedItems[i].Slot.Name == "Legs")
                    {
                        TheCharacter.UltimateCharacter.Legs.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Legs.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Legs.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> legsMedia = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Legs.WowheadId, "static-eu");
                        ItemMedia legsIcon = legsMedia.Value;
                        foreach (var legsUri in legsIcon.Assets)
                        {

                            TheCharacter.UltimateCharacter.Legs.Icon = legsUri.Value.AbsoluteUri;
                        }
                    }

                    if (a.EquippedItems[i].Slot.Name == "Feet")
                    {
                        TheCharacter.UltimateCharacter.Feet.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Feet.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Feet.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> feetMedia = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Feet.WowheadId, "static-eu");
                        ItemMedia feetIcon = feetMedia.Value;
                        foreach (var feetUri in feetIcon.Assets)
                        {

                            TheCharacter.UltimateCharacter.Feet.Icon = feetUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Wrist")
                    {
                        TheCharacter.UltimateCharacter.Wrist.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Wrist.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Wrist.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> wristMedia = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Wrist.WowheadId, "static-eu");
                        ItemMedia wristIcon = wristMedia.Value;
                        foreach (var wristUri in wristIcon.Assets)
                        {

                            TheCharacter.UltimateCharacter.Wrist.Icon = wristUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Hands")
                    {
                        TheCharacter.UltimateCharacter.Hands.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Hands.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Hands.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> handsMedia = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Hands.WowheadId, "static-eu");
                        ItemMedia handsIcon = handsMedia.Value;
                        foreach (var handsUri in handsIcon.Assets)
                        {

                            TheCharacter.UltimateCharacter.Hands.Icon = handsUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Ring 1")
                    {
                        TheCharacter.UltimateCharacter.Ring1.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Ring1.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Ring1.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> ring1Media = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Ring1.WowheadId, "static-eu");
                        ItemMedia ring1Icon = ring1Media.Value;
                        foreach (var ring1Uri in ring1Icon.Assets)
                        {

                            TheCharacter.UltimateCharacter.Ring1.Icon = ring1Uri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Ring 2")
                    {
                        TheCharacter.UltimateCharacter.Ring2.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Ring2.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Ring2.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> ring2Media = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Ring2.WowheadId, "static-eu");
                        ItemMedia ring2Icon = ring2Media.Value;
                        foreach (var ring2Uri in ring2Icon.Assets)
                        {

                            TheCharacter.UltimateCharacter.Ring2.Icon = ring2Uri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Trinket 1")
                    {
                        TheCharacter.UltimateCharacter.Trinket1.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Trinket1.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Trinket1.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> trinket1Media = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Trinket1.WowheadId, "static-eu");
                        ItemMedia trinket1Icon = trinket1Media.Value;
                        foreach (var trinket1Uri in trinket1Icon.Assets)
                        {

                            TheCharacter.UltimateCharacter.Trinket1.Icon = trinket1Uri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Trinket 2")
                    {
                        TheCharacter.UltimateCharacter.Trinket2.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Trinket2.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Trinket2.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> trinket2Media = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Trinket2.WowheadId, "static-eu");
                        ItemMedia trinket2Icon = trinket2Media.Value;
                        foreach (var trinket2Uri in trinket2Icon.Assets)
                        {

                            TheCharacter.UltimateCharacter.Trinket2.Icon = trinket2Uri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Back")
                    {
                        TheCharacter.UltimateCharacter.Back.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Back.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Back.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> backMedia = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Back.WowheadId, "static-eu");
                        ItemMedia backIcon = backMedia.Value;
                        foreach (var backUri in backIcon.Assets)
                        {

                            TheCharacter.UltimateCharacter.Back.Icon = backUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Main Hand")
                    {
                        TheCharacter.UltimateCharacter.Mainhand.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Mainhand.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Mainhand.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> mainhandMedia = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Mainhand.WowheadId, "static-eu");
                        ItemMedia mainhandIcon = mainhandMedia.Value;
                        foreach (var mainhandUri in mainhandIcon.Assets)
                        {

                            TheCharacter.UltimateCharacter.Mainhand.Icon = mainhandUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Off Hand")
                    {
                        TheCharacter.UltimateCharacter.Offhand.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Offhand.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Offhand.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> offhandMedia = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Offhand.WowheadId, "static-eu");
                        ItemMedia offhandIcon = offhandMedia.Value;
                        foreach (var offhandUri in offhandIcon.Assets)
                        {
                            TheCharacter.UltimateCharacter.Offhand.Icon = offhandUri.Value.AbsoluteUri;
                        }

                    }
                    if (a.EquippedItems[i].Slot.Name == "Tabard")
                    {
                        TheCharacter.UltimateCharacter.Tabard.WowheadId = a.EquippedItems[i].Media.Id;
                        TheCharacter.UltimateCharacter.Tabard.ItemName = a.EquippedItems[i].Name;
                        TheCharacter.UltimateCharacter.Tabard.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> tabardMedia = await warcraftClient.GetItemMediaAsync(TheCharacter.UltimateCharacter.Tabard.WowheadId, "static-eu");
                        ItemMedia tabardIcon = tabardMedia.Value;
                        foreach (var tabardUri in tabardIcon.Assets)
                        {
                            TheCharacter.UltimateCharacter.Tabard.Icon = tabardUri.Value.AbsoluteUri;
                        }
                    }
                }
            }
        }
    }
}
