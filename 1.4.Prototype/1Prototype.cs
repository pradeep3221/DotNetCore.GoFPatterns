using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace _1._4.Prototype
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public empType Type { get; set; }
        //public int Age { get; set; }

        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }

        //https://stackoverflow.com/questions/129389/how-do-you-do-a-deep-copy-of-an-object-in-net
        public Employee DeepCopy()
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Position = 0;
                return (Employee)formatter.Deserialize(ms);
            }
        }
    }
    public enum empType
    {
        Permanent,
        Contractor
    }

    //public interface IPrototype
    //{
    //    public Employee ShallowCopy();
    //    public Employee DeepCopy();
    //}

    //public class EmployeePrototype : IPrototype
    //{
    //    public Employee _employee;
    //    public Employee ShallowCopy()
    //    {
    //        return (Employee)this._employee.MemberwiseClone();
    //    }

    //    public Employee DeepCopy()
    //    {
    //        Employee deepclone = new Employee(this._employee.Id, this._employee.Name, this._employee.Type, this._employee.Age);
    //        return deepclone;
    //    }
    //}

}
