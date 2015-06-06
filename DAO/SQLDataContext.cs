using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SQLDataContext
    {
        static SQL_QUANLYTHUVIENDataContext m_db;
        public static SQL_QUANLYTHUVIENDataContext SQLData
        {
            get { return m_db; }
            set { m_db = value; }
        }

        public static bool IsLoad { get; set; }
        public static void CreateDataContext()
        {
            m_db = new SQL_QUANLYTHUVIENDataContext();
            IsLoad = true;
        }
    }
}
