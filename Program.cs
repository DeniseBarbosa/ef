using System;
using Ef.Data;
using Ef.Models;

namespace EF{
    class Program{
        static void Main(string[]args){

            
            using( var context = new DadoContext() ){
                var tag = new Tag {Nome = "ASP.NET", Slug = "aspenet"};
                context.Tags.Add(tag);
                context.SaveChanges();
            }
        }
    }
}