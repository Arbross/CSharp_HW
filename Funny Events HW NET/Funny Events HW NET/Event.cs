using System;
using System.Collections.Generic;
using System.Text;

namespace Funny_Events_HW_NET
{
    class Event
    {
        private string name { get; set; }
        private uint population { get; set; }
        private string place { get; set; }
        public DateTime playTime { get; set; }
        public readonly uint ID;
        private static uint counter { get; set; }
        public Client client { get; set; }
        public Event(DateTime playTime = default, string name = "Noname", uint population = 0, string place = "No place", Client client = default)
        {
            this.name = name;
            this.population = population;
            this.place = place;
            this.playTime = playTime;
            ID = ++counter;
            this.client = client;
        }
        public Event() : this(default, "Noname", 0, "No place", default(Client)) { }
        public void moveDateByDay(uint days = 0)
        {
            playTime.AddDays(days);
        }
        public void moveDateByWeek(uint weeks = 0)
        {
            playTime.AddDays(weeks * 7);
        }
        public override string ToString()
        {
            return ($"Name : {name}, Population : {population}, Place : {place}, Play time : {playTime}, ID : {ID}, Counter : {counter}, Client : {client.ToString()}");
        }
    }
}
