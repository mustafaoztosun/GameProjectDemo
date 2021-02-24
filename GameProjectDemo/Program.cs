using System;

namespace GameProjectDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Mustafa";
            gamer1.LastName = "Öztosun";
            gamer1.TcNo = "12345678910";

            Gamer gamer2 = new Gamer();
            gamer2.Id = 2;
            gamer2.FirstName = "İsmail";
            gamer2.LastName = "Akçuru";
            gamer2.TcNo = "10987654321";

            Gamer gamer3 = new Gamer();
            gamer3.Id = 3;
            gamer3.FirstName = "Salih";
            gamer3.LastName = "Avcı";
            gamer3.TcNo = "25469873124";

            Gamer[] gamers = new Gamer[] { gamer1, gamer2, gamer3 };

            foreach (var gamer in gamers)
            {
                Console.WriteLine("*************Oyuncu Bilgileri*************");
                Console.WriteLine(gamer.Id);
                Console.WriteLine(gamer.FirstName);
                Console.WriteLine(gamer.LastName);
                Console.WriteLine(gamer.TcNo);
                Console.WriteLine("-----------------------------------------------------");
            }


        }
    }
}
