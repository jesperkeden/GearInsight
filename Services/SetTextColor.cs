namespace GearInsight.Services
{
    class SetTextColor
    {
        public static Color SetColor(string quality)
        {
            var color = new Color();
            color = Color.FromArgb("ffffff");

            if (quality == "Epic")
            {
                color = Color.FromArgb("#a335ee");
            }
            else if (quality == "Rare")
            {
                color = Color.FromArgb("#0070dd");
            }
            else if (quality == "Uncommon")
            {
                color = Color.FromArgb("#1eff00");
            }
            else if (quality == "Artifact")
            {
                color = Color.FromArgb("#e6cc80");
            }
            else if (quality == "Legendary")
            {
                color = Color.FromArgb("#ff8000");
            }
            else if (quality == "Heirloom")
            {
                color = Color.FromArgb("#afeeee");
            }

                return color;
        }

        public static Color SetClassColor()
        {
            var color = new Color();
            color = Color.FromArgb("ffffff");

            if (App.UltimateCharacter.PlayedClass == "Death Knight")
            {
                color = Color.FromArgb("#C41E3A");
            }
            if (App.UltimateCharacter.PlayedClass == "Demon Hunter")
            {
                color = Color.FromArgb("#A330C9");
            }
            if (App.UltimateCharacter.PlayedClass == "Druid")
            {
                color = Color.FromArgb("#FF7C0A");
            }
            if (App.UltimateCharacter.PlayedClass == "Evoker")
            {
                color = Color.FromArgb("#33937F");
            }
            if (App.UltimateCharacter.PlayedClass == "Hunter")
            {
                color = Color.FromArgb("#AAD372");
            }
            if (App.UltimateCharacter.PlayedClass == "Mage")
            {
                color = Color.FromArgb("#3FC7EB");
            }
            if (App.UltimateCharacter.PlayedClass == "Monk")
            {
                color = Color.FromArgb("#00FF98");
            }
            if (App.UltimateCharacter.PlayedClass == "Paladin")
            {
                color = Color.FromArgb("#F48CBA");
            }
            if (App.UltimateCharacter.PlayedClass == "Priest")
            {
                color = Color.FromArgb("#FFFFFF");
            }
            if (App.UltimateCharacter.PlayedClass == "Rogue")
            {
                color = Color.FromArgb("#FFF468");
            }
            if (App.UltimateCharacter.PlayedClass == "Shaman")
            {
                color = Color.FromArgb("#0070DD");
            }
            if (App.UltimateCharacter.PlayedClass == "Warlock")
            {
                color = Color.FromArgb("#8788EE");
            }
            if (App.UltimateCharacter.PlayedClass == "Warrior")
            {
                color = Color.FromArgb("#C69B6D");
            }

            return color;
        }
    }
}
