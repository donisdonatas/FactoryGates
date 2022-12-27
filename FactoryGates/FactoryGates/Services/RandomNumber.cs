using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGates.Services
{
    public static class RandomNumber
    {
        private static Random rnd = new Random();
        //private static int min;
        //private static int max;
        public static int GetRandom(int min, int max)
        {
            return rnd.Next(min, max);
        }
    }
}
