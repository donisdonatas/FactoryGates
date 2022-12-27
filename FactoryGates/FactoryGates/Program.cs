using FactoryGates.Models;
using FactoryGates.Repositories;
using FactoryGates.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGates
{
    internal class Program
    {
        static void Main()
        {
            DefaultValues defaultValues = new DefaultValues();
            defaultValues.AddDefaultValues();

            TimeSimulation simulation = new TimeSimulation();
            simulation.RunTimeLoop();

            foreach (GateEvent gEvent in GatesEventsRepositorie.gateEvent)
            {
                Console.WriteLine($"{gEvent.id}. {gEvent.DateAndTime} - {gEvent.FullName} [{gEvent.gatesNumber} - {gEvent.isEntered} - {gEvent.gatesSecurityLevel}]");
            }
            Console.ReadLine();
        }
    }
}
