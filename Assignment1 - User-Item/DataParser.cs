using Assignment1___User_Item.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1___User_Item
{
    class DataParser
    {
        public static List<int> itemIds = new List<int>();
        public static Dictionary<int, Reviewer> getRatingData(string file)
        {

            Dictionary<int, List<Rating>> tempData = new Dictionary<int, List<Rating>>();

            using (var fs = File.OpenRead(file))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] values = line.Split(',');

                        Rating rating = new Rating()
                        {
                            id = int.Parse(values[1]),
                            rating = double.Parse(values[2], CultureInfo.InvariantCulture)
                        };

                        if (tempData.ContainsKey(int.Parse(values[0])))
                        {
                            tempData[int.Parse(values[0])].Add(rating);
                        }
                        else
                        {
                            List<Rating> ratings = new List<Rating>();
                            ratings.Add(rating);
                            tempData.Add(int.Parse(values[0]), ratings);
                        }

                        if (!itemIds.Contains(int.Parse(values[1])))
                            itemIds.Add(int.Parse(values[1]));
                    }
                }
            };

            Dictionary<int, Reviewer> reviewerRating = new Dictionary<int, Reviewer>();
            foreach (var rating in tempData)
            {
                reviewerRating.Add(rating.Key, new Reviewer(rating.Key.ToString(), rating.Value.OrderBy(x => x.id).ToArray()));
            }
                
             return reviewerRating;
        }
    }
}
