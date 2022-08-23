namespace BlazorComponentCommunicationTutorial.Services
{
    public class NotificationService : INotificationService
    {
        public int Count { get; set; } = 0;

        public event Action Onchange;

        public void IncrementCounter()
        {
            Count++;
            Onchange?.Invoke();
        }

        public void ReserCounter()
        {
            Count=0;
            Onchange?.Invoke();
        }
    }
}
