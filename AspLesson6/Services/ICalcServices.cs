using System;

namespace AspLesson6.Services
{
    public interface ICalcServices
    {
        double Div(double x,double y);
        double Mul(double x, double y);

        double Add(double x, double y);
        double Sub(double x, double y);
    }
}
