using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversityEmailComponent
{
    public class FinanceEmailManager : IUniversityEmailManager
    {
        private string[] _specificKeywords = new[] {"finance", "cash"};
        private IUniversityEmailManager _nextEmailManagerInChain;
        private string _userRequest;

        public bool RequestProcessed { get; set; }

        public void ProcessRequest(string request)
        {
            _userRequest = request;
            if (_specificKeywords.Contains(_userRequest))
            {
                Console.WriteLine("Your requst was processed by the Finance Dept !!");
                RequestProcessed = true;
            }
        }

        public void SetNextHandler(IUniversityEmailManager nextHandler)
        {
            _nextEmailManagerInChain = nextHandler;
        }
    }
}
