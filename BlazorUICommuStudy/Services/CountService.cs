namespace BlazorUICommuStudy.Services
{
    public class CountService : ICountService
    {
        public int Count { get; set; } = 0;

        public event Action OnChange;

        public void IncrementCount()
        {
            Count++;
            OnChange?.Invoke();
        }

        public void ResetCount()
        {
            Count = 0;
            OnChange?.Invoke();
        }
    }
}
