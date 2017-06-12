using Assignment1___User_Item.Models;
using Assignment1___User_Item.Similarities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1___User_Item
{
    class Program
    {
        public static string filePath = "../../userItem.data";

        static void Main(string[] args)
        {
            Dictionary<int, Reviewer> data = DataParser.getRatingData(filePath);
            var targetUser = data[1];

            int k = 3;

            double threshold = 0.35;
            var reviewList = data.Where(x => x.Key != 1).Select(x => x.Value).ToArray();

            var closestNeighbour = new Formulas().computeNearestNeighbour(targetUser, reviewList, k, threshold, new PearsonSimilarity());
            Console.Read();
     }
   }
}
