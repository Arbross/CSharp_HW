using System;

namespace Employee_.NET_Core_HW
{
    class Program
    {
        static void Main()
        {
            Departament d = new Departament();
            d.AddEmployee("Vasia", "Vasilovich", 12);
            d.AddEmployee("Anton", "Petrovich", 1200);
            d.RemoveEmployee("Vasia", "Vasilovich", 12);
            // d.AddEmployee("Nazar", "Kartinovich", 25000);
        }
    }
}
