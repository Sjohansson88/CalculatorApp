using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.XUnitTests
{
    public class HistoryTests
    {
        private readonly CalculatorHistory _history;

        public HistoryTests()
        {
            _history = new CalculatorHistory();
        }

        [Fact]
        public void AddToHistory_ShouldAddEntryToHistory()
        {
            var entry = "5 + 3 = 8";
            _history.AddHistory(entry);

            var result = _history.GetHistory();

            Assert.Contains(entry, result);
        }

        [Fact]
        public void GetHistory_ShouldReturnAllEntries()
        {
            var entry1 = "5 + 3 = 8";
            var entry2 = "10 - 2 = 8";

            _history.AddHistory(entry1);
            _history.AddHistory(entry2);

            var result = _history.GetHistory();

            Assert.Equal(2, result.Count());
            Assert.Contains(entry1, result);
            Assert.Contains(entry2, result);
        }
    }
}
