using Assignment1___User_Item.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1___User_Item.Similarities
{
    class PearsonSimilarity : ISimilarityCalc
    {
        public double CalcSimilarity(Reviewer r1, Reviewer r2)
        {
            var articlesReviewer1 = r1.ratings.Select(u => u.id);
            var articlesReviewer2 = r2.ratings.Select(u => u.id);

            var x = r1.ratings.Where(r => articlesReviewer2.Contains(r.id)).ToArray();
            var y = r2.ratings.Where(r => articlesReviewer1.Contains(r.id)).ToArray();

            double a = 0;
            double b1 = 0;
            double b2 = 0;
            double c = 0;
            double d = 0;

            double length = 0;

            for (int i = 0; i < x.Length; i++)
            {
                a += x[i].rating * y[i].rating;
                b1 += x[i].rating;
                b2 += y[i].rating;

                c += Math.Pow(x[i].rating, 2);
                d += Math.Pow(y[i].rating, 2);

                length++;
            }

            return (a - (b1 * b2) / length) / (Math.Sqrt(c - (Math.Pow(b1, 2)) / length) * Math.Sqrt(d - Math.Pow(b2, 2) / length));

        }
    }
}
