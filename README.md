# Linq_Join

## Yazarlar ve Kitaplar tabloları vardır ve her iki tablonun yapısı şu şekildedir:
### Yazarlar Tablosu (Authors)
- AuthorId (int) - Yazarın benzersiz kimliği
- Name (string) - Yazarın adı

### Kitaplar Tablosu (Books)
- BookId (int) - Kitabın benzersiz kimliği
- Title (string) - Kitabın başlığı
- AuthorId (int) - Kitabın yazarının kimliği (Yazarlar tablosundaki AuthorId ile ilişkilidir)

![image](https://github.com/user-attachments/assets/23c75da4-9205-466a-83d3-bb46f306c9bc)

LINQ sorgusunda join işlemini kullanarak iki tabloyu birleştirdim.
Sonuçları ekrana yazdırırken kitap başlığını ve yazarın adını göstermek için uygun bir format kullandım.

![image](https://github.com/user-attachments/assets/0bfd7f29-ef7f-4e86-be97-d39f95f9db64)
