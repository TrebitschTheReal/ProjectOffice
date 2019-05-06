using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice
{
    class Program
    {
        
        static void Main()
        {
            var office = new OfficeBox();

            


            Console.ReadKey();

        }
    }
}

/*
 Tömb mérete: 8x10

Ember(neve, beosztása, teljesítménye, bérezése)
Számítógép konfig(monitor gyártója és felbontása, processzor típusa és "ereje", memória típusa és "ereje")

Employee.cs - > konstruktorban lefuttatunk egy függvényt ami beállítja random értékekre a tulajdonságot
PC.cs ->szintén zenész

OfficeBox.cs

OfficeBox -> példányosítani egy pc és egy employee-t
*/
