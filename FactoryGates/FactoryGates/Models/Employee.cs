using FactoryGates.Models;
using FactoryGates.Repositories;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using FactoryGates.Services;

namespace FactoryGates
{
    public class Employee
    {
        public int id;
        public string fullName;
        public JobTitles JobTitle;
        public int personalGatesNumber { get; set; }
        public bool isAtWork;

        public Employee(string fn, JobTitles jobTitles)
        {
            id = EmployeeList.employee.Count > 0 ? EmployeeList.employee.Last().id + 1 : 1;
            fullName = fn;
            JobTitle = jobTitles;
            personalGatesNumber = RandomNumber.GetRandom(1, GatesList.factoryGate.Count + 1);
            isAtWork = false;
        }
    }
}
