using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMeApp.WPF
{
    public static class CommonMethods
    {
        public static decimal OpenCalculator()
        {
            decimal resultt = decimal.Zero;
            var frm = new Calculator_WindowWPF();
            frm.ShowDialog();

            resultt = frm.TryGetResultOrDefault();

            return resultt;
        }
        public static decimal OpenCalculator(bool CloseOnEqual, out string HistoryInputs)
        {
            decimal resultt = decimal.Zero;
            var frm = new Calculator_WindowWPF(CloseOnEqual);
            frm.ShowDialog();

            resultt = frm.TryGetResultOrDefault();
            HistoryInputs = frm.HistoryInputs;

            return resultt;
        }
    }
}
