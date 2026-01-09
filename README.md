# Kütüphane Otomasyonu

Bu proje, N Katmanlı Mimari (N-Tier Architecture) kullanılarak
C# dili ile geliştirilmiş bir Kütüphane Otomasyonu uygulamasıdır.
Amaç, kütüphane yönetim süreçlerini dijital ortamda düzenli ve
sürdürülebilir bir şekilde yönetmektir.

## Proje Amacı
- Kitapların sisteme eklenmesi
- Kullanıcıların kitap ödünç alabilmesi
- Veritabanı işlemlerinin katmanlı mimari ile yönetilmesi
- Daha okunabilir, sürdürülebilir ve genişletilebilir bir yapı oluşturmak

## Kullanılan Teknolojiler
- C#
- .NET
- SQL Server
- Visual Studio 2022
- Git & GitHub

## Mimari Yapı (N Katmanlı Mimari)

### Entity Katmanı
- Veritabanı tablolarını temsil eden sınıflar bulunur.
- Sadece veri taşımakla görevlidir.

### DAL (Data Access Layer)
- Veritabanı işlemleri bu katmanda yapılır.
- CRUD (Create, Read, Update, Delete) işlemleri yer alır.

### BLL (Business Logic Layer)
- İş kuralları bu katmanda uygulanır.
- DAL ile UI arasındaki kontrol katmanıdır.

### UI (Kullanıcı Arayüzü)
- Kullanıcının uygulama ile etkileşime geçtiği katmandır.
- WinForms arayüzü kullanılmıştır.

## Veritabanı Yapısı
- Kullanıcılar
- Kitaplar
- Ödünç Kitaplar

## Sonuç
Bu proje, N katmanlı mimari yapısının anlaşılması ve
gerçek bir senaryo üzerinde uygulanması amacıyla geliştirilmiştir.
