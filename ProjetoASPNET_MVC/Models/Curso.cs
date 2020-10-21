using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoASPNET_MVC.Models
{
    public class Curso
    {
        [Key]
        public int idCurso { get; set; }
        [Required(ErrorMessage ="Entre com o nome do curso")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Entre com a descricao do curso")]
        [DataType(DataType.MultilineText)]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
    }
}