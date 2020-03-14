using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace SisFarma.model.resouceBD
{
    class ConfigFireBase
    {
        IFirebaseConfig config = new FirebaseConfig();
        IFirebaseClient clientFireBase;

        public ConfigFireBase()
        {
            config.AuthSecret = "8q9WyVQfuvRecPJUNbYnl28QwNTosqxw1axFdWhu";
            config.BasePath = "https://sisfarmavitoria.firebaseio.com/Cientes/CSMPsEYrbTG5exeIwvvm";
            clientFireBase = new FireSharp.FirebaseClient(config);
        }

        public IFirebaseClient getFireBaseCliente()
        {
            return this.clientFireBase;
        }
        
    }
}
