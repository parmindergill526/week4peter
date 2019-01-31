using System;

namespace week4peter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

        public void LookForAstildeHere
        {

        }
    }
}
