


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ck = Chilkat;

namespace CPS.Proof.DFSExtension
{
    public interface IChilkatInstantiator
    {
        ck.Rest GetChilkatInstance();
    }
}
