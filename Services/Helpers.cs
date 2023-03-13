using GearInsight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GearInsight.Services
{
    public class Helpers
    {
        public static string ExtractValue(string input)
        {
            string pattern = @"\bValue\s*=\s*(\d+)\b";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            if (match.Success)
            {
                return match.Groups[1].Value;
            }

            else
            {
                return null;
            }
        }
        public static string FirstLetterCapital(string name)
        {
            var value = name.Substring(0, 1);
            value = value.ToUpper();
            value = value + name.Substring(1, name.Length - 1);

            return value;
        }
        public static int ExtractRatingFromStats(string input)
        {
            string pattern = @"\bRating\s*=\s*(\d+)";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            if (match.Success)
            {
                return int.Parse(match.Groups[1].Value);
            }

            else
            {
                return 0;
            }
        }

        public static double? ExtractPercentFromStats(string input)
        {
            string pattern = @"\bValue\s*=\s*(\d+(?:,\d{3})*(?:\.\d+)?)";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            if (match.Success)
            {
                return double.Parse(match.Groups[1].Value); //.Replace(",", "")
            }

            else
            {
                return null;
            }
        }

        public static string CheckItemIsNull(OurItem item)
        {
            string itemName = "";

            if (item.ILevel != null)
            {
                itemName = item.ItemName;
            }

            return itemName;
        }

    }
}
