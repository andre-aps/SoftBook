using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle_DB
{
    class Conexao
    {
        public static OracleConnection GetConnection()
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE=localhost:1521/XE;USER ID=id;PASSWORD=senha");
            return ora;
        }
    }
}
