using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConstraints
{
    public class DbConstraints
    {
        private const string _connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\mayur1.jain\documents\visual studio 2013\Projects\BasicCrudOperations\BasicCrudOperations\EmpDatabase.mdf;Integrated Security=True";

        public string ConnectionString
        {
            get
            { 
                return _connectionString;
            }
            
        }
    }
}
