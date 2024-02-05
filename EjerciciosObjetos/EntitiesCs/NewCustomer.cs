using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCs
{
    public class NewCustomer
    {
        public string Name { get; set; }
        public int Dni { get; set; }
        public DateTime BirthDay { get; set; }
        public UInt16 Age
        {
            get
            {
                int age = DateTime.Now.Year - BirthDay.Year;
                return Convert.ToUInt16(age);
            }
        }
        public string Nationality { get; set; }
        public NewCustomer()
        {
            Name = string.Empty;
        }
        public NewCustomer(LinkedList<string> nacionalidad, LinkedList<int> dni, LinkedList<DateTime> birthDay) : this()
        {
            Console.Write("DNI: ");
            Dni = int.Parse(Console.ReadLine());
            Console.Write("Fecha Nacimiento: ");
            BirthDay = DateTime.Parse(Console.ReadLine());
            Console.Write("Nacionalidad: ");
            Nationality = Console.ReadLine();
        }
    }
}
