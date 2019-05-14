using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContactos
{
    public static class Mikas
    {
        /// <summary>
        /// Fazer Escape de SQL
        /// </summary>
        /// <param name="s">String a dar escape</param>
        /// <returns>String escapada</returns>
        public static string EscapeSQL(string s)
        {
            return s.Replace("'", "''").Replace("%", "[%]");
        }

        /// <summary>
        /// Fazer Escape de SQL, mas somente os "'"
        /// </summary>
        /// <param name="s">String a dar escape</param>
        /// <returns>String escapada</returns>
        public static string EscapeSQLSQ(string s)
        {
            return s.Replace("'", "''");
        }
    }
}
