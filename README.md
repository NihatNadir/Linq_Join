# Linq_Join

## Yazarlar ve Kitaplar tabloları vardır ve her iki tablonun yapısı şu şekildedir:
- Yazarlar Tablosu (Authors)
- AuthorId (int) - Yazarın benzersiz kimliği
- Name (string) - Yazarın adı

- Kitaplar Tablosu (Books)
-- BookId (int) - Kitabın benzersiz kimliği
-- Title (string) - Kitabın başlığı
-- AuthorId (int) - Kitabın yazarının kimliği (Yazarlar tablosundaki AuthorId ile ilişkilidir)
