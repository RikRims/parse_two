using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parse_three
{
    public class Rootobject
    {
        public Promo[] promos { get; set; }
        public int NavPageNomer { get; set; }
        public int flats_cnt { get; set; }
        public Flat[] flats { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public string total { get; set; }
        public int NavPageCount { get; set; }
        public Ranges ranges { get; set; }
    }

    public class Ranges
    {
        public int[] area { get; set; }
        public int[] price { get; set; }
        public string[] floor { get; set; }
    }

    public class Promo
    {
        public string order { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string text { get; set; }
    }

    public class Flat
    {
        public int id { get; set; }
        public string url { get; set; }
        public string pic { get; set; }
        public int num { get; set; }
        public string special { get; set; }
        public string section { get; set; }
        public string bld { get; set; }
        public int floor { get; set; }
        public int rooms { get; set; }
        public int area { get; set; }
        public int furnish { get; set; }
        public int finish_pred { get; set; }
        public double price { get; set; }
        public string oldPrice { get; set; }
    }
}
