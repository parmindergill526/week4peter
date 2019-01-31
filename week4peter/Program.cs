using System;

namespace week4peter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Countryside Ontario = new Countryside();
            //Ontario.run();
            LearningExample L = new LearningExample();
            L.run();
        }
    }

    class LearningExample
    {
        public void run()
        {
            Village Toronto;
            Village a;
            Village b;
            Toronto = new Village();
            a = Toronto;

            Toronto = new Village();
            b = Toronto;

            if (a == b)
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("different obj ref");
            }
        }
    }
    class Village
    {
        public static int numberOfVillages = 0;
        public Village nextVillage;
        public Village previousVillage;
        public string VillageName;
        public bool isAstrildeHere = false;

        public Village()
        {
            Village.numberOfVillages++;
        }
    }
    class Countryside
    {
        public Village maple;
        public Village Toronto;
        public Village Ajax;
        public Village Head;
        public Village Tail;
        public Village Temp;
        public Village Current;

        public void run()
        {
            this.MapInitializer();
            this.LookForAstrilde();
        }

        public void MapInitializer()
        {
            maple = new Village();
            maple.VillageName = "Maple";
            maple.previousVillage = null;
            maple.nextVillage = Toronto;
            Toronto = new Village();
            Toronto.nextVillage = Ajax;
            Ajax = new Village();
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.previousVillage = Toronto;
            Ajax.isAstrildeHere = true;


        }

        public void LookForAstrilde()
        {
            Current = maple;
            if (Current.isAstrildeHere)
            {
                Console.WriteLine("Found astrilde");
                return;
            }
            else
            {
                Current = Current.nextVillage;
            }
        }
    }
}
