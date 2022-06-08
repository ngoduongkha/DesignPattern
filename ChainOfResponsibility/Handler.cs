namespace ChainOfResponsibility {
    internal abstract class Handler {
        public Handler? rsHandler;
        public void NextHandler(Handler rsHandler) {
            this.rsHandler = rsHandler;
        }
        public abstract void DispatchRs(long requestedAmount);
    }
}
