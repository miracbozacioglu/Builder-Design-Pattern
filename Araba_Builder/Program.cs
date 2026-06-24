namespace Araba_Builder
{
    public class Araba
    {
        public string Renk { get; set; }
        public int Hp { get; set; }
        public string Vites { get; set; }

        public string Yakit { get; set; }

        public Araba()
        {
            Renk = "Beyaz";
            Hp = 75;
            Vites = "Manuel";
            Yakit = "Benzin";
        }
    }

    public class ArabaBuilder
    {
        private Araba araba;

        public ArabaBuilder()
        {
            araba = new Araba();
        }

        public ArabaBuilder Setrenk(string renk)
        {
            araba.Renk = renk;
            return this;
        }

        public ArabaBuilder SetHp(int hp)
        {
            araba.Hp = hp;
            return this;
        }
        public ArabaBuilder SetVites(string vites)
        {
            araba.Vites = vites;
            return this;
        }
        public ArabaBuilder SetYakit(string yakit)
        {
            araba.Yakit = yakit;
            return this;
        }
        public Araba Build()
        {
            return araba;
        }

    }

    public class ArabaDirector
    {
        public Araba EkoSinifAraba()
        {
            return new ArabaBuilder()
                .Setrenk("SimliBeyaz")
                .SetHp(100)
                .SetVites("Yarı-Otomatik")
                .SetYakit("Dizel")
                .Build();
        }

        public Araba OrtaSinifAraba()
        {
            return new ArabaBuilder()
                .Setrenk("Kırmızı")
                .SetHp(120)
                .SetVites("Otomatik")
                .SetYakit("Benzin")
                .Build();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Araba ortasinif = new ArabaDirector().OrtaSinifAraba();

            var mycar = new ArabaBuilder()
                .Setrenk("Mavi")
                .SetHp(150)
                .SetVites("Otomatik")
                .SetYakit("Dizel")
                .Build();

            Console.WriteLine(mycar.Hp);


            var director = new ArabaDirector();
            var mycar2 = director.OrtaSinifAraba();
        }
    }

  

}
