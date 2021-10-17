namespace dotnetapp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var musicApp = new GUIApp();

            musicApp.Init();
            musicApp.AddControls();
        }
    }
}
