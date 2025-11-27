namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectronicsStore store = new ElectronicsStore();

            Laptop laptop = new Laptop("Dell", 1200);
            Smartphone phone = new Smartphone("Samsung", 800);

            store.AddDevice(laptop);
            store.AddDevice(phone);

            store.ShowAllDeviceDetails();

            Console.ReadLine();
        }
    }
}
