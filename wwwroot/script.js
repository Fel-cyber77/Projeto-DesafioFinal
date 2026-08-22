async function registrarPedido() {

    const nomeCliente = document.getElementById("nomeCliente").value;
    const idadeCliente = document.getElementById("idadeCliente").value;
    const cidadeCliente = document.getElementById("cidadeCliente").value;

    const nomeProduto = document.getElementById("nomeProduto").value;
    const quantidadeProduto = document.getElementById("quantidadeProduto").value;
    const valorUnitario = document.getElementById("valorUnitario").value;

    const pedido = {
        cliente: {
            nome: nomeCliente,
            idade: Number(idadeCliente),
            cidade: cidadeCliente
        },

        produto: {
            nome: nomeProduto,
            quantidade: Number(quantidadeProduto),
            valorUnitario: Number(valorUnitario)
        }
    };

    const resposta = await fetch("/api/pedido", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(pedido)
    });

    const resultado = await resposta.json();

    console.log(resultado);

    alert(
        "Pedido registrado com sucesso!\n" +
        "Cliente: " + resultado.cliente + "\n" +
        "Produto: " + resultado.produto + "\n" +
        "Quantidade: " + resultado.quantidade + "\n" +
        "Subtotal: R$ " + resultado.subtotal
    );
}
