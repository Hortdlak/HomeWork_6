using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    public interface ICalc
    {
        double Result { get; set; }

        #region double
        void Sum(double x);
        void Subtract(double x);
        void Divide(double x);
        void Multiply(double x);
        #endregion

        #region pseudo - int
        void Sum(int x);
        void Subtract(int x);
        void Divide(int x);
        void Multiply(int x);

        #endregion

        void CancelLast();


        event EventHandler<EventArgs> MyEventHandler;
    }
}
