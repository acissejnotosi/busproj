using BusProj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusProj.Business
{
    public class RPN : RPNInterface
    {
        public double buracoRPN(double ocorrencia, double severidade, double deteccao)
        {
            throw new NotImplementedException();
        }

        public double CalculoRPN(double ocorrencia, double severidade, double deteccao)
        {
            double rpn;

            rpn = ocorrencia * severidade * deteccao;

            return rpn;
        }

        public double lombadaRPN(double ocorrencia, double severidade, double deteccao)
        {
            throw new NotImplementedException();
        }
    }
}
