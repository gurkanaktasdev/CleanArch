
# 🏗 Clean Architecture Proje Yapısı

Bu proje **Clean Architecture** prensiplerine uygun şekilde yapılandırılmıştır.  
Amaç, **katmanlar arası bağımlılıkları en aza indirmek**, **test edilebilirliği artırmak** ve **sürdürülebilir bir yapı** kurmaktır.  

---

## 📂 Proje Klasör Yapısı

```bash
src
├── Core
│   ├── Domain
│   │   └── BaseEntity.cs       # Temel entity sınıfları
│   │
│   └── Application
│       ├── CQRS/               # MediatR ile CQRS (Command / Query)
│       ├── DTOs/               # Veri transferi için DTO sınıfları
│       ├── Mappings/           # AutoMapper profilleri
│       └── Interfaces/         # Repository arayüzleri
│
├── Infrastructure
│   └── Persistence
│       ├── Context/            # DbContext sınıfı
│       ├── Migrations/         # EF Core migration dosyaları
│       └── Repositories/       # Repository implementasyonları
│
└── WebApi
    ├── Controllers/            # API controller’ları
    ├── Program.cs
    └── Startup.cs (veya builder ayarları)
```

## ⚙️ Katmanlar ve Teknolojiler

### 🔸 Core

**Domain**
- Temel entity sınıflarını içerir.  
- Framework bağımsızdır, saf C# kodu barındırır.  
- Örn: `BaseEntity`, `Product`, `User` gibi entity sınıfları.  

**Application**
- **CQRS pattern** uygulanmıştır.  
  - MediatR ile Command ve Query işlemleri ayrıştırılır.  
  - **Command** → Yazma (Create, Update, Delete).  
  - **Query** → Okuma (Get, List).  
- **DTOs** ile dış dünyaya veri transferi yapılır.  
- **AutoMapper** kullanılarak Entity ↔ DTO dönüşümleri yapılır.  
- **Repository Interfaces** tanımlanarak, veri erişim soyutlaması sağlanır.  

---

### 🔸 Infrastructure

**Persistence**
- Entity Framework Core tabanlı **DbContext** bulunur.  
- **Migrations** klasöründe veritabanı migration işlemleri tutulur.  
- **Repository Implementations** ile Core katmanında tanımlı repository interface’leri hayata geçirilir.  
- Veritabanı bağımlılığı bu katmanda izole edilir.  

---

### 🔸 WebApi
- ASP.NET Core Web API uygulaması bulunur.  
- Controller’lar üzerinden Application katmanındaki CQRS handler’ları tetiklenir.  
- Dependency Injection kullanılarak Repository ve Service bağımlılıkları çözülür.  
- İstemciler (örneğin Web, Mobil veya başka API’ler) bu katman üzerinden sisteme erişir.  

---

## 🚀 Kullanılan Teknolojiler
- .NET 9 (ASP.NET Core Web API)
- Entity Framework Core (veritabanı işlemleri, migration)
- MediatR (CQRS pattern)
- AutoMapper (Entity ↔ DTO mapping)
- Repository Pattern
