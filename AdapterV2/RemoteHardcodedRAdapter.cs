using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterV2
{
    public class RemoteHardcodedRAdapter: IAdapter
    {
        private RemoteHardcodedResponse remote = new RemoteHardcodedResponse();

        public void InvokeAdapter()
        {
           Console.WriteLine(remote.GetHardcodedResponse() + " + adapter ");
        }
    }
}
