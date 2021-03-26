# Projeto SoftBook
![GitHub top language](https://img.shields.io/github/languages/top/andre-aps/softbook)
![GitHub repo size](https://img.shields.io/github/repo-size/andre-aps/softbook)
![GitHub last commit](https://img.shields.io/github/last-commit/andre-aps/softbook)

O projeto SoftBook foi desenvolvido utilizando a linguagem de programação C# e permite realizar um CRUD básico simulando um sistema de biblioteca.

## Características

- Operações:
    - Consulta
    - Cadastro   
    - Alteração 
    - Remoção

## Começando

Essas instruções farão com que você tenha uma cópia do projeto em sua máquina local.

## Pré-requisitos

É necessário instalar a IDE [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/) para compilar e executar a aplicação juntamente com o Oracle Data Provider (pode ser instalado pela própria IDE). Também é necessário instalar o banco de dados [Oracle Database XE](https://www.oracle.com/database/technologies/xe-downloads.html) e o [SQL Developer](https://www.oracle.com/br/tools/downloads/sqldev-v192-downloads.html) para o gerenciamento da base de dados.

## Execução

Após a instalação da IDE, clique em `Arquivo > Abrir > Projeto/Solução` e localize o arquivo `Oracle_DB.sln`. Em seguida, dê um duplo clique no arquivo `Conexao.cs` presente no Gerenciador de Soluções.

![Form1_soft](https://user-images.githubusercontent.com/37241913/74114449-df2b1700-4b88-11ea-869d-ccd40a1893b1.PNG)

Altere o nome de usuário e senha (fornecido no momento da instalação do banco de dados).

![class_conn](https://user-images.githubusercontent.com/37241913/74114417-b7d44a00-4b88-11ea-936d-e16fb335d02b.PNG)

Utilize o SQL Developer para criar uma conexão com o banco de dados, a tabela Clientes e os procedimentos armazenados (utilize as informações do arquivo `Stored_Procedure.txt`).

Agora, basta clicar em `iniciar`.

![compilar](https://user-images.githubusercontent.com/37241913/73599503-f3389e00-4522-11ea-8373-c3893bedc225.png)

A aplicação será executada conforme a imagem abaixo.

![softbook](https://user-images.githubusercontent.com/37241913/74115353-a6da0780-4b8d-11ea-8e95-da1b7b2521a3.png)

## Versão
Consulte as [tags neste repositório](https://github.com/andre-aps/SoftBook/tree/v1.1).

## Autor
<b> André Pereira da Silva </b> | [LinkedIn](https://www.linkedin.com/in/andre-aps)
