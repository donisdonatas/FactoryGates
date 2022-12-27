using FactoryGates.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGates.Services
{
    public class ChooseGates
    {
        public Random gatesNumber = new Random();
        public int getGatesNumber()
        {
            return gatesNumber.Next(GatesList.factoryGate.Count);
        }
    }
}

// Man regis šitas bus nereikalingas