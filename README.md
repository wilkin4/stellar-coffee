# Stellar Coffee

This is a desktop application to manage a coffee shop created with C# and Microsoft SQL Server. This application was made using Visual Studio 2017 Community.

## Instructions

#### Connection string

In StellarCoffeeDesktop/App.config you configure the connection string to connect to the database with the corresponding server ip, database name, database user and password in the section:

    <connectionStrings>
      <add
        name="StellarCoffee"
        connectionString="Data Source=<server ip>;Initial Catalog=<database name>;Persist Security Info=True;User ID=<database user>;Password=<database password>"
        providerName="System.Data.SqlClient"
      />
    </connectionStrings>

#### Running migrations

In Package Manager Console run the followings commands with the corresponding migration name and startup project name:

##### enable-migrations

##### add-migrations \<migration name\> -StartUpProjectName \<startup project name\>
  
##### update-database -StartUpProjectName \<startup project name\> -verbose
