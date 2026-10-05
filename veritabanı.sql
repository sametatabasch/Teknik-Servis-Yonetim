Create Database teknik_servis character set utf8mb4 collate utf8mb4_general_ci;

Create USER 'teknik_servis_user'@'localhost' IDENTIFIED BY '123456';
Grant ALL PRIVILEGES ON teknik_servis.* TO 'teknik_servis_user'@'localhost';
Flush Privileges;

use teknik_servis;

Create Table calisanlar(
	id int primary key auto_increment,
	ad varchar(50) not null,
	soyad varchar(50) not null,
	email varchar(100) not null unique,
	telefon varchar(15) not null unique,
	yetki varchar(50) not null,
	maas decimal(10,2) not null,
	foto varchar(255) not null,
	adres varchar(255) not null,
	tc varchar(11) not null unique,
	d_tarihi date not null,
	baslama_tarihi date not null,
	cinsiyet enum('Erkek', 'Kadın') not null,
);
