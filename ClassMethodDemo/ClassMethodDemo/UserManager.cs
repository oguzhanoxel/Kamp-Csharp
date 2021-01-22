using System;
using System.Collections.Generic;
using System.Text;


namespace ClassMethodDemo
{
    class UserManager
    {
        public List<User> users = new List<User>();

        public void user_list()
        {
            for (int counter=0; counter<users.Count; counter++) {
                Console.WriteLine("****************************************");
                Console.WriteLine(" First Name: " + users[counter].FirstName);
                Console.WriteLine(" Last Name: " + users[counter].LastName);
                Console.WriteLine(" Address: " + users[counter].Address);
                Console.WriteLine(" Phone: " + users[counter].Phone);
            }
        }

        public void add(User user)
        {
            Console.WriteLine("\n " + user.FirstName + " ADLI KULLANICI EKLENIYOR...");
            users.Add(user);
        }

        public void remove(User user)
        {
            Console.WriteLine("\n " + user.FirstName + " ADLI KULLANICI SILINIYOR...");
            users.Remove(user);
        }
    }
}
