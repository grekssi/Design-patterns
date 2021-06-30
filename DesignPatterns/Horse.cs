using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class Horse
    {
        public Context currentStateContext = null;

        public Horse()
        {
            this.currentStateContext = new Context(new IdleState());
            //currentStateContext.TransitionTo(new IdleState());
        }

        public void FeedHorse()
        {
            this.currentStateContext.TransitionTo(new EatingState());
            currentStateContext.ChangeToEating();
        }

        public void PutHorseToSleep()
        {
            this.currentStateContext.TransitionTo(new SleepingState());
            currentStateContext.ChangeToSleeping();
        }

        public void IdleHorse()
        {
            this.currentStateContext.TransitionTo(new IdleState());
            currentStateContext.ChangeToIdle();
        }
    }
}
