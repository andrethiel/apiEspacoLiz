﻿using System;

namespace apiEspacoLiz.Models
{
    public class Users
    {
        public Users()
        {
            CriadoEm = DateTime.Now;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
