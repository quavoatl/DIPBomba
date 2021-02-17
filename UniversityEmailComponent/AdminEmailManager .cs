using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversityEmailComponent
{
    public class AdminEmailManager : IUniversityEmailManager
    {
        public bool RequestProcessed { get; set; }

        public void ProcessRequest(string request)
        {
            Console.WriteLine("No suitable Dept for your request. Therefore Admin Dept will help you with this");
        }

        public void SetNextHandler(IUniversityEmailManager nextHandler)
        {
        }
    }
}
