namespace BlazorUICommuStudy.Services
{
    public interface ICountService
    {
        public int Count { get; set; }

        event Action OnChange;

        public void IncrementCount();
        public void ResetCount();
    }
}
