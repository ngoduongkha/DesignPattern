using System.Threading.Tasks;

namespace ChainOfResponsibility {
    internal class ATM {
        private TwoThousandHandler twoThousandHandler = new TwoThousandHandler();
        private FiveHundredHandler fiveHundredHandler = new FiveHundredHandler();
        private TwoHundredHandler twoHundredHandler = new TwoHundredHandler();
        private HundredHandler hundredHandler = new HundredHandler();

        public ATM() {
            // Prepare the chain of Handlers
            twoThousandHandler.NextHandler(fiveHundredHandler);
            fiveHundredHandler.NextHandler(twoHundredHandler);
            twoHundredHandler.NextHandler(hundredHandler);
        }
        public void Withdraw(long requestedAmount) {
            twoThousandHandler.DispatchRs(requestedAmount);
        }
    }
}
