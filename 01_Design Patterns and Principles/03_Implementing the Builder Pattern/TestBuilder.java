public class TestBuilder {
    public static void main(String[] args) {
        Computer basicComputer = new Computer.Builder("Intel i5", "8GB")
                .setStorage("256GB SSD")
                .build();

        Computer gamingComputer = new Computer.Builder("Intel i9", "32GB")
                .setStorage("1TB SSD")
                .setGraphicsCard("NVIDIA RTX 4080")
                .setOperatingSystem("Windows 11")
                .build();

        Computer devComputer = new Computer.Builder("M2 Pro", "16GB")
                .setStorage("512GB SSD")
                .setOperatingSystem("macOS Sonoma")
                .build();

        // Show configurations
        basicComputer.showConfig();
        gamingComputer.showConfig();
        devComputer.showConfig();
    }
}
