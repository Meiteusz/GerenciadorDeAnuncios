<h1> GerenciadorDeAnuncios <h1>

<h3> Um simples porém eficaz sistema que gerencia anúncios, criado com C#(WindowsForms) e Banco de dados (SqlServer)</h3>

<h3> O sistema conta com as seguintes funcionalidades: </h3>

- Cadastro de anúncio com validações;
- Visualização para todos os anúncios com seus relatórios;
- Filtro de relatórios por nome do cliente e intervalo de tempo;
- Script que calcula o alcance do anúncio no mesmo momento que ele é validado e cadastrado
- Visualização completa do relatório com seus dados de um respectivo anúncio.


<h2>:page_with_curl: Como funciona:</h2> 

- Clique no botão <b>Cadastro de Anúncio</b>

<img src="https://github.com/Meiteusz/GerenciadorDeAnuncios/blob/main/TelaInicial.gif" width="600"><hr>

- Após ser redirecionado, informe os <b>dados do anúncio</b><br>
*obs: Data de início do anúncio não pode ser menor que a data atual, e a data de término não pode ser menor que a data de início*

<img src="https://github.com/Meiteusz/GerenciadorDeAnuncios/blob/main/TelaDeCadastro.gif" width="600"><hr>

- Para ver os <b>relatórios dos anúncios</b> criados basta voltar para a tela inicial e clicar no botão <b>Relatórios dos Anúncios</b> 
- Após ser redirecionado você verá uma GridView com todos os anúncios juntamente com seus relatórios já criados, podendo ser filtrados por <b>nome do cliente e intervalo de tempo</b>
- Para ver o relatório mais detalhado, clique na célula de um anúncio e clique no botão <b>Mostrar Relatório</b>

<img src="https://github.com/Meiteusz/GerenciadorDeAnuncios/blob/main/TelaDeRelatoriosDosAnuncios.gif" width="800"><hr>

- Irá abrir o relatório do anúncio escolhido com suas informações detalhadas
- Clique no botão <b>Ok</b> para voltar a tela de visualização de todos os anúncios 

<img src="https://github.com/Meiteusz/GerenciadorDeAnuncios/blob/main/VisualizacaoDoRelatorio.png" width="350"><hr>

<h2>:card_index_dividers: Como compilar o projeto:</h2>

1.  Após abrir o Visual Studio 2019 clique no botão <b>Clone a repository</b>, cole o link deste repositório e escolha o local de destino e clique no botão <b>clone</b>

2.  Usando o Microsoft SQL Server Management Studio 18 cole o [script do banco de dados](https://github.com/Meiteusz/GerenciadorDeAnuncios/blob/main/Banco_SQL.sql) e execute para criar o banco e as tabelas

3.  Para se conectar ao banco SqlServer vá em Tools > Connect to Database > em Data source, mude para <b>Microsoft SQL Server</b> > em Server name coloque um ponto(.) > abaixo em Connect to a database escolha o banco <b>GerenciadorDeAnuncios</b> e clique em <b>Ok</b>
 
4.  No Server Explorer > com o botão direito, clique na conexão > <b>propriedades</b> > copie a connection string e cole no lugar da que está setada na classe Conexao dentro do projeto Model obs:*[ConnectionString](https://github.com/Meiteusz/GerenciadorDeAnuncios/blob/main/ConnectionString.png)*

5. O projeto está pronto para ser compilado

<h2>:gear: Ferramentas utilizadas:</h2>

- Ambiente de desenvolvimento: Visual Studio 2019
- SGBD: Microsoft SQL Server Management Studio 18

*Sistema desenvolvido por Matheus Wietcovski Teixeira para o desafio de programação da Academia Técnica Capgemini com execução pela ProWay*
