using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TasksForModul12
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static void GetPageForUser(User user)
        {
            if (!user.LoggedIn)
                return;
            Console.WriteLine("User logged in");

            if (!user.HasAccessToSection)
                return;
            Console.WriteLine("User has access to that section");

            if (user.HasUnseenNews)
            {
                ShowNews();
            }

            if (user.HasAdminRights)
            {
                DecorateAdminTools();
            }


        }
    }
}
