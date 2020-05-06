namespace Poirot.Viewmodel
{
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class DatabaseHelper
    {
        public static string dbFile = Path.Combine(Environment.CurrentDirectory, "servicesDb.db3");

        public static bool Insert<T>(T item)
        {
            bool result = false;

            using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int numbersOfRows = conn.Insert(item);
                if (numbersOfRows > 0)
                {
                    result = true;
                }
                return result;
            }
        }

        public static bool Update<T>(T item)
        {
            bool result = false;

            using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int numberOfRows = conn.Update(item);
                if (numberOfRows > 0)
                {
                    result = true;
                }

                return result;
            }
        }

        public static bool Delete<T>(T item)
        {
            bool result = false;

            using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int numberOfRows = conn.Delete(item);
                if (numberOfRows > 0)
                {
                    result = true;
                }

                return result;
            }
        }
    }
}
