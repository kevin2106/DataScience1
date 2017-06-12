using Assignment1___User_Item.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1___User_Item.Similarities
{
    class Euclidian : ISimilarityCalc
    {
        public double CalcSimilarity(Reviewer r1, Reviewer r2)
        {
            double distance = 0;
            for (int i = 0; i < r1.ratings.Length; i++)
            {
                if(r1.ratings[i].rating != 0 && r2.ratings[i].rating != 0)
                {
                    distance += Math.Pow(r1.ratings[i].rating - r2.ratings[i].rating, 2);
                }
            }
            distance = Math.Sqrt(distance);
            return 1 / (1 + distance);
        }
    }
}
