using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class EatingState : State
    {
        public override void ChangeToEating()
        {
            Console.WriteLine("The animal is now eating");
            this._context.TransitionTo(this);
        }

        public override void ChangeToIdle()
        {
            Console.WriteLine("The animal is now at idle");
            this._context.TransitionTo(new IdleState());
        }

        public override void ChangetoSleep()
        {
            Console.WriteLine("The animal is now at sleep");
            this._context.TransitionTo(new SleepingState());
        }
    }
}
