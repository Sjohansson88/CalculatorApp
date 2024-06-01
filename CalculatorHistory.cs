using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CalculatorHistory
    {
        private readonly List<string> _history = new List<string>();

        public void AddHistory(string calculation)
        {
            _history.Add(calculation);
        }


        public IEnumerable<string> GetHistory()
        {
            return _history;
        }
    }
}
