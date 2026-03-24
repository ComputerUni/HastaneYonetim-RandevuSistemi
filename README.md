# Proje_Hastane

Bu proje, bir hastane randevu ve hasta yönetim otomasyonunun Windows Forms (WinForms) ile hazırlanmış örnek uygulamasıdır. Proje C# (.NET 10) ile geliştirilmiş olup veritabanı erişimi için `Microsoft.Data.SqlClient` kullanır.

## Amaç

- Doktor, hasta ve sekreter işlemlerini yönetmek
- Randevu oluşturma, listeleme ve şikayet görüntüleme
- Doktor bilgilerinin güncellenmesi
- Duyuruların yönetimi

## Öne çıkan formlar (Formlar)

- `FrmGirisler` - Giriş seçenekleri (Doktor, Hasta, Sekreter)
- `FrmDoktorGiris` / `FrmDoktorDetay` - Doktor girişi ve doktor detay arayüzü
- `FrmDoktorBilgiDuzenle` - Doktor bilgilerini düzenleme
- `FrmHastaGiris` / `FrmHastaDetay` - Hasta girişi ve hasta detay arayüzü
- `FrmSekreterGiris` / `FrmSekreterDetay` - Sekreter girişi ve sekreter yönetim ekranı
- `FrmBrans` - Branş yönetimi
- `FrmRandevuListesi` - Randevu listeleme
- `FrmDuyurular` - Duyuru görüntüleme ve yönetimi
- `FrmHastaKayit` - Yeni hasta kayıt ekranı

(Not: Proje dosyalarında her form için `.Designer.cs` ve `.resx` kaynak dosyaları mevcuttur.)

## Önemli Sınıflar ve Bağlantı

- `SqlBaglantisi` - Veritabanı bağlantı sınıfı. İçinde `baglanti()` metodu ile `SqlConnection` döndürür.
  - Varsayılan bağlantı dizesi: `Data Source=YOUR_PC; Initial Catalog=HastaneProje; Integrated Security=True; TrustServerCertificate=True`
  - Bu bağlantı dizesini kendi ortamınıza göre (sunucu adı, veritabanı adı, kimlik bilgileri) güncellemeniz gerekir.

## Veritabanı (Tahmini tablolar ve kullanılan sütunlar)

Kod içinde doğrudan kullanılan tablolar ve sütunlar (projede daha fazlası olabilir):

- `Tbl_Doktorlar`
  - `DoktorAd` (string)
  - `DoktorSoyad` (string)
  - `DoktorTC` (string) — doktorun TC kimlik numarası
  - (muhtemel ek sütunlar: `DoktorBrans`, `DoktorSifre` vb.)

- `Tbl_Randevular`
  - `RandevuDoktor` (string) — randevuyu yapan doktorun adı
  - (Uygulamada `dataGridView` hücresinden index 7 kullanılarak şikayet/sikayet metni okunuyor; sütun sırasına göre `Sikayet` gibi bir sütun olmalıdır.)

- `Tbl_Hastalar`, `Tbl_Brans`, `Tbl_Duyurular` vb. — proje dosyalarında bu isimlerle formlar bulunduğundan veritabanında karşılıkları olmalıdır.

Aşağıda temel bir örnek tablo şeması görebilirsiniz (örnek maksatlı):

```sql
CREATE TABLE Tbl_Doktorlar (
    Id INT IDENTITY PRIMARY KEY,
    DoktorAd NVARCHAR(50),
    DoktorSoyad NVARCHAR(50),
    DoktorTC NVARCHAR(11),
    DoktorBrans NVARCHAR(50),
    DoktorSifre NVARCHAR(50)
);

CREATE TABLE Tbl_Randevular (
    Id INT IDENTITY PRIMARY KEY,
    RandevuTarih DATETIME,
    RandevuHastaAdi NVARCHAR(100),
    RandevuDoktor NVARCHAR(100),
    Sikayet NVARCHAR(MAX)
);
```

Bu SQL sadece uygulamayı çalıştırabilmeniz için örnektir — gerçek proje tabloları farklı olabilir.

## Gerekli Araçlar ve Kurulum

- Visual Studio 2022/2026 veya uyumlu bir IDE (Projede Visual Studio Community 2026 kullanılmıştır)
- .NET 10 SDK
- SQL Server (ör. SQL Server Express)
- NuGet paketi: `Microsoft.Data.SqlClient` (projede kullanılıyor)

Kurulum adımları:
1. Proje klasörünü Visual Studio ile açın (`.sln` dosyası üzerinden).
2. `SqlBaglantisi.cs` içindeki bağlantı dizesini kendi SQL Server ortamınıza göre güncelleyin.
3. Eğer veritabanı yoksa örnek tablo şemasını kullanarak bir veritabanı oluşturun veya mevcut veritabanını proje yapısına göre uyarlayın.
4. Projeyi derleyin ve çalıştırın.

## Çalıştırma

- Visual Studio'da çözümü açın, ana `Startup` projesini ayarlayın ve F5 ile çalıştırın.
- Doktor/Hasta/Sekreter girişleri ile ilgili hesaplar veritabanında oluşturulmuş olmalıdır.


