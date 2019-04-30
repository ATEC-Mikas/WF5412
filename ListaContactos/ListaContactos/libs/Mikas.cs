using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContactos
{
    public static class Mikas
    {
        public static string EscapeSQL(string s)
        {
            return s.Replace("'", "''").Replace("%", "[%]");
        }

        public static string EscapeSQLSQ(string s)
        {
            return s.Replace("'", "''");
        }
    }
}
