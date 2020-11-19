	Yüklenen paketler
	1) Paketleri yükle
	Microsoft.EntityFrameworkCore  ( EF nin en temel paketi )
	Microsoft.EntityFrameworkCore.Relational
	Microsoft.EntityFrameworkCore.SqlServer
	Microsoft.EntityFrameworkCore.Tools ( package manager console üzerinden komutlarımı vermemi sağladı )

	2) Tablolarını oluştur ( yani class larını )

	3) Context ini oluştur ve tablolarını set et

	4) Startup.cs e AddDbContext ile bir context kullanacağımı bildir ve connection string i belirt

	5) appsettings.json üzerinden connection string ayarla

	6) işlemlerini add-migration komutuyla kayıt altına al ve sonrasında update-database ile db ni güncelle
	
	package komutları
	add-migration migrationname
	update-database