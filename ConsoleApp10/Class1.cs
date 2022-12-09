namespace MyConsole
{
    internal class Class1
    {

        /// <summary>
        /// Что-то пишу
        /// </summary>
        public static void Main() 
        {
            int age = 22;
            int weight = 66;
            double temperature = 36.66; 
            string name = "Петр";
            Console.WriteLine("{0,-11} = {1}", "Возраст", age);
            Console.WriteLine("{0,-11} = {1}", "Вес", weight); 
            Console.WriteLine("{0,-11} = {1}", "Температура", temperature); 
            Console.WriteLine("{0,-11} = {1}", "Имя", name);

        }
    }
}
