Mini Sipariş Yönetimi


# Bu projede .net 9.0 kullanildi.Eger bilgisayarinizda bulunmuyorsa alttaki linkten indirip kurabilirsiniz.
    
        -https://dotnet.microsoft.com/en-us/download


# Daha sonra proje için .net tool ları yuklendi
      -dotnet tool install --global dotnet-ef --version 9.0.2

# Veritabanı için EntityFrameWorkler ve PostgresSQL kullanılacagı için onunda baglantıları yuklendi
        -dotnet add package Microsoft.EntityFrameworkCore --version 9.0.2
        -dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.2
        -dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 9.0.3
        -dotnet add package Npgsql

# Kod içerisinde veritabanı sorguları yapmak için Dapper eklendi.
        -dotnet add package Dapper

# Alttaki komutlar ise veritabanı şemamızın kodlarımızla senkronize olması için kullanıldı.
        -dotnet ef migrations add InitialCreate
# Veritabanını güncellemek için kullanıldı
        -dotnet ef database update

# Ayrıca Front-end için Javascript, CSS ve bootstrap  yararlananıldı.Bootstrap kullanmak için _Layout.cshtml kısmına link eklendi


# PostgreSQL veritabanına baglantı saglandı.Tablolar oluştu fakat postman ile ya da manuel olarak hiçbir veri kaydedilemedi.Bu sorunu çözmek için çok ugraşıldı fakat bir türlü bulunamadı.Bu yüzden Product ve Customer da ekrana çıktı vermek için baglantı terimleri kullanılmadı.Order kısmında veritabanı olsaydı yapılacak GET ve POST işlemleri örnek olsun diye yazıldı.