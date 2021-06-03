using System;
using System.Collections.Generic;
using System.Text;

namespace Celebrity_News.models
{
    public class Celebs
    {//using getter and setters
        public string Id { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public bool selected { get; set; }
    
    }
}

