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
            UsuarioDao dao = new UsuarioDao();
            Usuario diego = dao.BuscarPorId(1);
            diego.Nome = "Diego Alves";
            dao.SaveChanges();

            //Usuario lucas = new Usuario()
            //{
            //    Nome = "lucas",
            //    Senha = "123"
            //};
            //manipulador.Salva(lucas);

            //Console.WriteLine("Salvou o usuário");
            //Console.WriteLine(diego.Nome);
            Console.ReadLine();
        }
    }
}
