namespace S7_Baklanov
{
    internal interface IDBItemDAL<T> where T : IId
    {
        List<T> Items { get; set; }

        void AddItem(T item);
        bool Delete(T item);
        T FindById(int id);
        bool UpdateItem(T oldItem, T newItem);
    }
}