namespace PizzaV5.Models
{
    public class PizzaModelFromDb
    {

        //Note all the names for the Pizza's is different to the static ones

            public int PizzaId { get; set; }

            public string PizzaName { get; set; }

            public int PizzaSize { get; set; }

            public decimal PizzaPrice { get; set; }


        public PizzaModelFromDb(int Pizzaid, string Pizzaname, int Pizzasize, decimal Pizzaprice)

        {
                Pizzaid = PizzaId;
                Pizzaname = PizzaName;
                Pizzasize = PizzaSize;
                Pizzaprice = PizzaPrice;
            }

        public PizzaModelFromDb()
        {
        
        }
    }
}
