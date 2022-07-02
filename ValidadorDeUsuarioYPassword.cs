using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO20Junio2022
{
    internal class ValidadorDeUsuarioYPassword
    {
        //if (TextBox.Text == "Admin" && TextBox.Text == "1234")
        public bool Validador(string user, string pass)
        {
            if (user == "Admin" && pass == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
