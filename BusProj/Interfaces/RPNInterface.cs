using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusProj.Interfaces
{
    interface RPNInterface
    {
        double CalculoRPN(double ocorrencia, double severidade, double deteccao);
        double buracoRPN(double ocorrencia, double severidade, double deteccao);
        double lombadaRPN(double ocorrencia, double severidade, double deteccao);

    }
}
