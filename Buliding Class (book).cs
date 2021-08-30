using System;

namespace Buliding_Class__book_
{
    class Program
    {
        static void Main(string[] args)
        {
            Building house = new Building();
            Building office = new Building();
            int areapp;

            house.Occupants = 2;
            house.Area = 1400;
            house.Floor = 3;
            house.Areapp = 624;
            areapp = house.Areapp;

            office.Occupants = 3;
            office.Area = 1000;
            office.Floor = 2;
            office.Areapp = 328;
            areapp = office.Areapp;

            Console.Write("House Has: \n"+
                house.Occupants+" Occupants\n"+
                house.Area+" Area\n"+
                house.Floor+" Floors\n"+
                areapp+" Area per person\n");
            Console.WriteLine();

            Console.Write("Office Has: \n" +
               office.Occupants + " Occupants\n" +
               office.Area + " Area\n" +
               office.Floor + " Floors\n" +
               areapp + " Area per person\n");
        }
    }
}
