namespace BlazorComponentCommunicationTutorial.Services
{
    public class NotificationService : INotificationService
    {
        public int Count { get; set; } = 0;
        public List<string> Messages { get; set; }
        public Random rnd = new Random();
        public event Action OnChange;

        public void AddItem()
        {
            Messages.Add(Convert.ToString(rnd.Next(1, 1000)));
            OnChange?.Invoke();
        }

        public void IncrementCounter()
        {
            Count++;
            OnChange?.Invoke();
        }

        public void ResetCount()
        {
            Count=0;
            OnChange?.Invoke();
        }
        public void ResetMessages()
        {
            Messages.Clear();
            OnChange?.Invoke();
        }
    }
}
