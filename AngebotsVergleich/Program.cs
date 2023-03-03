namespace AngebotsVergleich
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        //allo
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Console.WriteLine("Wat machen wa hier denn?????");
            Console.WriteLine("BOOOOOOO!");
            Console.ReadLine();
        }
    }
}