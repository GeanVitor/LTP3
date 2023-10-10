using Blog.Models;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Services
{
    public static class BlogService
    {
        static List<Postagen> Postagens { get; }
        static int nextId = 3;

        static BlogService()
        {
            Postagens = new List<Postagen>
            {
                new Postagen { Id = 1, Titulo = "Java", Assunto = "Programação" , Conteudo = "java e uma linguagen orientada a objetos"},
                new Postagen { Id = 2, Titulo = "javascript", Assunto = "Programação" , Conteudo = "Javascript e uma liguagen web" }
            };
        }

        public static List<Postagen> GetAll() => Postagens;

        public static Postagen? Get(int id) => Postagens.FirstOrDefault(p => p.Id == id);

        public static void Add(Postagen postagen)
        {
            postagen.Id = nextId++;
            Postagens.Add(postagen);

        }

        public static void Delete(int id)
        {
            var postagen = Get(id);
            if (postagen is null)
                return;

            Postagens.Remove(postagen);
        }

        public static void Update(Postagen postagen)
        {
            var index = Postagens.FindIndex(p => p.Id == postagen.Id);
            if (index == -1)
                return;

            Postagens[index] = postagen;
        }
    }
}