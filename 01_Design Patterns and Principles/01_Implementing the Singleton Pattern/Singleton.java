public class Singleton {
    public static void main(String[] args) {
        Logger logger1 = Logger.getInstance();
        logger1.log("Hello from logger1!");

        Logger logger2 = Logger.getInstance();
        logger2.log("Hello from logger2!");

        if (logger1 == logger2) {
            System.out.println("Same Logger object used!");
        } else {
            System.out.println("Different Logger objects used.");
        }
    }
}
