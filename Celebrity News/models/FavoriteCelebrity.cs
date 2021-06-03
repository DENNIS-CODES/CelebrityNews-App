using System;
using System.Collections.Generic;
using System.Text;

namespace Celebs.ViewModel
{
    public class FavoriteCelebrity
    {
        public List<Celebs> Celebs { get; set; }
        public FavoriteCelebrity()
        {
            Celebs = new Celebs().GetCelebs();
        }
    }
}
