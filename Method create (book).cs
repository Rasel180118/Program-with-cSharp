using System;

namespace Method_create__book_
{
    class Building
    {
        public int Floor;
        public int Occupants;
        public int Area;
        public int Areapp;

        public int AreaPerPerson()
        {
            return Areapp;
        }
    }
    class program
    { 
        static void Main(string[] args)
        {
            Building house = new Building();
            Building office = new Building();
            int areapp;

            house.Occupants = 2;
            house.Area = 1400;
            house.Floor = 4;
            house.Areapp = 400;

            office.Occupants = 4;
            office.Area = 2000;
            office.Floor = 7;
            office.Areapp = 665;
            areapp = house.AreaPerPerson();

            Console.WriteLine("House has:\n  " + 
                house.Floor + " floors\n  " +
                house.Occupants + " occupants\n  " +
                house.Area + " total area\n  " +
                areapp + " area per person");
            Console.WriteLine();

            areapp = office.AreaPerPerson();
            Console.WriteLine("Office has:\n  " +
                office.Floor + " floors\n  " +
                office.Occupants + " occupants\n  " +
                office.Area + " total area\n  " +
                areapp + " area per person");
        }
    }
}
