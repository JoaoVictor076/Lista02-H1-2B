﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ListaH1.Infra.EmailService
{
    public class EmailConfig
    {
        public string Host { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

    }
}