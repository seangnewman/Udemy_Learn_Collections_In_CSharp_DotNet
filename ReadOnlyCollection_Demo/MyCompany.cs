using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyCollection_Demo
{
    class MyCompany
    {
        private readonly Dictionary<int, string> _employees = new Dictionary<int, string>();

        // TODO: populate employees

        public ReadOnlyDictionary<int, string> GetEmployees()
        {
            return new ReadOnlyDictionary<int, string>(_employees);
        }

        public ReadOnlyCollection<string> GetEmployeeNames()
        {
            return new ReadOnlyCollection<string>(_employees.Values.ToList());
        }
    }
}
