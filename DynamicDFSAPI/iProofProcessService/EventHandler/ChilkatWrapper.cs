





using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ck=Chilkat;

namespace CPS.Proof.DFSExtension
{
    public class ChilkatWrapper:IChilkatInstantiator
    {
		ck.Rest rest;

        private string _unlockKey = AppParams.GetAppSettings("UnlockKey");

        private bool _isUnlocked = false;

        public  ChilkatWrapper()
		{
            var chilkatGlob = new ck.Global();

            _isUnlocked = chilkatGlob.UnlockBundle(_unlockKey);

            rest =new ck.Rest();
		}
		
        public  ck.Rest GetChilkatInstance()
        {
			return rest;
        }
    }
}
