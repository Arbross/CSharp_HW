using System;
using System.Collections.Generic;
using System.Text;

namespace Funny_Events_HW_NET
{
    class EventService
    {
        private List<Event> events = new List<Event>();

        public void AddEvent(DateTime playTime, string name, uint population, string place, Client client)
        {
            Event tmp = new Event(playTime, name, population, place, client);
            events.Add(tmp);
        }
        public void RemoveEvent(int index)
        {
            events.RemoveAt(index);
        }
        public void ClearEvent()
        {
            events.Clear();
        }
        public void FindByDate(DateTime date)
        {
            List<Event> tmp = events.FindAll(e => e.playTime == date);
            Print(tmp);
        }
        public void FindByClient(Client client)
        {
            List<Event> tmp = events.FindAll(e => e.client == client);
            Print(tmp);
        }
        public void FindByDateRange(DateTime left, DateTime right)
        {
            List<Event> tmp = events.FindAll(e => (e.playTime <= right && e.playTime >= left));
            Print(tmp);
        }
        public void Print(List<Event> tmp)
        {
            foreach (var elem in tmp)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
