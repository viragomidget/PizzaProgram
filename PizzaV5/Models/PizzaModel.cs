namespace PizzaV5.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Cost { get; set; }
       

        //Create a constructer 

        public PizzaModel(int id, string name, int cost)
        {
            Id = id;
            Name = name;
            Cost = cost;
        }
    }
}
