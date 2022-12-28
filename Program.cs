using System;
using Ef.Data;
using Ef.Models;

namespace EF{
    class Program{
        static void Main(string[]args){

            
            using( var context = new DadoContext() ){
                // var tag = new Tag {Nome = "Desenvolvimento Web", Slug = "JavaScript"};
                // context.Tags.Add(tag);
                // context.SaveChanges();

                var tag = context.Tags.FirstOrDefault(x => x.Id == 5);
                tag.Nome = "Denise";
                tag.Slug = "Atualizado";
                context.Update(tag);
                context.SaveChanges();
            }
        }
    }
}