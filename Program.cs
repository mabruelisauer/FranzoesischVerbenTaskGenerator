namespace FranzösischVerbenAufgabenGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task();

            for (int i = 0; i < 10; i++) 
            { 
                task.GenerateTask();
            }
        }
    }
}
