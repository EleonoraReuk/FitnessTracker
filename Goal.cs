namespace FitnessTracker
{
    public class Goal
    {
        private List<IObserver> observers = new();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify(double progress)
        {
            foreach (var observer in observers)
            {
                observer.Update(progress);
            }
        }
    }
}