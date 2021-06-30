using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Context
    {
        private State _state = null;

        public Context(State state)
        {
            this.TransitionTo(state);
        }

        public string GetState()
        {
            return ($"{_state.GetType().Name}.");
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Changing state to : {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }

        public void ChangeToEating()
        {
            this._state.ChangeToEating();
        }

        public void ChangeToSleeping()
        {
            this._state.ChangetoSleep();
        }

        public void ChangeToIdle()
        {
            this._state.ChangeToIdle();
        }

    }
}
