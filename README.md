# Sistema de Gestão de Pedidos - Loja Virtual

Este projeto é um sistema de gestão de pedidos simples, desenvolvido em C#, que permite o cadastro de produtos e clientes, a criação e finalização de pedidos, além de consultas sobre os produtos e pedidos cadastrados.

## Funcionalidades

- Cadastro de produtos (físicos e digitais).
- Cadastro de clientes.
- Criação e finalização de pedidos.
- Consulta de produtos, clientes e pedidos.
  
## Pré-requisitos

Antes de rodar o projeto, certifique-se de que você tenha o seguinte instalado:

- .NET SDK 6.0 ou superior: [Baixar .NET SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- Um editor de código ou IDE como Visual Studio ou Visual Studio Code.

## Como Executar o Projeto

1. **Clone o repositório**:
   git clone https://github.com/GuilhermeBobsin/LojaOnlineOOP

2. **Navegue até o diretório do projeto:**
    cd LOJAONLINEOOP

3. **Restaure as dependências (se houver):**
    dotnet restore

4. **Execute o programa:**
    dotnet run

*O programa será executado no terminal/console e você verá as saídas das operações de cadastro de produtos, clientes, criação de pedidos, e suas respectivas consultas.*

## Estrutura do Projeto
O projeto contém as seguintes classes principais:

Produto: Representa um produto genérico.
ProdutoFisico e ProdutoDigital: Especializações de Produto para produtos físicos e digitais, respectivamente.
Cliente: Representa um cliente da loja.
Pedido: Contém informações sobre os produtos adquiridos por um cliente.
Loja: Responsável por gerenciar os cadastros e pedidos.

## Exemplo de uso:
Ao rodar o programa, ele:

Cadastra produtos (físico e digital).
Cadastra um cliente.
Cria um pedido para o cliente.
Adiciona produtos ao pedido.
Calcula o total do pedido e o finaliza.
Exibe a lista de produtos, clientes e pedidos cadastrados.

## Contribuição
Se você deseja contribuir para o projeto, siga os seguintes passos:

Fork o repositório.
Crie um branch para sua feature (git checkout -b feature/nome-da-feature).
Commit suas mudanças (git commit -m 'Adicionei nova feature').
Dê um push no seu branch (git push origin feature/nome-da-feature).
Abra um pull request.

**Link do vídeo explicando o projeto, e depurando linha por linha:**
## https://drive.google.com/file/d/1f9ON9bDpb4rRBj5LScjByqxFmD0GAYD3/view?usp=sharing

