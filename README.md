Projeto feito com Swagger, Fluente API, Testes Unitários com XUnit e EntityFramework na versao do Net Core 6.0.

API com CRUD em Vendas, Produtos e Usuários.

Baixar Instalador : Mysql Workbanch v. 8.0.31 para cima para rodar na base local.

Para rodar com seu BD local precisa mudar as configurações da string de conexão dentro do projeto Application => Startup.

Para criar as tabelas no banco rodas dotnet ef migrations add CriarTabelaProdutos no arquivo App.Data.

Email Administrador cadastrado:
andreluis@mail.com para liberar acesso do Bearer

Utilizar na consulta o Autorize com Bearer {Incluir chave criada ao fazer login}
Exemplo: Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiYW5kcmVsdWlzQG1haWwuY29tIiwianRpIjoiMDFiMTNiNmItMjc1Mi00YjhlLWFiYTYtNzMxYTgwZjFiNTVjIiwidW5pcXVlX25hbWUiOiJhbmRyZWx1aXNAbWFpbC5jb20iLCJuYmYiOjE3Mjc4MTQyNzksImV4cCI6MTcyNzg0MzA3OSwiaWF0IjoxNzI3ODE0Mjc5LCJpc3MiOiJFeGVtcGxvSXNzdWUiLCJhdWQiOiJFeGVtcGxvQXVkaWVuY2UifQ.plc4YaSWs3miQDF7c3fzGg5dXMzk6rMi4fBSWZTTFruqDyQr2TKqgJ3B0UULQKm1WKFGqGs4MHSGQUFKHqq82kRaX1dVNP8YC6FYyAaR-0KzNPns-ixIN5OESBHTAR9pfBqGP*fIZmfnJ9JE-xxFd7K-RiHEaVDqf2Y4m52UUBPwqAIjnovCwxBoCqrjqA45BrpiK08UeTIVyIS8A65QLqkLYOYKxDzHLKDTVSITdN13mknK1Nyu7ADNJ814HthnjB3boHTCcUNzGmmE3mjXNQYJkN1PCHwlYHsbyBCmqY27A0JFXL6*-EB7v-y9p2WHm5nbBIsoyLqMpo6Vzox4GQ
