using Assignment1___User_Item.Models;
using Assignment1___User_Item.Similarities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1___User_Item
{
    class Formulas
    {
        public Reviewer[] computeNearestNeighbour(Reviewer targetUser, Reviewer[] users, int maxNeighbours, double threshold, ISimilarityCalc similarityCalc)
        {
            if (users.Contains(targetUser))
            {
                throw new Exception("Target already exists in users list");
            }

            var closestNeighbour = new Reviewer[maxNeighbours];
            for (int i = 0; i < users.Length; i++)
            {
                var similarity = similarityCalc.CalcSimilarity(targetUser, users[i]);
                users[i].similarity = similarity;

                if (similarity < threshold)
                    continue;

                int closestNeighbourCheck = closestNeighbour.Count(x => x != null);
                if(closestNeighbourCheck < closestNeighbour.Length)
                {
                    var findSpot = Array.FindIndex(closestNeighbour, u => u == null);
                    closestNeighbour[findSpot] = users[i];
                } else
                {
                    double lowestSim = closestNeighbour.Min(x => x.similarity);
                    int lowestSimIndex = Array.FindIndex(closestNeighbour, z => z.similarity == lowestSim);
                    closestNeighbour[lowestSimIndex] = users[i];

                    threshold = closestNeighbour.Min(u => u.similarity);
                }
            }
            return closestNeighbour.OrderByDescending(x => x.similarity).ToArray();
        }
    }
}
