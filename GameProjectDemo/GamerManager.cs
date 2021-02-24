using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class GamerManager
    {
        public void Add(Gamer gamer1)
        {
            Console.WriteLine("Tebrikler! Yeni Oyuncu Eklendi...", gamer1);
        }
        
        public void Update(Gamer gamer2)
        {
            Console.WriteLine("Tebrikler! Oyuncu Yükseltildi...", gamer2);
        }

        public void Delete(Gamer gamer3)
        {
            Console.WriteLine("Oyuncu Silme İşlemi Başarılı...",gamer3);
        }


        

    }
}
