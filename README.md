# asp-net-e-entity-framework
ASP.NET Core - Avançando com Entity Framework - Schoolofnet

Docker do MYSQL:
docker-compose.yml
Comand:
 docker-compose up db

Fonte foi copiado do 


Executar projeto:
 dotnet watch run

Para usar Mysql deve:
  Acessar https://www.nuget.org/
  Pesquisar pelo pacote:
    MySQL Entity Framework
    Selecionar o pacote: Pomelo.EntityFrameworkCore.MySql 
    copiar a linha de comando .NET CLI:
     exemplo: dotnet add package Pomelo.EntityFrameworkCore.MySql --version 2.2.0
    E executar no cmd
    Após o CLI baixar e instalar as bibliotecas é recomendado executar "dotnet restore"
    Garante que todas as bibliotecas definidas no arq estarão instaladas.

Para se conectar a qualquer banco é necessário ter um arquivo de configuração, isso para qualquer banco.
Neste arquivos estarão todas as conficurações do banco.
  no nosso caso criamos ele em Database\ApplicationDBContext.cs

CREATE DATABASE `efprojeto` /*!40100 COLLATE 'latin1_general_cs' */;

Executar projeto: 
dotnet watch run

Para migrações usa o "dotnet ef"
  dotnet ef --help

  Criar uma Migração:
  dotnet ef migrations add CategoriaAdd

  Atualizar o banco de dados:
  dotnet ef database update 
  *isso limpa os registros do banco


Sequencias de cursos:
https://www.schoolofnet.com/curso/aspnet/dotnet-core/aspnet-core-avancando-com-entity-framework/12465

https://www.schoolofnet.com/curso/aspnet/dotnet-core/api-rest-com-aspnet-core-parte-1/

https://www.schoolofnet.com/curso/aspnet/dotnet-core/api-rest-com-aspnet-core-parte-2/

https://www.schoolofnet.com/curso/aspnet/dotnet-core/api-rest-com-asp-net-core-hateoas/


