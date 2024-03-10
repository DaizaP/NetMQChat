namespace NetMQChatServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await Server.Run();
            Console.ReadKey();
        }
    }
}
