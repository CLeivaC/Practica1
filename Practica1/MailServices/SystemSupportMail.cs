using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.MailServices
{
    class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail() {

            senderMail = "soporteaplicacionapp1@gmail.com";
            password = "havbubxkqpqbrxzf";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmptClient();
        
        }
    }
}
