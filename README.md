# LINQ_1

Coleções de Dados
O código define quatro coleções de dados diferentes:
1. lista_nomes: Uma lista de strings contendo nomes de pessoas.
2. lista_numeros: Uma lista de números inteiros.
3. lista_produtos: Um dicionário que mapeia nomes de produtos para seus preços.
4. lista_estados: Um dicionário que mapeia nomes de cidades para seus respectivos estados ou países.
Funcionalidades Implementadas
1. Consulta Simples com LINQ
• O botão "btnExecutar" executa uma consulta LINQ simples na lista de nomes. O usuário insere um texto na caixa de texto "txtConsulta," e o código retorna os nomes que começam com o texto inserido.
2. Filtragem com "Where"
• O botão "btnWhere" realiza uma filtragem na lista de nomes com base no texto inserido na caixa de texto "txtConsulta," retornando nomes que contêm o texto em qualquer parte do seu conteúdo.
3. Ordenação com "OrderBy"
• O botão "btnOrderBy" ordena os elementos da coleção de produtos por seus nomes (chaves) e exibe os resultados na lista.
4. Agrupamento com "GroupBy"
• O botão "btnGroupBy" agrupa os elementos da coleção de estados por seu valor (país) e exibe os estados agrupados.
5. Agregação com Funções de Agregação
• O botão "btnAgregacao" demonstra algumas funções de agregação, como Count, Average, Sum, Min, Max, e Aggregate, aplicadas às coleções de nomes e números.
6. Operadores de Elemento com "FirstOrDefault," "LastOrDefault" e "ElementAtOrDefault"
• O botão "btnOperadoresDeElemento" demonstra o uso de operadores de elemento, como FirstOrDefault, LastOrDefault, e ElementAtOrDefault, aplicados à coleção de números.
7. Consultas Lambda
• O botão "btnLINQLambda" mostra o equivalente das consultas LINQ usando expressões Lambda, incluindo seleção, filtragem, ordenação e agrupamento.
