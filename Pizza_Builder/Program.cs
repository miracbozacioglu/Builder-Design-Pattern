namespace Pizza_Builder
{
    public class Pizza
    {
        public string Boyut { get; set; }
        public string HamurTipi { get; set; }
        public bool Peynir { get; set; }
        public bool Zeytin { get; set; }

        public bool Mantar { get; set; }
    }

    public class PizzaBuilder
    {
        private Pizza pizza;

        public PizzaBuilder()
        {
            pizza = new Pizza();
        }

        public PizzaBuilder SetBoyut(string boyut)
        {
            pizza.Boyut = boyut;
            return this;
        }
        public PizzaBuilder SetHamurTipi(string hamurTi)
        {
            pizza.HamurTipi = hamurTi;
            return this;
        }
        public PizzaBuilder SetPeynir()
        {
            pizza.Peynir = true;
            return this;
        }
        public Pizza Build()
        {
            return pizza;
        }
    }

    public class PizzaDirector
    {
        public Pizza OrtaPizza()
        {
            return new PizzaBuilder()
                .SetBoyut("Orta")
                .SetHamurTipi("Kalın")
                .SetPeynir()
                .Build();
        }

        public Pizza KarisikPizza()
        {
            return new PizzaBuilder()
                .SetBoyut("Buyuk")
                .SetHamurTipi("İnce")
                .SetPeynir()
                .Build();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var ortapizza = new PizzaDirector().OrtaPizza();

            var mypizza = new PizzaBuilder()
                .SetBoyut("cmkefs")
                .SetHamurTipi("debds")
                .SetPeynir()
                .Build();


            var director = new PizzaDirector();
            var orta = director.OrtaPizza();

        }
    }

}
