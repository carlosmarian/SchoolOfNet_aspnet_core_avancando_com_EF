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

Para migrações usa o "dotnet ef"
  dotnet ef --help
