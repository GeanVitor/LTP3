using Microsoft.OpenApi.Models;
using Blog.DB;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Blog API", Description = "Testando o asp.net", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "PostStore API V1");
});
//Rota get
app.MapGet("/postagens/{id}", (int id) =>
{
    var existingPost = PostDB.GetPosts().FirstOrDefault(p => p.Id == id);
    if (existingPost != null)
    {
        Console.WriteLine("A postagen não existe!!"); ;
    }
    PostDB.GetPost(id);
});

//Rota para retornar todas as postagens
app.MapGet("/postagens", () => PostDB.GetPosts());

//Rota de Criação das postagens
app.MapPost("/postagens", (Post post) =>
{
    var existingPost = PostDB.GetPosts().FirstOrDefault(p => p.Titulo == post.Titulo);

    if (existingPost != null)
    {
        Console.WriteLine("A postagem já existe, o registro será atualizado");
        PostDB.UpdatePost(post);
    }
    else
    {
        PostDB.CreatePost(post);
        Console.WriteLine($"Registros Criados! Titulo:{post.Titulo}, Assunto:{post.Assunto}");
    }
});

//Rota de atualização
app.MapPut("/postagens", (Post post) => PostDB.UpdatePost(post));

app.MapDelete("/postagens/{id}", (int id) => PostDB.RemovePost(id));

app.Run();