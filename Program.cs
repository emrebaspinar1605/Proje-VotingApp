using System;
using System.Collections.Generic;

namespace Votingapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz..: ");
            string userName = Console.ReadLine();
            bool log = User.Login(userName);

            if (!log)
            {
                Console.WriteLine("\n Kaydınız Bulunamadı. Kaydınızı Gerçekleştiriyorum..:");
                User register = new User(userName);
            }
            Console.WriteLine("\n Lütfen Oy vereceğiniz kategoriyi seçin..: "+
                "\n Spor için 1," + "\n Oyun için 2," +"\n Kitap Okumak için 3,");
            int choice = int.Parse(Console.ReadLine());
            Category vote = new Category(choice);
            Console.WriteLine(Category.ChoiceCategory());
        }
    }
}