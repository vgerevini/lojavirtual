using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TVG.LojaVirtual.Dominio.Entidade
{
    public class EmailConfiguracoes
    {
        public bool UsarSsl = false;
        public string ServidorSmtp = "smtp.conferironline.com.br";
        public int ServidorPorta = 587;
        public string Usuario = "tvg";
        public bool EscreverArquivo = false;
        public string PastaArquivo = @"C:\EnvioEmail";
        public string De = "tvg@tvg.com";
        public string Para = "vgerevini@gmail.com";
    }
}
