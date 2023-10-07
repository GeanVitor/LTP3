using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog.DB
{
    public record Post
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Assunto { get; set; }
        public string? Conteudo { get; set; }
    }

    public class PostDB
    {
        private static List<Post> _posts = new List<Post>()
        {
            new Post { Id = 1, Titulo = "Montemagno, Post shaped like a great mountain", Assunto = "gastronomia", Conteudo = "akdbhajdba" },
            new Post { Id = 2, Titulo = "The Galloway, Post shaped like a submarine, silent but deadly", Assunto = "gastronomia", Conteudo = "akdbhajdba" },
            new Post { Id = 3, Titulo = "The Noring, Pizza shaped like a Viking helmet, where's the mead", Assunto = "gastronomia", Conteudo = "akdbhajdba" }
        };

        public static List<Post> GetPosts()
        {
            return _posts;
        }

        public static Post? GetPost(int id)
        {
            return _posts.SingleOrDefault(post => post.Id == id);
        }

        public static void CreatePost(Post post)
        {
            _posts.Add(post);
        }

        public static Post UpdatePost(Post update)
        {
            var existingPost = _posts.Find(post => post.Id == update.Id);
            if (existingPost != null)
            {
                existingPost.Titulo = update.Titulo;
                existingPost.Assunto = update.Assunto;
                existingPost.Conteudo = update.Conteudo;
            }
            return update;
        }

        public static void RemovePost(int id)
        {
            _posts.RemoveAll(post => post.Id == id);
        }
    }
}
