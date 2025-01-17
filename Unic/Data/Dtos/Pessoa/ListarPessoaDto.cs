﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Unic.Models;

namespace Unic.Data.Dtos
{
    public class ListarPessoaDto
    {
        [Required]
        public string NomeCompleto { get; set; }

        [Required]
        public string Cpf { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }

        [Required]
        public DateTime DataCriaCao { get; set; }

        public Endereco Endereco { get; set; }

        
    }
}
