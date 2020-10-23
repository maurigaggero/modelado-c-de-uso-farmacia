﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_farmacia
{
    public class Medicamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Laboratorio { get; set; }
        [Required]
        public DateTime Fecha_Vencimiento { get; set; }
        public string Unidad { get; set; }
    }
}
