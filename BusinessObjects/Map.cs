using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    //singeleton pattern
    //mapoints
    public class mapPoints
    {
        public decimal x { get; set; }
        public decimal y { get; set; }
    }

    public class Map
    {
        public static  Map m;
        private static List<mapPoints> map ;//contains map points
        private Map()
        {
            
           map = new List<mapPoints>();
            
           
        }
        private void createMap(mapPoints b)
        {
            if(m==null)
            {
                m = new Map();
            }
            map.Add(b);
            
        }
        public void  Addpoints(mapPoints a)
        {
            createMap( a);
        }
    }
}
