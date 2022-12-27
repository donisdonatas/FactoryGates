using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryGates.Models;
using FactoryGates.Repositories;

namespace FactoryGates.Repositories
{
    public class DefaultValues
    {
        private void AddDefaultGates()
        {
            GatesList.factoryGate.Add(new Gates(GatesSecurityLevel.Basic.GetHashCode()));
            GatesList.factoryGate.Add(new Gates(GatesSecurityLevel.Midle.GetHashCode()));
            GatesList.factoryGate.Add(new Gates(GatesSecurityLevel.High.GetHashCode()));
            GatesList.factoryGate.Add(new Gates(GatesSecurityLevel.Top.GetHashCode()));
        }

        private void AddDefaultEmployee()
        {
            EmployeeList.employee.Add(new Employee("Trystan Morrow", JobTitles.Director));
            EmployeeList.employee.Add(new Employee("Otis Frazier", JobTitles.ITspecialist));
            EmployeeList.employee.Add(new Employee("Safa Tyler", JobTitles.ITspecialist));
            EmployeeList.employee.Add(new Employee("Joe Walls", JobTitles.Manager));
            EmployeeList.employee.Add(new Employee("Summer Blair", JobTitles.Manager));
            EmployeeList.employee.Add(new Employee("Maxwell Strickland", JobTitles.Manager));
            EmployeeList.employee.Add(new Employee("Niall Stuart", JobTitles.Worker));
            EmployeeList.employee.Add(new Employee("Sophie Wilcox", JobTitles.Worker));
            EmployeeList.employee.Add(new Employee("Scarlet Osborne", JobTitles.Worker));
            EmployeeList.employee.Add(new Employee("Lydia Hardin", JobTitles.Worker));
            EmployeeList.employee.Add(new Employee("Sebastien Le", JobTitles.Worker));
        }

        public void AddDefaultValues()
        {
            AddDefaultGates();
            AddDefaultEmployee();
        }
    }
}
