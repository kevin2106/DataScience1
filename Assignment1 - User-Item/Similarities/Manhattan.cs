using Assignment1___User_Item.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1___User_Item.Similarities
{
    class Manhattan : ISimilarityCalc 
    {
        public double CalcSimilarity(Reviewer r1, Reviewer r2)
        {
            var articlesReviewer1 = r1.ratings.Select(x => x.id);
            var articlesReviewer2 = r2.ratings.Select(x => x.id);

            return 0.1;

        }
    }
}
