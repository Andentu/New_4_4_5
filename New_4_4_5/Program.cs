namespace New_4_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCount) Pet;
            Console.Write("Введите кличку животного: ");
            Pet.Name = Console.ReadLine();
            Console.Write("\nВведите тип домашнего животного: ");
            Pet.Type = Console.ReadLine();
            Console.Write("\nВведите возраст животного: ");
            Pet.Age = double.Parse(Console.ReadLine());
            Pet.NameCount = Pet.Name.Length;

            Console.Write($"\nКличка: {Pet.Name}, тип: {Pet.Type}, возраст: {Pet.Age}, количество букв в кличке: {Pet.NameCount}");
            Console.ReadKey();
        }
    }
}