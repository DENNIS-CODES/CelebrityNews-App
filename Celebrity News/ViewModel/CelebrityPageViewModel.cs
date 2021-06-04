using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Celebrity_News.ViewModel
{
    public class CelebrityPageViewModel : BaseViewModel
    {
        public IList<Celebs> Celebrity { get; private set; }

        public CelebrityPageViewModel()
        {
            Celebrity = CelebData.Celebrity;
        }
    }
}
        
