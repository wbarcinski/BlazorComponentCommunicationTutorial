        namespace BlazorComponentCommunicationTutorial.Services
{
    public interface INotificationService
    {
        event Action OnChange;
        int Count { get; set; }
        List<string> Messages { get; set; }
        void IncrementCounter();
        void ResetCount();
        void AddItem();
        void ResetMessages();

    }
}
