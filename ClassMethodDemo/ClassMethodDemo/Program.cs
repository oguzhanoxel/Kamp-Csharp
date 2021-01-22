using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager user_manager = new UserManager();

            // Veritabanında var olduğu sayılan kullanıcılar
            User user1 = new User();
            user1.FirstName = "Ahmet";
            user1.LastName = "Ahmetin Soyadi";
            user1.Phone = "555 333 55 55";
            user1.Address = "Ahmet Address";

            User user2 = new User();
            user2.FirstName = "Mehmet";
            user2.LastName = "Mehmetin Soyadi";
            user2.Phone = "333 333 33 33";
            user2.Address = "Mehmet Address";

            User user3 = new User();
            user3.FirstName = "Ayse";
            user3.LastName = "Aysenin Soyadi";
            user3.Phone = "333 333 32 32";
            user3.Address = "Ayse Address";

            user_manager.users.Add(user1);
            user_manager.users.Add(user2);
            user_manager.users.Add(user3);

            // Var olan kullanacılar listelendi
            user_manager.user_list();

            // Yeni kullanıcı ekleme

            // kullanıcıdan gelmesi gereken veriler 
            User new_user = new User();
            new_user.FirstName = "Deniz";
            new_user.LastName = "Denizin Soyadi";
            new_user.Phone = "332 222 32 32";
            new_user.Address = "Ayse Address";
            user_manager.add(new_user);

            Console.WriteLine("YENI KULLANICI EKLENEDIKTEN SONRA LISTE");
            user_manager.user_list();

            // Varolan kullanıcıyı silme
            user_manager.remove(user2);

            Console.WriteLine("KULLANICI SILINDIKTEN SONRA LISTE");
            user_manager.user_list(); // bu listede mehmet adlı kullanıcının silinmesi bekleniyor

        }
    }
}
