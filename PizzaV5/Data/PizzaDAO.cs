using PizzaV5.Models;
using System.Data.SqlClient;

namespace PizzaV5.Data
{
    internal class PizzaDAO
    {

        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Pizza; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //this will perform all the database tasks required

        public List<PizzaModelFromDb> FetchAll()
        {
            List<PizzaModelFromDb> returnList = new List<PizzaModelFromDb>();

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "Select * from dbo.Pizza";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    { 
                        while (reader.Read())
                        {


                        //create new pizza object. Add it to the list to return.


                        PizzaModelFromDb pizzas = new PizzaModelFromDb();

                        pizzas.PizzaId = reader.GetInt32(0);
                        pizzas.PizzaName = reader.GetString(1);
                        pizzas.PizzaSize = reader.GetInt32(2); 
                        pizzas.PizzaPrice = reader.GetDecimal(3);
                        
                        
                        returnList.Add(pizzas);


                        }
                    }


            }



                return returnList;
        }
    
    }
}