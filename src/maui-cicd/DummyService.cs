namespace Tests
{
    public class CounterService{

        public int Count { get; set; }
        public CounterService(int initialCount){
            Count = initialCount;
        }

        public void Increment() => Count++;
        public void Decrement() => Count--;
    }
}