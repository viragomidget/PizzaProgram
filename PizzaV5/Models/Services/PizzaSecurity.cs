namespace PizzaV5.Models.Services
{
    public class PizzaSecurity
    {

        List<PizzaModel> knownPizzas = new List<PizzaModel>();

        public PizzaSecurity()
        {
            knownPizzas.Add(new PizzaModel{ Id = 0, PizzaName = "Hawian", PizzaPrice = 12, PizzaSize = 20 });
            knownPizzas.Add(new PizzaModel { Id =1, PizzaName = "Ha and Cheese", PizzaPrice = 13, PizzaSize = 20 });
            knownPizzas.Add(new PizzaModel { Id = 2, PizzaName = "Hot One", PizzaPrice = 12, PizzaSize = 20 });
        }


    }
}
