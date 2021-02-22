using System;
using System.Collections.Generic;
using System.Text;
using UniversityEmailComponent;

namespace UniversityEmailProcessor
{
    public class UniversityEmailService : IEmailService
    {
        private List<IUniversityEmailManager> _handlers = new List<IUniversityEmailManager>(new IUniversityEmailManager[]
        {
            new HREmailManager(),
            new FinanceEmailManager(),
            new AdminEmailManager()
        });
       
        public UniversityEmailService()
        {
            SetChain();
        }

        private void SetChain()
        {
            for (int i = 0; i < _handlers.Count-1; i++)
            {
                try
                {
                    _handlers[i].SetNextHandler(_handlers[i + 1]);
                }
                catch(Exception ex) { }
            }
        }

        public void SendRequest(string request)
        {
            foreach (var handler in _handlers)
            {
                handler.ProcessRequest(request);

                if (handler.RequestProcessed) break;
            }
        }
    }
}
