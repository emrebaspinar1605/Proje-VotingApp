using System;

namespace Votingapp
{
    public class Category
    {
         static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Pratikler\MiniProjects\Proje-VotingApp\voteLog.txt";
        public Category(int vote)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            using (StreamWriter sw = new StreamWriter(path , append: true))
            {
                sw.WriteLine("\n{0}",vote);
            }
        }
        public static string ChoiceCategory()
        {
            double sport = 0, game = 0, readBook = 0;  
            string res = "";
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    switch (sr.ReadLine().TrimEnd().TrimStart())
                    {
                        case "1": sport++; break;
                        case "2": game++; break;
                        case "3": readBook++; break;
                        default: break;
                    }
                }
                double oran = (sport + game + readBook);
                res = String.Format($"\n Sonuçlar:") + $"\n Spor=> %{(sport * 100) / oran }----{sport}"+
                  $"\n Game=> %{(game * 100)/oran}----{game}" +
                  $"\n KitapOkuma=> %{(readBook * 100) / oran}----{readBook}";
            }
            return res;
        }
    }
}