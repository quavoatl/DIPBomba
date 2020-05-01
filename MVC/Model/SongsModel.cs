using MVC.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.Model
{
    public class SongsModel : ISongObservable
    {
        private ISongController _controller;
        private List<string> _songsList;
        private string _currentSong = string.Empty;
        public string CurrentSong { get => _currentSong; set => _currentSong = value; }

        public SongsModel()
        {
            _songsList = new List<string>();
            _songsList.Add("John Cena - You can't see me");
            _songsList.Add("Rock - Rock Maxim");
            _songsList.Add("DNB - DNBu pulii");
            _currentSong = _songsList[0];
        }

        public void RegisterController(ISongController controller)
        {
            this._controller = controller;
        }

        public void NotifyObservers()
        {
            _controller.Update();
        }

        public string Next()
        {
            string newSong = string.Empty;
            try
            {
                newSong = _songsList[_songsList.IndexOf(_currentSong) + 1];
                _currentSong = newSong;
                NotifyObservers();
            }
            catch (Exception ex)
            {
                Console.WriteLine("End of song list");
            }
            return newSong;
        }

        public string Previous()
        {
            string newSong = string.Empty;
            try
            {
                newSong = _songsList[_songsList.IndexOf(_currentSong) - 1];
                _currentSong = newSong;
                NotifyObservers();
            }
            catch (Exception ex)
            {
                Console.WriteLine("End of song list");
            }
            return newSong;
        }
    }
}
