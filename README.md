# BasicMessagingSystem

[TR]

**Temel Mesajlaşma ve İletişim Sistemi Uygulaması**

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Web/Desktop](https://img.shields.io/badge/Platform-Web%20%7C%20Desktop%20App-informational.svg)]()
[![Database](https://img.shields.io/badge/Database-SQL_Server-CC2927.svg)](https://www.microsoft.com/en-us/sql-server)
[![GitHub repo size](https://img.shields.io/github/repo-size/abdullahhaktan/BasicMessagingSystem)](https://github.com/abdullahhaktan/BasicMessagingSystem)

---

## 💻 Proje Hakkında

Bu proje, kullanıcıların birbiriyle **temel düzeyde mesaj alışverişi** yapmasını sağlayan bir sistemin demonstrasyonudur. Projenin ana odak noktası, kullanıcı yönetimi, mesajların veritabanında kalıcı olarak saklanması (persistence) ve gönderilen mesajların alıcıya iletilmesi mantığını uygulamaktır.

Bu sistem, bir iç iletişim aracı, bir müşteri destek platformunun temeli veya basit bir sosyal uygulama için başlangıç noktası olabilir.

---

## ✨ Temel Özellikler ve Modüller

### İletişim İşlevleri
* **Bire Bir Mesajlaşma:** İki kayıtlı kullanıcı arasında özel mesajlaşma (Direct Message).
* **Mesaj Kalıcılığı:** Gönderilen tüm mesajların veritabanında zaman damgasıyla (timestamp) birlikte saklanması.
* **Gelen/Giden Kutusu:** Kullanıcıların kendilerine gelen ve kendilerinin gönderdiği mesajları ayrı ayrı görebilmesi.

### Yönetim ve Kullanıcı
* **Kullanıcı Kayıt/Giriş:** Sisteme kayıt olma ve giriş yapma (Authentication) mekanizmaları.
* **Kullanıcı Listesi:** Mesaj gönderilebilecek diğer kayıtlı kullanıcıların listelenmesi.

### Teknik Altyapı
* **Veritabanı Modeli:** Kullanıcılar (`Users`) ve Mesajlar (`Messages`) gibi temel tablolar arasındaki ilişkilerin yönetimi.
* **Geliştirme Teknolojisi:** Proje, **C#** dili ve **.NET** teknolojileri (örneğin ASP.NET Core veya WinForms/WPF) kullanılarak geliştirilmiştir.

---

## 🚀 Nasıl Çalıştırılır?

Bu projenin çalıştırılması için gerekli **.NET ortamı** ve **SQL Server** veritabanı erişimi gereklidir.

1.  **Projeyi Klonlama:**
    ```bash
    git clone [https://github.com/abdullahhaktan/BasicMessagingSystem](https://github.com/abdullahhaktan/BasicMessagingSystem)
    cd BasicMessagingSystem
    ```

2.  **Veritabanı Kurulumu:**
    * **SQL Server**'da bir veritabanı oluşturun.
    * Veritabanı şemasını (tabloları) oluşturmak için projenin **data access** katmanındaki (genellikle Entity Framework Migrations) talimatları uygulayın.

3.  **Bağlantı Dizesini Ayarlama:**
    * Projenin yapılandırma dosyasındaki (`Web.config` veya `appsettings.json`) **veritabanı bağlantı dizesini** kendi yerel SQL Server ayarlarınıza göre güncelleyin.

4.  **Projeyi Başlatma:**
    * **Visual Studio** ile `.sln` (Solution) dosyasını açın.
    * Projeyi derleyin ve **F5** tuşu ile uygulamayı çalıştırın.

---
---

[EN]

# BasicMessagingSystem

**Basic Messaging and Communication System Application**

---

## 💻 About the Project

This repository demonstrates a system that allows users to perform **basic message exchange**. The project's main focus is implementing user management, ensuring message persistence in a database, and handling the logic for transmitting sent messages to the recipient.

This system can serve as an internal communication tool, the foundation for a customer support platform, or a starting point for a simple social application.

---

## ✨ Core Features and Modules

### Communication Functionality
* **One-to-One Messaging:** Private messaging (Direct Message) between two registered users.
* **Message Persistence:** All sent messages are stored permanently in the database along with a timestamp.
* **Inbox/Sent Box:** Allows users to view messages they have received and messages they have sent separately.

### Management and Users
* **User Registration/Login:** Implementation of mechanisms for signing up and logging into the system (Authentication).
* **User List:** Listing of other registered users available to send messages to.

### Technical Foundation
* **Database Model:** Management of relationships between core tables like `Users` and `Messages`.
* **Development Technology:** The project is developed using the **C#** language and **.NET** technologies (e.g., ASP.NET Core or WinForms/WPF).

---

## 🚀 How to Run

Running this project requires the necessary **.NET environment** and **SQL Server** database access.

1.  **Cloning the Project:**
    ```bash
    git clone [https://github.com/abdullahhaktan/BasicMessagingSystem](https://github.com/abdullahhaktan/BasicMessagingSystem)
    cd BasicMessagingSystem
    ```

2.  **Database Setup:**
    * Create a new database in **SQL Server**.
    * Follow the instructions in the project's **data access** layer (typically Entity Framework Migrations) to set up the database schema (tables).

3.  **Configuring the Connection String:**
    * Update the **database connection string** in the project's configuration file (`Web.config` or `appsettings.json`) to match your local SQL Server settings.

4.  **Starting the Project:**
    * Open the **`.sln`** (Solution) file with **Visual Studio**.
    * Build the project and run the application by pressing **F5**.

---
---

<img width="947" height="495" alt="Ekran görüntüsü 2025-10-04 111605" src="https://github.com/user-attachments/assets/49b8e0c3-2160-4664-b53c-a32cc9eb1405" />
