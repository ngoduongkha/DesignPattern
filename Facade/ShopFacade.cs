using Facade.Service;

namespace Facade {
    internal class ShopFacade {
        private static ShopFacade _instance = new();

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
            _shippingService.FreeShipping();
            _paymentService.PaymentByCash();
            _emailService.SendEmail(email);

            Console.WriteLine("Order successfully placed!\n");
        }

        public void MomoStandardShipping(string email, string mobilePhone) {
            _accountService.GetAccount(email);
            _shippingService.StandardShipping();
            _paymentService.PaymentByMomo();
            _emailService.SendEmail(email);
            _smsService.SendSMS(mobilePhone);

            Console.WriteLine("Order successfully placed!\n");
        }
    }
}
