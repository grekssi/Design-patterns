using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class ContextObserver
    {
        public void Update(Context context)
        {
            Console.WriteLine("Current state is " + context.GetState());
        }
    }
}
