namespace BlazorComponentCommunicationTutorial.Services
{
    public class NotificationService : INotificationService
    {
        public int Count { get; set; } = 0;
        public List<string> Messages { get; set; }
       
        public event Action OnChange;

        public void AddItem()
        {
            Messages.Add("3444");
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
    }
}
