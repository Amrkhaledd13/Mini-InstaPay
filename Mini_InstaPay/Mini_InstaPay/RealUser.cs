﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_InstaPay
{
    internal interface RealUser
    {
        void Register(string name, string email, string password, string address, string phone);
        void Login(string email, string password);
        void UpdateProfile(string email, string? newName = null, string? newAddress = null, string? newPhone = null);
    }
}