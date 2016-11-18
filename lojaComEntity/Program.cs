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

            PessoaFisica pf = new PessoaFisica()
            {
                Nome = "Guilherme",
                CPF = "14875186762",
                Senha = "123"
            };

            contexto.PessoasFisicas.Add(pf);

            PessoaJuridica pj = new PessoaJuridica()
            {
                Nome = "Guilherme",
                CNPJ = "789",
                Senha = "123"
            };

            contexto.PessoasJuridica.Add(pj);

            contexto.SaveChanges();
            Console.ReadLine();

            //Venda venda = ctx.Vendas.Include(v => v.ProdutosVenda).ThenInclude(pv => pv.Produto).FirstOrDefault();

            //foreach (var pvv in venda.ProdutosVenda)
            //{
            //    Console.WriteLine(pvv.Produto.Nome);
            //}

            //EntidadesContext ctx = new EntidadesContext();
            //var usuarioDao = new UsuarioDao();
            //var produtoDao = new ProdutoDao(ctx);

            //var renan = usuarioDao.BuscarPorId(1);
            //var venda = new Venda()
            //{
            //    Cliente = renan
            //};

            //ctx.Vendas.Add(venda);

            //var primeiroProduto = produtoDao.BuscarPorId(1);
            //var segundoProduto = produtoDao.BuscarPorId(2);

            //var produtoVenda1 = new ProdutoVenda()
            //{
            //    Venda = venda,
            //    Produto = primeiroProduto
            //};

            //ctx.ProdutosVenda.Add(produtoVenda1);
            //var produtoVenda2 = new ProdutoVenda()
            //{
            //    Venda = venda,
            //    Produto = segundoProduto
            //};

            //ctx.ProdutosVenda.Add(produtoVenda2);

            //ctx.SaveChanges();

            //ctx.Dispose();

            //EntidadesContext contexto = new EntidadesContext();
            //ProdutoDao dao = new ProdutoDao(contexto);

            //var resultado = dao.BuscaPorNomePrecoNomeCategoria(null, 25, null);

            //foreach (var p in resultado)
            //{
            //    Console.WriteLine(p.Nome);
            //}


            //var busca = from p in contexto.Produtos select p;
            //IList<Produto> resultado = busca.ToList();

            //foreach(var produto in resultado)
            //{
            //    Console.WriteLine(produto.Nome);
            //}


            //var categoria = contexto.Categorias.Include(c => c.Produtos).FirstOrDefault(c => c.ID == 1);

            //foreach(var p in categoria.Produtos)
            //{
            //    Console.WriteLine(p.Nome);
            //}

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
            //Console.ReadLine();
        }
    }
}
