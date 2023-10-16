namespace lab07
{
    internal interface IGeneric<T>
    {
        void Add(T item);
        void Remove(int index);
        void Show(int index);
    }
}
