using System;

namespace UniversityEmailProcessor
{
    public interface IEmailService
    {
        void SendRequest(string request);
    }
}
