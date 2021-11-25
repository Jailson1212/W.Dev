﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace W.Dev.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Nome { get; set; }
        public string Instagram { get; set; }
        public string Logo { get; set; }
        public string Banner { get; set; }
        public TimeSpan Dias { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }


    }
}