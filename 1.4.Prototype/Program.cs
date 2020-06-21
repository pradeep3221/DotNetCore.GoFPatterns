using System;

namespace _1._4.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype sample code");

            Employee contractEmp = new Employee
            {
                Id = 007,
                FirstName = "John",
                LastName = "Smith",
                Type = empType.Contractor
            };

            Employee ConvertToPerm = contractEmp.ShallowCopy();
            ConvertToPerm.Type = empType.Permanent;

            Console.WriteLine("ContractEmp\n");
            Console.WriteLine(contractEmp.Id + " " + contractEmp.FirstName + " " + contractEmp.LastName + " " + contractEmp.Type + "\n");
            Console.WriteLine("ConvertToPerm\n");
            Console.WriteLine(ConvertToPerm.Id + " " + ConvertToPerm.FirstName + " " + ConvertToPerm.LastName + " " + ConvertToPerm.Type + "\n");
            Console.ReadKey();

        }
    }
}
