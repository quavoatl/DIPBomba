using System;

namespace AdapterV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new RemoteHardcodedRAdapter());
            client.CallRemote();
        }
    }
}
