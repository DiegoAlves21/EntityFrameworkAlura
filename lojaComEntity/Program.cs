using lojaComEntity.Entidades;
using Microsoft.Data.Entity;
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

            var categoria = contexto.Categorias.Include(c => c.Produtos).FirstOrDefault(c => c.ID == 1);

            foreach(var p in categoria.Produtos)
            {
                Console.WriteLine(p.Nome);
            }

            //Produto p = contexto.Produtos.Include(produto => produto.Categoria).FirstOrDefault(produto => produto.CategoriaID == 1);
            //Console.WriteLine(p.Nome);

            //Categoria c = new Categoria()
            //{
            //    Nome = "informática"
            //};

            //contexto.Categorias.Add(c);
            //contexto.SaveChanges();

            //Produto p = new Produto()
            //{
            //    Nome = "Mouse",
            //    Preco = 20,
            //    Categoria = c
            //};

            //contexto.Produtos.Add(p);
            //contexto.SaveChanges();

            //UsuarioDao dao = new UsuarioDao();
            //Usuario diego = dao.BuscarPorId(1);
            //diego.Nome = "Diego Alves";
            //dao.SaveChanges();

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
