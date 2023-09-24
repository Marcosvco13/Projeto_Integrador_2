﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador.Models.Services
{
    public interface IAuthService
    {
        string GenerateJwtToken(string email, string role);
    }
}
