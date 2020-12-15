using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLogic;
using DTO.Cassandra;


namespace ConsoleApp1
{

    public class CassandraProgram
    {

        static void Main(string[] args)
        {
            CassandraUser cu=new CassandraUser();

            Console.WriteLine("Hello,sweety,enter your email,please!");
            var em = Console.ReadLine();
            cu.Login(em);

            cu.ReadAllPosts();
            Menu(em, cu);

            Console.ReadKey();

        }
        public static void Menu(string e, CassandraUser cu)
        {
            Console.WriteLine("Do you want to:\n 1-Find new friend \n " +
                "2-Write a post\n" +
                "3-Look over s-bodies post\n" +
                "4-Go out");
            var x = Console.ReadLine();
            switch (x)
            {
                case "1":
                    Console.WriteLine("Write name of searched person ");
                    string N = Console.ReadLine();
                    Console.WriteLine("Write surname now");
                    string S = Console.ReadLine();
                    
                    cu.ToFollow(N, S, e);
                    Menu(e, cu);

                    break;
                case "3":
                    Console.WriteLine("Write name of searched person ");
                    N = Console.ReadLine();
                    Console.WriteLine("Write surname now");
                    S = Console.ReadLine();
                   cu.PostReaction(N, S, e);
                    Menu(e,cu);
                    break;
                case "2":
                  var post= cu.CreatePost(e);
                    Menu(e,cu);
                    break;
                case "4":
                    Console.WriteLine("Bye:(");
                    Thread.Sleep(1000);
                    System.Environment.Exit(20);
                    break;
            }
        }

    }

}