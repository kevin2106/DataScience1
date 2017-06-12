using Assignment1___User_Item.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1___User_Item.Similarities
{
    interface ISimilarityCalc
    {
        double CalcSimilarity(Reviewer r1, Reviewer r2);
    }
}
