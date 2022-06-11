namespace noot
{

    class Wizard
    {
        public string? name;
        public string? favSpell;
        private int spellSlots;
        private float experience;

        public static int Count;

        public Wizard(string _name, string _favSpell)
        {
            name = _name;
            favSpell = _favSpell;
            spellSlots = 2;
            experience = 0f;

            Count++;
        }

        public void CastSpell()
        {
            if (spellSlots > 0)
            {
                Console.WriteLine(name + " casts " + favSpell + "!");
                spellSlots--;
                experience += 0.3f;
            }
            else
            {
                Console.WriteLine(name + " is out of spells slots.");
            }
        }

        public void Meditate()
        {
            Console.WriteLine(name + " meditates.");
            spellSlots++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            wizards();

            Console.ReadKey();
        }

        static void wizards()
        {
            Wizard wizard01 = new Wizard("Brian", "abraka dabra");
            wizard01.CastSpell();

            Wizard wizard02 = new Wizard("Joe", "boom");
            wizard02.CastSpell();

            Console.WriteLine("\nWizards count: " + Wizard.Count);
        }

    }

}
