using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMeApp.WPF.Me
{
    class BtnsCommandsCtrl
    {
        //Numbers
        public ActionCommand Btn_Num_0 { set; get; }
        public ActionCommand Btn_Num_1 { set; get; }
        public ActionCommand Btn_Num_2 { set; get; }
        public ActionCommand Btn_Num_3 { set; get; }
        public ActionCommand Btn_Num_4 { set; get; }
        public ActionCommand Btn_Num_5 { set; get; }
        public ActionCommand Btn_Num_6 { set; get; }
        public ActionCommand Btn_Num_7 { set; get; }
        public ActionCommand Btn_Num_8 { set; get; }
        public ActionCommand Btn_Num_9 { set; get; }

        //Operations
        public ActionCommand Btn_Dot { set; get; }
        public ActionCommand Btn_Plus { set; get; }
        public ActionCommand Btn_Minus { set; get; }
        public ActionCommand Btn_Multiply { set; get; }
        public ActionCommand Btn_Divide { set; get; }
        public ActionCommand Btn_Equal { set; get; }
        public ActionCommand Btn_Symbol { set; get; }
        public ActionCommand Btn_Remainder { set; get; }

        //Controls
        public ActionCommand Btn_Clean { set; get; }
        public ActionCommand Btn_BackSpace { set; get; }

        public ActionCommand Btn_Exit { set; get; }
        


        public BtnsCommandsCtrl()
        {

        }
    }
}
