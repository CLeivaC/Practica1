using Practica1.MailServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class NRecuperarPassword
    {
        public string recoverPasssword(string userRequesting)
        {
            return new MasterMailServer().recoverPasssword(userRequesting);
        }
    }
}
