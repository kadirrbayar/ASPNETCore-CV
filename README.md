<h1 align= left><b>ASP.NET Core CV Projesi</b></h1>

## <a name="features">Tanıtım</a>

Bu proje ASP.NET Core ile bir CV web sitesi projesidir. Proje katmanlı mimarı kullanılarak geliştirilmiştir.  

<b>Bu projede, 4 katman bulunmaktadır :</b>  
- WebSite: Bu katman, kullanıcı arayüzünü ve sunucu tarafı mantığını içerir. MVC (Model-View-Controller) tasarım deseni kullanılarak geliştirilmiştir.  
- BusinessLayer: Bu katman, iş mantığını ve servisleri içerir. Servisler, veri erişim katmanı ile iletişim kurarak veritabanı işlemlerini gerçekleştirir. Ayrıca, verileri iş kurallarına göre işler ve web sitesi katmanına sunar.  
- DataAccessLayer: Bu katman, veritabanı ile iletişim kurmak için kullanılan sınıfları ve metodları içerir. Entity Framework Core, bir ORM (Object-Relational Mapping) aracı olarak kullanılmıştır. ORM, nesne tabanlı programlama ile ilişkisel veritabanları arasında köprü sağlayan bir tekniktir. Entity Framework Core, veritabanı tablolarını C# nesnelerine eşler ve LINQ (Language Integrated Query) kullanarak veritabanı sorgularını yazmayı kolaylaştırır.  
- EntityLayer: Bu katman, veritabanındaki tabloları temsil eden C# nesnelerini içerir. Bu nesneler, verileri taşımak için kullanılır. Ayrıca, veritabanı ile ilişkili bazı özellikleri ve kuralları tanımlar.  
Bu projede, Code First yaklaşımı kullanılmıştır. Code First, veritabanı yerine C# kodu ile veritabanı şemasını tanımlamayı sağlar. Entity Framework Core, bu kodu kullanarak veritabanını oluşturur veya günceller.

<b>Projenin 3 temel paneli bulunmaktadır.</b>  
- Default panelinde eğitim hayatı, deneyimler ve referanslar gibi bilgiler yer almaktadır.  
- Yazar panelinde sisteme kaydolup bu sistem üzerinden haberleşecek kişiler için bir panel oluşturulmuştur. Bu panelde mesajlaşma duyurular ve profil bilgilerini düzenleme gibi işlemler gerçekleşmektedir.  
- Admin panelinde ise web sitesinde ki tüm alanlara ekleme silme ve güncelleme işlemleri yapılabilir.  

<b>Projede kullanılan yapılar :</b>  
- AspNet Core 6.0  
- Entity Framework Core  
- N Tier Architecture  
- Repository Design Pattern  
- Fluent Validation  
- Restful Api  
- Deploy  
- Mvc  
- Unit of Work  
- Charts  
- Ajax  
- Reporting  
- Identity  
- Rolleme  

### <a name="images">Görseller</a>

<p align="left">
  <img src="">
</p>

## <a name="license">Lisans</a>

 - Copyright (C) 2023-Present by [kadir](github.com/kadirrbayar)️
 - Licensed under the terms of the [GNU GENERAL PUBLIC LICENSE](https://github.com/kadirrbayar/ASPNETCore-CV/blob/main/LICENSE)
