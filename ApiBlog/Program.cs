using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using ApiBlog.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<PostagenDb>(options => options.UseInMemoryDatabase("items"));
builder.Services.AddSwaggerGen(c => 
{
    c.SwaggerDoc("v1", new OpenApiInfo 
    {
        Title = "Blog do ASP.NET",
        Description = "Estudando por paixão",
        Version = "v1"
    });
});

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c => 
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blog do ASP.NET API v1");
});

// Método get para obter somente um item
app.MapGet("/postagens/{id}", async (int id, PostagenDb db) => await db.Postagens.FindAsync(id));

// Método post para adicionar postagens
app.MapPost("/postagens", async (PostagenDb db, Postagem postagem) => 
{
    await db.Postagens.AddAsync(postagem);
    await db.SaveChangesAsync();
    return Results.Created($"/postagens/{postagem.Id}", postagem);
});

// Método put para atualizar um item já existente
app.MapPut("/postagens/{id}", async (int id, Postagem updatePostagem, PostagenDb db) => 
{
    var postagem = await db.Postagens.FindAsync(id);
    if(postagem is null) return Results.NotFound();
    postagem.Titulo = updatePostagem.Titulo;
    postagem.Assunto = updatePostagem.Assunto;
    postagem.Conteudo = updatePostagem.Conteudo;
    await db.SaveChangesAsync();
    return Results.NoContent();
});

// Método delete para remover um item
app.MapDelete("/postagens/{id}", async (int id, PostagenDb db) =>
{
    var postagem = await db.Postagens.FindAsync(id);
    if(postagem is null)
    {
        return Results.NotFound();
    }
    db.Postagens.Remove(postagem);
    await db.SaveChangesAsync();
    return Results.Ok();
});

app.Run();