namespace Facade.Service {
    internal class SmsService {
        public void SendSMS(string mobilePhone) {
            Console.WriteLine("Sending a message to " + mobilePhone);
        }
    }
}
