using System;

namespace third_task {
    public class Calculator<T1, T2> where T1 : struct where T2: struct {

        double _t1;
        double _t2;

        public Calculator(T1 t1, T2 t2) {
            _t1 = Convert.ToDouble(t1);
            _t2 = Convert.ToDouble(t2);

            // double.TryParse(t1, out _t1);
            // double.TryParse(t2, out _t2);
            // if (
            //     double.IsNaN(_t2) || 
            //     double.IsInfinity(_t2) || 
            //     double.IsNaN(_t1) ||
            //     double.IsInfinity(_t1)
            // ) {
            //     throw new Exception("invalid Calculator agrs!");
            // }
        }

        public double Add() {            
            return _t1 + _t2;
        }

        public double Divide() {
            return _t1 / _t2;
        }

        public double Substract() {
            return _t1 - _t2;
        }

        public double Multiply() {
            return _t1 * _t2;
        }
    }   
}