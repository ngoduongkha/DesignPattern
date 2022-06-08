namespace Facade.Service {
    internal class EmailService {
        public void SendEmail(string email) {
            Console.WriteLine($"Sending an email to {email}");
        }
    }
}
