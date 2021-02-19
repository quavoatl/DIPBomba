using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterV2
{
    public class Client
    {
        private readonly IAdapter _adapter;

        public Client(IAdapter adapter)
        {
            _adapter = adapter;
        }

        public void CallRemote()
        {
            _adapter.InvokeAdapter();
        }
    }
}
