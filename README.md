# Koşu ve Günlük Rutin Takip Sistemi

Görsel Programlama II dersi kapsamında **C# Windows Forms** ve **MySQL** kullanılarak **Çok Katmanlı Mimari (N-Tier Architecture)** prensiplerine uygun olarak geliştirilmiş masaüstü takip uygulamasıdır.

## Mimari Yapı
Uygulama sorumlulukların ayrılması (Separation of Concerns) ilkesiyle 5 ana katmandan oluşur:
- **Forms (UI):** `LoginForm` ve `MainDashboardForm` kullanıcı arayüzleri.
- **Validators:** Kullanıcı, antrenman ve günlük rutin verileri için iş kuralı ve alan doğrulamaları (`UserValidator`, `WorkoutValidator`, `DailyRoutineValidator`).
- **Services:** İş mantığı ve istatistik hesaplamaları (`UserService`, `ActivityTypeService`, `WorkoutService`, `DailyRoutineService`).
- **Repositories:** Parametreli SQL sorguları (`MySqlCommand` & `Parameters.AddWithValue`) ile SQL Injection korumalı veritabanı CRUD işlemleri.
- **Models:** Veritabanı tablolarını temsil eden varlık sınıfları (`User`, `ActivityType`, `Workout`, `DailyRoutine`).

## Veritabanı Şeması (`kosuverutindb`)
- `Users`: Kullanıcı kimlik ve oturum bilgileri
- `ActivityTypes`: Aktivite kategorileri ve ölçü birimleri
- `Workouts`: Kullanıcı ve aktivite türüyle ilişkili antrenman kayıtları (`Foreign Key`)
- `DailyRoutines`: Günlük uyku süresi ve alışkanlık (soğuk duş, meditasyon, kitap okuma) kayıtları (`Foreign Key`)

## Kurulum ve Çalıştırma
1. Yerel sunucuda (WampServer / XAMPP) MySQL servisini başlatın ve `kosuverutindb` veritabanını oluşturun.
2. `Repositories/DbConnectionHelper.cs` içindeki bağlantı cümlesini kendi yerel ayarlarınıza göre kontrol edin.
3. Visual Studio üzerinden NuGet paketlerini (`MySql.Data`) geri yükleyip projeyi başlatın (`F5`).
4. Varsayılan test hesabı: **Kullanıcı Adı:** `metehan` | **Şifre:** `1234`