namespace Facade.Service {
    internal class AccountService {
        public void GetAccount(string email) {
            Console.WriteLine($"Getting account via {email}");
        }
    }
}