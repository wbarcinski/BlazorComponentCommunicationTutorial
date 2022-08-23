namespace BlazorComponentCommunicationTutorial.Services
{
    public interface INotificationService
    {
        event Action Onchange;
        int Count { get; set; }
        void IncrementCounter();
        void ReserCounter();

    }
}
