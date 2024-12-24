using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_InstaPay
{
    internal class User
    {
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address {  get; set; }
    public string PasswordHash { get; set; }
     public bool Suspended { get; set; }
     public User(string iD,string name,string email,string phone,string address,string passwordHash) { 
        Id=iD;
            Name=name;
            Email=email;
            Phone=phone;
            Address=address;
            PasswordHash=passwordHash;
            Suspended = false;
        }

    }
}
