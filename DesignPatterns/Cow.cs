using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Cow
    {
        public Context currentStateContext = null;

        public Cow()
        {
            this.currentStateContext = new Context(new IdleState());
            Console.WriteLine("Current animal is cow");
            //currentStateContext.TransitionTo(new IdleState());
        }

        public void FeedCow()
        {
            this.currentStateContext.TransitionTo(new EatingState());
            currentStateContext.ChangeToEating();
        }

        public void PutCowToSleep()
        {
            this.currentStateContext.TransitionTo(new SleepingState());
            currentStateContext.ChangeToSleeping();
        }

        public void IdleCow()
        {
            this.currentStateContext.TransitionTo(new IdleState());
            currentStateContext.ChangeToIdle();
        }
    }
}
