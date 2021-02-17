using System;
using System.Collections.Generic;
using System.Text;
using MediatorDriver.Subscribers;

namespace MediatorDriver.Mediator
{
    public class ApiMediator : ISystemMediator
    {
        private List<IColleague> _listOfColleagues = new List<IColleague>();

        public void HandleRequest(IColleague colleague, string request)
        {
            foreach (var col in _listOfColleagues)
            {
                if (col != colleague)
                {
                    col.ReceiveRequest(request);
                }
            }
        }

        public void RegisterColleague(IColleague col)
        {
            _listOfColleagues.Add(col);
        }
    }
}
