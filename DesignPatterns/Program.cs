using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Initial State at: ");
            var horse = new Horse();
            horse.FeedHorse();
            horse.PutHorseToSleep();
            horse.IdleHorse();  

            var cow = new Cow();    
            cow.FeedCow();  
            cow.PutCowToSleep();
            cow.IdleCow();

            var observer = new ContextObserver();
            observer.Update(cow.currentStateContext);
        }
    }
}
