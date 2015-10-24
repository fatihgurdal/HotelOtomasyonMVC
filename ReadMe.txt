5-UI katmanýndaki Console, WinForm ya da MVC uygulamalarýnda bulunan web.config ve app.config dosyalarý içerisindeki connection string' ler trused_connection=true olarak ayarlýdýr. gerekli ise deðiþtirin.

Dosya boyutu azalmasý için packages folder' ýný temizledim. Solution' ý açtýktan sonra Tools --> NuGet Package Manager --> Manage Nuget Packages for Solution yaparak paketleri tekrar yüklemeniz gerekir.

Enable Migrations, update database yapmanýza gerek yoktur. herhangi bir UI projesini çalýþtýrdýðýnýzda database oluþacaktýr. 

UI projelerinde Student ve Firm entity' si için CRUD (GetById, GetAll, Insert, Update, Delete) örnekleri var. Bunlarýn tamamý Base' lerden geliyor. Bunlara ilave olarak da Student' a GetStudentsByLastname isminde base' lerde olmayan bir metot ekledim.

