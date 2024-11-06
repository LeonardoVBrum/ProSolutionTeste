using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using DesafioProSolutionsAPI.Data;
using DesafioProSolutionsAPI.Models;

namespace DesafioProSolutionsAPI.Controllers
{
    public class ArquivosController : ApiController
    {
        private ArquivoDbContext _context = new ArquivoDbContext();

    

        // Endpoint para Upload de Arquivo
        [HttpPost]
        public IHttpActionResult UploadArquivo()
        {
            var arquivo = HttpContext.Current.Request.Files["file"];

            if (arquivo == null)
                return BadRequest("Nenhum arquivo enviado.");

            // Vai verificar o caminho para o servidor
            var caminhoArquivo = Path.Combine(HttpContext.Current.Server.MapPath("~/App_Data/Uploads"), arquivo.FileName);

            // Vai verificar se o arquivo é valido (não .exe ou .bat)
            var tipoArquivo = Path.GetExtension(arquivo.FileName).ToLower();
            if (tipoArquivo == ".exe" || tipoArquivo == ".bat")
                return BadRequest("Tipo de arquivo inválido.");

            // Verificar o tamanho do arquivo (não pode ser maior que 10MB)
            if (arquivo.ContentLength > 10 * 1024 * 1024)
                return BadRequest("O arquivo não pode ser maior que 10MB.");

            // Salvar o arquivo no caminho especificado
            arquivo.SaveAs(caminhoArquivo);

            // Criar um novo objeto Arquivo
            var novoArquivo = new ArquivosModel
            {
                NomeArquivo = arquivo.FileName,
                CaminhoArquivo = caminhoArquivo,
                TamanhoArquivo = arquivo.ContentLength,
                DataUpload = DateTime.Now,
                TipoArquivo = tipoArquivo
            };

            // Adicionar o arquivo ao banco de dados
            _context.Arquivos.Add(novoArquivo);
            _context.SaveChanges();

            return Ok(new { CaminhoArquivo = caminhoArquivo });
        }

        // Endpoint para Download de Arquivo
        [HttpGet]
        public IHttpActionResult BaixarArquivo(int id)
        {
            var arquivo = _context.Arquivos.FirstOrDefault(a => a.Id == id);

            if (arquivo == null)
                return NotFound();

            // Ler  arquivo no banco de dados
            var bytesArquivo = File.ReadAllBytes(arquivo.CaminhoArquivo);

            // Retornar o arquivo como resposta para download
            return Ok(bytesArquivo);
        }
    }
}
