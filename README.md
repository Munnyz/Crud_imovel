# Crud de imovel feito em C# com Forms e SQL
Cadastro de imóvel e Cadastro de endereço, Criar(Inserir), Listagens e exclusão usando SQL.

### Como atualizar o banco de dados do projeto:
O Banco de dados já na pasta, então abra o projeto no Visual Studio e:

1 - Abra a aba de "Gerenciador de Servidores" e Conectar-se a um Banco de dados

2 - Escolha o arquivo na pasta do projeto "Netimovel.mdf"

3 - Logo após Atualize

4- Clique com botão direito e pegue a "Cadeia de Conexão" que fica em "Propriedades";

5 - Copie e cole nas strings de Conexão(SqlConnection) do projeto, no imovel.cs e CadEnderecos.cs

O nome do banco = Netimoveis.mdf, são 2 tabelas Utilizadas.  Uma com foreign key e outra principal.
