using System;
using System.Collections.Generic;

namespace Votingapp
{
    public class User
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Pratikler\MiniProjects\Proje-VotingApp\userLog.txt";
        public User(string userName)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            using (StreamWriter sr = new StreamWriter(path,append : true))
            {
                sr.WriteLine("\n{0}",userName);
            }
        }
        public static bool Login(string userName)
        {
           if (!File.Exists(path))
           {
                File.Create(path).Close();
           }
           using (StreamReader sr = new StreamReader(path))
           {
             while (!sr.EndOfStream)
             {
                if (sr.ReadLine().Contains(userName))
                {
                    return true;
                }
                
             }
             return false;
           }
        }
    }
}