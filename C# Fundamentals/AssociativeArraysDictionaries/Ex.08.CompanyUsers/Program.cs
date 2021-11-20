using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployeeID = new Dictionary<string, List<string>>();

            while (true)
            {
                string inputData = Console.ReadLine();

                if (inputData == "End")
                {
                    break;
                }

                string[] companyData = inputData.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string company = companyData[0];
                string employeeID = companyData[1];

                if (!companyEmployeeID.ContainsKey(company))
                {
                    companyEmployeeID.Add(company, new List<string>());
                    companyEmployeeID[company].Add(employeeID);
                }

                companyEmployeeID[company].Add(employeeID);
            }

            companyEmployeeID = companyEmployeeID.OrderBy(companyName => companyName.Key).ToDictionary(company => company.Key, employee => employee.Value);

            foreach (var kvp in companyEmployeeID)
            {
                Console.WriteLine($"{kvp.Key}");

                //foreach (string emplyeeID in kvp.Value)
                //{
                //    Console.WriteLine($"-- {emplyeeID}");
                //}

                //for (int i = 0; i < kvp.Value.Count; i++)
                //{
                //    Console.WriteLine($"-- {kvp.Value[i]}");
                //}

                List<string> uniqueEmployeesID = kvp.Value.Distinct().ToList();
                foreach (var employeeID in uniqueEmployeesID)
                {
                    Console.WriteLine($"-- {employeeID}");
                }
            }
        }
    }
}
