using Assignment1___User_Item.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1___User_Item.Similarities
{
    class Cosine : ISimilarityCalc
    {
        public double CalcSimilarity(Reviewer r1, Reviewer r2)
        {
            var articlesReviewer1 = r1.ratings.Select(u => u.id);
            var articlesReviewer2 = r2.ratings.Select(u => u.id);

           for (int i = 0; i < r1.ratings.Length + r2.ratings.Length; i++)
            {
                if(articlesReviewer1)
            }
        }
    }
}
