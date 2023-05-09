namespace T6_Baklanov
{
    internal interface IDBItemDAL
    {
        void Add(Car car);
        void Delete(Car car);
        Car FindById(int id);
        void Update(Car car);
    }
}