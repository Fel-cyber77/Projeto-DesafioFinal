# Sistema Web de Pedidos

Este projeto foi desenvolvido como atividade prática para consolidar os conhecimentos trabalhados durante o curso de **Back-End com C#**.

A proposta é construir, passo a passo, um sistema simples de pedidos utilizando **C#**, **ASP.NET Core**, **HTML** e **JavaScript**, conectando uma interface web a uma API.

## Objetivo do projeto

O sistema permite informar os dados de um cliente e de um produto e, em seguida, registrar um pedido.

Durante o processamento, a aplicação:

* recebe os dados do cliente;
* recebe os dados do produto;
* calcula o subtotal do pedido;
* envia as informações para a API;
* retorna os dados processados para o navegador.

## Tecnologias utilizadas

* C#
* .NET 8
* ASP.NET Core
* HTML
* JavaScript
* Visual Studio Code
* Git
* GitHub

## Estrutura do projeto

```text
Projeto
│
├── Models
│   ├── Cliente.cs
│   ├── Produto.cs
│   └── Pedido.cs
│
├── wwwroot
│   ├── index.html
│   └── script.js
│
├── Program.cs
├── Projeto.csproj
└── appsettings.json
```

## Models

O projeto foi dividido em classes para representar as principais informações do sistema.

### Cliente

Armazena:

* nome;
* idade;
* cidade.

### Produto

Armazena:

* nome do produto;
* quantidade;
* valor unitário.

### Pedido

Relaciona os objetos `Cliente` e `Produto`, permitindo que a API receba todas as informações necessárias para processar o pedido.

## API

Foram criados endpoints utilizando ASP.NET Core.

```text
GET  /api/teste
POST /api/cliente
POST /api/produto
POST /api/pedido
```

O endpoint principal utilizado pela aplicação web é:

```text
POST /api/pedido
```

Ele recebe os dados do cliente e do produto e calcula o subtotal:

```text
Subtotal = Quantidade × Valor Unitário
```

## Interface Web

A interface permite preencher:

### Dados do cliente

* Nome
* Idade
* Cidade

### Dados do produto

* Produto
* Quantidade
* Valor Unitário

Ao clicar em **Registrar Pedido**, o JavaScript envia os dados para a API utilizando `fetch()`.

Após o processamento, o sistema apresenta uma confirmação contendo as principais informações do pedido e o subtotal calculado.

## Executando o projeto

No terminal, dentro da pasta do projeto:

```bash
dotnet run
```

Ou:

```bash
dotnet watch run
```

A aplicação será disponibilizada em um endereço semelhante a:

```text
http://localhost:5182
```

A porta pode variar de acordo com o ambiente.

## O que foi praticado

Durante o desenvolvimento deste projeto foram utilizados conceitos como:

* classes e objetos;
* propriedades;
* namespaces;
* organização em Models;
* requisições HTTP;
* endpoints GET e POST;
* JSON;
* ASP.NET Core Minimal API;
* HTML;
* JavaScript;
* `fetch()`;
* integração entre Front-End e Back-End;
* Git e GitHub;
* debug e testes da aplicação.

## Sobre o projeto

Este projeto tem finalidade educacional e foi construído de forma incremental, acompanhando a evolução dos conteúdos estudados durante as aulas.

A ideia não é apenas entregar um sistema funcionando, mas compreender como cada parte da aplicação se comunica: **interface, JavaScript, API e classes C#**.

Autor: Moises Santos Vasconcellos








