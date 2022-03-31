using Facade.Service;

namespace Facade {
    internal class ShopFacade {
        private static ShopFacade? _instance;

        private readonly AccountService _accountService;
        private readonly PaymentService _paymentService;
        private readonly ShippingService _shippingService;
        private readonly EmailService _emailService;
        private readonly SmsService _smsService;

        private ShopFacade() {
            _accountService = new AccountService();
            _paymentService = new PaymentService();
            _shippingService = new ShippingService();
            _emailService = new EmailService();
            _smsService = new SmsService();
        }

        public static ShopFacade GetInstance() {
            if (_instance == null)
                _instance = new ShopFacade();
            return _instance;
        }

        public void CashFreeShipping(string email) {
            _accountService.GetAccount(email);
            _paymentService.PaymentByCash();
            _shippingService.FreeShipping();
            _emailService.SendEmail(email);

            Console.WriteLine("Order successfully!\n");
        }

        public void MomoStandardShipping(string email, string mobilePhone) {
            _accountService.GetAccount(email);
            _paymentService.PaymentByMomo();
            _shippingService.StandardShipping();
            _emailService.SendEmail(email);
            _smsService.SendSMS(mobilePhone);

            Console.WriteLine("Order successfully!\n");
        }
    }
}
