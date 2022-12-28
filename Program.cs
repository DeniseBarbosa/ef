using System;
using Ef.Data;
using Ef.Models;

namespace EF{
    class Program{
        static void Main(string[]args){

            
            using var context = new DadoContext();
                // var tag = new Tag {Nome = "Desenvolvimento Web", Slug = "JavaScript"};
                // context.Tags.Add(tag);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x => x.Id == 5);
                // tag.Nome = "Denise";
                // tag.Slug = "Atualizado";
                // context.Update(tag);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x => x.Id == 5);
                // context.Remove(tag);
                // context.SaveChanges();

                // var tags = context.Tags;
                // foreach (var tag in tags)
                // {
                //     Console.WriteLine(tag.Slug);
                // }


                var usuario = new Usuario
                { Nome="Denise Prinsloo",
                  Slug = "estudante",
                  Email = "denise@gmail.com",
                  Bio = "Analise e Desenvolvimento de Sistemas",
                  Image = "https://denise.com",
                  SenhaHash = "24865"

                };



                var categoria = new Categoria
                {
                    Nome = "Backend",
                    Slug = "backend"
                };




                var post = new Post
                {
                    Autor = usuario,
                    Categoria = categoria,
                    Corpo = "<p>Aqui é um paragrafo</p>",
                    Slug = "voce-estuda-muito",
                    Summario = "Eu estou aprendendo EF core",
                    Titlo = "Começando com EF core",
                    DataCriacao = DateTime.Now,
                    DataUltimaAtualizacao = DateTime.Now
                };
            
                context.Posts.Add(post);
                context.SaveChanges();
        }
    }
}