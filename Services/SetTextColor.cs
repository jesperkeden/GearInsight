using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
