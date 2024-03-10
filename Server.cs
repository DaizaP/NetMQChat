using NetMQ;
using NetMQ.Sockets;
using System.Net;
using System.Net.Sockets;

namespace NetMQChatServer
{
    public class Server : IMessageSource
    {
        public static async Task Run()
        {
            using (var reciever = new PullSocket("tcp://*:5557"))
            using (var sender = new PushSocket(">tcp://127.0.0.1:5558"))
            {
                while (true)
                {

                    string fromClientMessage = reciever.ReceiveFrameString();
                    Console.WriteLine(fromClientMessage);
                    sender.SendFrame(fromClientMessage);
                }
            }
        }
    }
}
