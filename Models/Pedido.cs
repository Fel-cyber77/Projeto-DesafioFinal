namespace Projeto.Models;

public class Pedido
{
    public Cliente Cliente { get; set; } = new Cliente();

    public Produto Produto { get; set; } = new Produto();

    public double CalcularSubtotal()
    {
        return Produto.Quantidade * Produto.ValorUnitario;
    }
}