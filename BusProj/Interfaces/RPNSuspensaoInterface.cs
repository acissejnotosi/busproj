using BusProj.Repository.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusCore.Interfaces
{
    interface RPNSuspensaoInterface
    {

        int suspensaoRPNBuraco(Linha linhaID );
        int suspensaoRPNLombada(Linha linhaID);
        int suspensaoRPNPeso(Linha linhaID);
        int suspensaoRPNTotal(Linha linhaID);
    }
}
