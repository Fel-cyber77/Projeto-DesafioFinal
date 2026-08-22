using Projeto.Models;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/api/teste", () =>
{
    return new
    {
        mensagem = "API funcionando com sucesso!"
    };
});

app.MapPost("/api/cliente", (Cliente cliente) =>
{
    return new
    {
        mensagem = "Cliente recebido com sucesso!",
        nome = cliente.Nome,
        idade = cliente.Idade,
        cidade = cliente.Cidade
    };
});

app.MapPost("/api/produto", (Produto produto) =>
{
    double subtotal = produto.Quantidade * produto.ValorUnitario;

    return new
    {
        mensagem = "Produto recebido com sucesso!",
        nome = produto.Nome,
        quantidade = produto.Quantidade,
        valorUnitario = produto.ValorUnitario,
        subtotal = subtotal
    };
});

app.MapPost("/api/pedido", (Pedido pedido) =>
{
    double subtotal = pedido.CalcularSubtotal();

    return new
    {
        mensagem = "Pedido recebido com sucesso!",

        cliente = pedido.Cliente.Nome,
        cidade = pedido.Cliente.Cidade,

        produto = pedido.Produto.Nome,
        quantidade = pedido.Produto.Quantidade,
        valorUnitario = pedido.Produto.ValorUnitario,

        subtotal = subtotal
    };
});

app.Run();

