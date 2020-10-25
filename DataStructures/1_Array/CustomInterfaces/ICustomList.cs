namespace ConsoleApp1.DataStructures._1_Array.CustomInterfaces
{
    public interface ICustomList<T>
    {
        int Count { get; }
        void Add(T item);
        void Clear();
        T First();
        T Last();
        void Remove(T item);
        T RemoveAt(int itemIndex);
        void Reverse();
    }
}
