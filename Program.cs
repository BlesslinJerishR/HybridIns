using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanarysHybridIheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent op = new Parent();
            Console.WriteLine(@"
  ____                                  _   
 |  _ \    __ _   _ __    ___   _ __   | |_ 
 | |_) |  / _` | | '__|  / _ \ | '_ \  | __|
 |  __/  | (_| | | |    |  __/ | | | | | |_ 
 |_|      \__,_| |_|     \___| |_| |_|  \__|
                                            ");
            op.ParInfo();
            Console.WriteLine(" ");
            

            Console.WriteLine(@"
   ____   _       _   _       _               _ 
  / ___| | |__   (_) | |   __| |             / |
 | |     | '_ \  | | | |  / _` |    _____    | |
 | |___  | | | | | | | | | (_| |   |_____|   | |
  \____| |_| |_| |_| |_|  \__,_|             |_|
                                                ");
            GirlChild og = new GirlChild();
            og.ParInfo();
            og.ChildInfo();
            Console.WriteLine(" ");
            Console.WriteLine(@"
   ____   _       _   _       _               ____  
  / ___| | |__   (_) | |   __| |             |___ \ 
 | |     | '_ \  | | | |  / _` |    _____      __) |
 | |___  | | | | | | | | | (_| |   |_____|    / __/ 
  \____| |_| |_| |_| |_|  \__,_|             |_____|
                                                    ");
            BoyChild bg = new BoyChild();
            bg.ParInfo();
            bg.ChildInfo();
            Console.WriteLine(" ");
            Console.WriteLine(@"
  ____            _          ____   _       _   _       _               _ 
 / ___|   _   _  | |__      / ___| | |__   (_) | |   __| |             / |
 \___ \  | | | | | '_ \    | |     | '_ \  | | | |  / _` |    _____    | |
  ___) | | |_| | | |_) |   | |___  | | | | | | | | | (_| |   |_____|   | |
 |____/   \__,_| |_.__/     \____| |_| |_| |_| |_|  \__,_|             |_|
                                                                          ");
            GirlChildBaby gcb = new GirlChildBaby();
            gcb.ParInfo();
            gcb.ChildInfo();
            gcb.ChildInfoBaby();
            
            BoyChildBaby bcb = new BoyChildBaby();
            Console.WriteLine(@"
  ____            _          ____   _       _   _       _               ____  
 / ___|   _   _  | |__      / ___| | |__   (_) | |   __| |             |___ \ 
 \___ \  | | | | | '_ \    | |     | '_ \  | | | |  / _` |    _____      __) |
  ___) | | |_| | | |_) |   | |___  | | | | | | | | | (_| |   |_____|    / __/ 
 |____/   \__,_| |_.__/     \____| |_| |_| |_| |_|  \__,_|             |_____|
                                                                              ");
            bcb.ParInfo();
            bcb.ChildInfo();
            bcb.ChildInfoBaby();

            Console.ReadLine();        }

        public class Parent
        {
            public void ParInfo()
            {
                Console.WriteLine("I thee Parent");
            }
        }

        public class GirlChild : Parent
        {
            public void ChildInfo()
            {
                Console.WriteLine("You a Girl ?");
            }
        }

        public class BoyChild : Parent
        {
            public void ChildInfo()
            {
                Console.WriteLine("You a Boy ?");
            }
        }

        public class GirlChildBaby : GirlChild
        {
            public void ChildInfoBaby()
            {
                Console.WriteLine("You a Boy ?");
            }
        }

        public class BoyChildBaby : BoyChild
        {
            public void ChildInfoBaby()
            {
                Console.WriteLine("You a Boy ?");
            }
        }
    }
}
