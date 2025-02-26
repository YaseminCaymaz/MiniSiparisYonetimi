Mini Sipariş Yönetimi


# Bu projede .net 9.0 kullanildi.Eger bilgisayarinizda bulunmuyorsa alttaki linkten indirip kurabilirsiniz.
    
        -https://dotnet.microsoft.com/en-us/download


#Bootstrap yuklemek için:
   
        -dotnet tool install --global dotnet-ef --version 9.0.2
        -dotnet add package Microsoft.EntityFrameworkCore --version 9.0.2
        -dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.2
        -dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 9.0.3
        -dotnet add package Npgsql
        -dotnet add package Dapper
        -dotnet ef migrations add InitialCreate
        -dotnet ef database update