namespace FitnessTracker
{
    public class UserNotification : IObserver
    {
        public void Update(double progress)
        {
            Console.WriteLine($"Прогресс цели: {progress}%");
        }
    }
}