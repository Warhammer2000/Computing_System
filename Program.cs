using ComputingSystem.Background;

namespace ComputingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BackgroundServices.InitializeProgram();
            BackgroundServices.Log("\n Hello, World!");
            BackgroundServices.ShowProgressBar();
            BackgroundServices.ShowCircularLoading();


        }
    }
}
