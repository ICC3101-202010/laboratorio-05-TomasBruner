using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;

namespace Laboratorio5
{
    class User
    {
        public delegate void EmailVerifiedEventHandler(object source, EventArgs args);
        public event EmailVerifiedEventHandler EmailVerified;
        protected virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, EventArgs.Empty);
            }

        }

        public void OnEmailSent(object source, EventArgs args)
        {
            Thread.Sleep(2000);
            Console.WriteLine("¿Quiere verificar su correo?");
            Console.WriteLine(" ");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                OnEmailVerified();
            }
            else
            {
                Console.WriteLine("No se verificará su correo");
            }
            Thread.Sleep(2000);
        }
        
    }
}

