using lojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadesContext contexto = new EntidadesContext();
            Usuario diego = new Usuario()
            {
                Nome = "Diego",
                Senha = "123"
            };
            contexto.Usuarios.Add(diego);
            contexto.SaveChanges();
            contexto.Dispose();

            Console.WriteLine("Salvou o usuário");
            Console.ReadLine();
        }
    }
}
