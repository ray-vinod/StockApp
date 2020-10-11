using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace StockApp.Models.Helpers
{
    public class TableHeading
    {
        private static List<string> _colsName;
        public static List<string> TableHeadingName<T>(T name) where T : BaseTable
        {
            _colsName = new List<string>();
            PropertyInfo[] tableName = typeof(T).GetProperties();


            foreach (PropertyInfo col in tableName)
            {

                _colsName.Add(col.Name.GetType().Name);
            }


            return _colsName;
        }
    }
}
