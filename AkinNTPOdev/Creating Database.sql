-- Ogrenci tablosu
CREATE TABLE tblOgrenciler (
    OgrenciID INT PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(50),
    Soyad NVARCHAR(50),
    Numara NVARCHAR(20)
);

-- Ogretmen tablosu
CREATE TABLE tblOgretmenler (
    OgretmenID INT PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(50),
    Soyad NVARCHAR(50),
    TC NVARCHAR(20)
);
