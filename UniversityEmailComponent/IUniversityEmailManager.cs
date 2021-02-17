using System;

namespace UniversityEmailComponent
{
    public interface IUniversityEmailManager
    {
        public bool RequestProcessed { get; set; }
        void ProcessRequest(string request);
        void SetNextHandler(IUniversityEmailManager nextHandler);
    }
}
