using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Globalization;

namespace TSP
{
     public class Cities : List<City>
    {
         public void CalculateCityDistances( int numberOfCloseCities )
         {
         
         }
         public void OpenCityList(string fileName)
         {
             int[] zakres  = new int[100];
             Random los = new Random();
             int x, y, miejsce;

             for (int i = 0; i < 9; i++)
             {
                 miejsce = los.Next(0, zakres.Length);
                 x = zakres[miejsce];
                 miejsce = los.Next(0, zakres.Length);
                 y = zakres[miejsce];
                 this.Add(new City(x, y));
                 Console.WriteLine(x);
                 Console.WriteLine(y); 
             }
         }   

       //this.
         //                   this.Add(new City(Convert.ToInt32(city["X"], CultureInfo.CurrentCulture), Convert.ToInt32(city["Y"], CultureInfo.CurrentCulture)));

    }
}
