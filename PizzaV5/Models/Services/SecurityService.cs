namespace PizzaV5.Models.Services
{
    public class SecurityService
    {

        usersDAO usersDAO = new usersDAO();
        
        public SecurityService()
        {
           
        }

        public bool IsValid(UserModel user)
        {
            // return true if found in the list
            return usersDAO.FindUserByNameAndPassword(user);
        }
    }
}
