# Fabrika Otomasyon Sistemi

Bu proje, C# ve WinForms kullanılarak geliştirilmiş, veritabanı destekli bir fabrika otomasyon
uygulamasıdır. Masaüstü mimarisi üzerine kurulu olan uygulama, gerçek hayattaki bir fabrika
senaryosu baz alınarak tasarlanmıştır.

Proje, yazılım geliştirme sürecinde masaüstü uygulama geliştirme, veritabanı yönetimi ve
katmanlı düşünme becerilerinin uygulanmasını amaçlamaktadır.

## Problem Tanımı
Fabrika ortamlarında verilerin manuel veya düzensiz tutulması;
- veri kaybına
- yönetim zorluklarına
- operasyonel hatalara

sebep olmaktadır. Bu proje, temel fabrika verilerinin merkezi bir sistem üzerinden
yönetilmesini sağlayarak bu problemleri azaltmayı hedefler.

## Teknik Detaylar
- Programlama Dili: C#
- Platform: .NET Framework
- Arayüz: WinForms
- Veritabanı: SQL Server
- Veri Erişimi: ADO.NET

## Uygulama Özellikleri
- SQL Server ile entegre çalışma
- Form tabanlı kullanıcı arayüzü
- Veritabanı üzerinde CRUD işlemleri
- SQL script ile otomatik veritabanı kurulumu
- Yapılandırılabilir connection string

## Kurulum
1. Fabrika_Kurulum_Kodu.sql dosyasını SQL Server üzerinde çalıştırarak veritabanını oluşturun
2. App.config dosyası içindeki connection string'i kendi sistem ayarlarınıza göre düzenleyin
3. FabrikaSunumProjesi.sln dosyasını Visual Studio ile açın
4. Uygulamayı çalıştırın

## Proje Yapısı
- Form1.cs: Uygulamanın ana iş mantığını içeren form
- App.config: Veritabanı bağlantı ayarları
- Fabrika_Kurulum_Kodu.sql: Veritabanı şema ve başlangıç verileri

## Kazanımlar
Bu proje kapsamında:
- WinForms ile masaüstü uygulama geliştirme
- SQL Server ile veritabanı tasarımı
- ADO.NET ile veri erişimi
- Konfigürasyon ve proje yapısı yönetimi

konularında pratik deneyim kazanılmıştır.

## Not
Derleme çıktıları ve kişisel ayar dosyaları bilinçli olarak
GitHub reposuna eklenmemiştir.
