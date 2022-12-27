 using FactoryGates.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGates.Models
{
    public class GateEvent
    {
        public int id;
        public string FullName;
        public int gatesNumber;
        public int gatesSecurityLevel;
        public DateTime DateAndTime;
        //public DateTime DateAndTimeIn;
        //public DateTime DateAndTimeOut;
        //public bool isAtWork;
        public bool isEntered { get; set; }

        public GateEvent()
        {
            id = GatesEventsRepositorie.gateEvent.Count > 0 ? GatesEventsRepositorie.gateEvent.Last().id + 1 : 1;
            //isEntered = false;
        }
    }
}
