using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.Configuration;


namespace Licorera.Models
{
    public class Login
    {


        [RegularExpression("\\d{1,12}[A-Z]{2}[A-Z]{1}")]
        public string? Usuario { get; set; }

        public string? Contrasena { get; set; }



        public Login(string usuario, string contrasenha)
        {

            Usuario = usuario;

            Contrasena = contrasenha;

        }

        public Login() { }
    }
}
