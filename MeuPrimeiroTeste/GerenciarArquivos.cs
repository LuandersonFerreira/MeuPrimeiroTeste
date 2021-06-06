using System;
using System.IO;

namespace MeuPrimeiroTeste
{
    public class GerenciarArquivos
    {
        public bool ArquivoExiste(string NomeArquivo)
        {
            if (string.IsNullOrEmpty(NomeArquivo))
            {
                throw new ArgumentNullException("Nome do Arquivo");
            }
            return File.Exists(NomeArquivo);
        }
    }
}
