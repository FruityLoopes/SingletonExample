using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class DbUtil
    {
        private static DbUtil instance;
        public int count = 0;

        private DbUtil()
        {
            count++;

            Console.WriteLine("I have been instatianted {0} time " , count);
        }

        public static DbUtil getInstance() 
        {
            if (instance == null)
            {
                instance = new DbUtil();    
            }        
            return instance;
        }
    }
}
