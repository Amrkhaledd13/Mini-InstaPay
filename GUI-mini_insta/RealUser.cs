using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_InstaPay
{
    internal interface RealUser
    {
        string Register(string name, string email, string password, string address, string phone);
        User Login(string email, string password);
        void UpdateProfile(string email, string? newName = null, string? newAddress = null, string? newPhone = null);
    }
}
