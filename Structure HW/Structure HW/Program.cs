using System;

namespace Structure_HW
{
    class Program
    {
        static void Main()
        {
            Client client = new Client(0, "PIB", "Ad", 100000004, 0, 0);
            Client client1 = new Client(1, "PIB1", "Ad1", 100010000, 0, 0);
            Request request = new Request(0, client, default(DateTime));
            Article article = new Article(0, "Name1", 122, 0);
            Article article1 = new Article(0, "Name2", 112, 0);
            Article article2 = new Article(0, "Name3", 152, 0);
            request.AddRequest(article, 1);
            Console.WriteLine(client.ToString());
            request.AddRequest(article1, 5);
            Console.WriteLine(client.ToString());
            request.AddRequest(article2, 2);
            Console.WriteLine(client.ToString());
        }
    }
}
