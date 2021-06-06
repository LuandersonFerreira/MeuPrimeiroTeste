using MeuPrimeiroTeste;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace ProjetoDeTestes
{
    public class GerenciarArquivosTeste
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NomeArquivoExiste()
        {
            GerenciarArquivos ga = new GerenciarArquivos();
            bool verificador;

            verificador = ga.ArquivoExiste(@"C:\Windows\Regedit.exe");

            Assert.IsTrue(verificador);
        }

        [Test]
        public void NomeArquivoNaoExiste()
        {
            GerenciarArquivos ga = new GerenciarArquivos();
            bool verificador;

            verificador = ga.ArquivoExiste(@"C:Regedit.exe");

            Assert.IsFalse(verificador);
        }

        [Test]
        public void NomeArquivoNullOrEmpty_ThrowsArgumentNullException_UsingtryCatch()
        {
            GerenciarArquivos ga = new GerenciarArquivos();

            try
            {
                ga.ArquivoExiste("");
            }
            catch (ArgumentException)
            {
                //O teste foi um sucesso.
                return;
            }

            Assert.Fail("Falha esperada");
        }
    }
}