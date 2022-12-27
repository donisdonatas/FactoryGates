using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryGates.Services;

namespace FactoryGates.Services
{
    public class TimeSimulation
    {
        public DateTime firstDay = DateTime.Today.AddDays(-30);
        public DateTime lastDay = DateTime.Today;
        public void RunTimeLoop()
        {
            WalkingTroughtGates go = new WalkingTroughtGates();
            for (DateTime i = firstDay; i < lastDay; i = i.AddDays(1))
            {
                for(int j = 0; j < 4; j++)
                {
                    if(i.DayOfWeek.GetHashCode() > 0 && i.DayOfWeek.GetHashCode() < 6)
                    {
                        switch(j)
                        {
                            case 0:
                                go.GoTroughtGates(i.AddHours(8));
                                break;
                            case 1:
                                go.GoTroughtGates(i.AddHours(12));
                                break;
                            case 2:
                                go.GoTroughtGates(i.AddHours(13));
                                break;
                            case 3:
                                go.GoTroughtGates(i.AddHours(17));
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}
