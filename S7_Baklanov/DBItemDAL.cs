using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace S7_Baklanov
{
    class DBItemDAL<T> : IDBItemDAL<T> where T : IId
    {
        int counter = 1;
        public List<T> Items { get; set; }

        public DBItemDAL()
        {
            Items = new List<T>();
        }

        public void AddItem(T item)
        {
            item.Id = counter++;
            Items.Add(item);
        }
        public T FindById(int id)
        {
            T result = default(T);
            foreach (T item in Items)
            {
                if (item.Id == id)
                {
                    result = item;
                    break;
                }

            }
            return result;
        }
        public bool Delete(T item)
        {
            Items.Remove(item);
            return true;
        }

        public bool UpdateItem(T oldItem, T newItem)
        {
            int index = Items.IndexOf(oldItem);
            if (index >= 0)
            {
                Items[index] = newItem;
                return true;
            }
            return false;
        }

    }
}
