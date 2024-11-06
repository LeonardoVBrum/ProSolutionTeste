using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesafioProSolutionsAPI.Models
{
    public class ArquivosModel
    {
        public int Id { get; set; }
        public string NomeArquivo { get; set; }
        public string CaminhoArquivo { get; set; }
        public long TamanhoArquivo { get; set; }
        public DateTime DataUpload { get; set; }
        public string TipoArquivo { get; set; }
    }
}