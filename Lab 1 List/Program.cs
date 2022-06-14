using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Username> list = new List<Username> { new Username ( "Red", 123 ), new Username ("Brown", 234), new Username("Grey", 567), new Username("Black", 890) };
            Console.WriteLine("Поиск по Id");
            int id = int.Parse(Console.ReadLine());
            FindOfId(list, id);
            Console.WriteLine("Поиск по Name");
            string name = Console.ReadLine();
            FindOfName(list, name);
            Console.ReadKey();
        }
        private static  List<Username> FindOfId(List<Username> list, int id)
        {
            foreach(var username in list)
            {
                if (username.Id == id)
                {
                    Console.WriteLine(username.Name);
                }
                
            }

            return list;
        }
    private static List<Username>  FindOfName(List<Username> list, string name)
        {
            foreach (var username in list)
            {
                if (username.Name == name)
                {
                    Console.WriteLine(username.Id);
                }

            }
            return list;
        }
    }
    
      class Username
    {
        public string Name { get; private set; }
        public int Id { get; private set; }
        public Username(string name, int id)
        {
            Name = name;
            Id = id;
        }
    } 

    
}
