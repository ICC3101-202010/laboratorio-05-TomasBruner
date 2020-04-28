using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5
{
    class RegisterEventArgs : EventArgs
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string VerificationLink { get; set; }
    }
}
