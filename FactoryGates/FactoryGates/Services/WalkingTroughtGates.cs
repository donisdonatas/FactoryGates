using FactoryGates.Models;
using FactoryGates.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGates.Services
{
    public class WalkingTroughtGates
    {
        
        public void GoTroughtGates(DateTime dateAndTime)
        {
            foreach(Employee person in EmployeeList.employee)
            {
                foreach(Gates gates in GatesList.factoryGate)
                {
                    GateEvent gateEvent = new GateEvent();
                    //List<GateEvent> gateEventsByPerson = GatesEventsRepositorie.gateEvent.Where(e => e.FullName == person.fullName).ToList();
                    int gatesToEnter = person.personalGatesNumber;
                    do
                    {
                        if(!person.isAtWork)
                        {
                            //Formuojame atėjimą
                            if(gatesToEnter >= gates.gatesSecurityLevel.GetHashCode())
                            {
                                gateEvent.FullName = person.fullName;
                                gateEvent.gatesNumber = gatesToEnter;
                                gateEvent.DateAndTime = dateAndTime;
                                gateEvent.gatesSecurityLevel = gates.gatesSecurityLevel.GetHashCode();
                                person.isAtWork = true;
                                gateEvent.isEntered = true;
                            }
                            else
                            {
                                gateEvent.FullName = person.fullName;
                                gateEvent.gatesNumber = gatesToEnter;
                                gateEvent.gatesSecurityLevel = gates.gatesSecurityLevel.GetHashCode();
                                //gateEvent.DateAndTimeIn = "";
                                //gateEvent.DateAndTimeOut = "";
                                person.isAtWork = false;
                                gatesToEnter--;
                                gateEvent.isEntered = false;
                            }
                        }
                        else
                        {
                            //Formuojame išėjimą
                            gateEvent.FullName = person.fullName;
                            gateEvent.gatesNumber = gatesToEnter;
                            gateEvent.gatesSecurityLevel = gates.gatesSecurityLevel.GetHashCode();
                            gateEvent.DateAndTime = dateAndTime;
                            person.isAtWork = false;
                            gateEvent.isEntered = true;
                        }
                        GatesEventsRepositorie.gateEvent.Add(gateEvent);
                    } while(!gateEvent.isEntered);
                    //gateEvent.isEntered = false;
                    break;
                }
            }
        }
    }
}
