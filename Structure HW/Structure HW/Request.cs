using System;
using System.Collections.Generic;
using System.Text;

namespace Structure_HW
{
    class Request : ICloneable
    {
        private ushort code;
        private Client client;
        private DateTime date;
        private List<RequestItem> ri;
        private readonly uint sumOfBuying;
        public void AddRequest(Article article, ushort count)
        {
            ri.Add(new RequestItem(article, count));
            client.AllCountOfBuying++;
        }
        public void RemoveRequest(Article article, ushort count)
        {
            ri.Remove(new RequestItem(article, count));
            client.AllCountOfBuying--;
        }
        public Request(ushort code, Client client, DateTime date)
        {
            Code = code;
            this.client = client;
            this.date = date;
            ri = new List<RequestItem>();
        }
        public Request() : this(0, default(Client), default(DateTime)) { }
        public ushort Code
        {
            get => code;
            set => code = value;
        }
        public Client nClient
        {
            get => client;
            set => client = value;
        }
        public DateTime Date
        {
            get => date;
            set => date = value;
        }
        public uint SumOfBuying
        {
            get => sumOfBuying;
        }
        public object Clone()
        {
            Request request = new Request(this.Code, this.nClient, this.Date);
            return request;
        }
    }
}
