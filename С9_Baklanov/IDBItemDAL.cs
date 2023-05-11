using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C9_Baklanov 
{
    internal interface IDBItemDAL<T> where T : IId
    {
        List<T> Items { get; set; }
        void AddItem(T item);
        T FindById(int id);
        bool Delete(T item);
        bool Update(T oldItem, T newItem);
    }
}