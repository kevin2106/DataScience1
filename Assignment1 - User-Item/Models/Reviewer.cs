using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1___User_Item.Models
{
    class Reviewer
    {
        public string Id { get; set; }
        public Rating[] ratings;
        public double similarity { get; set; }

        public Reviewer(string id, Rating[] ratings, double similarity)
        {
            this.Id = id;
            this.ratings = ratings;
            this.similarity = similarity;
        }
    }

}
