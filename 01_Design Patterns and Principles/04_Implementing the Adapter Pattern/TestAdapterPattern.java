public class TestAdapterPattern {
    public static void main(String[] args) {
        // Use PayPal via Adapter
        PaymentProcessor paypalProcessor = new PayPalAdapter(new PayPalGateway());
        paypalProcessor.processPayment(250.00);

        // Use Stripe via Adapter
        PaymentProcessor stripeProcessor = new StripeAdapter(new StripeGateway());
        stripeProcessor.processPayment(450.00);
    }
}
