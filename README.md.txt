
# SMS Otomasyon Sistemi

Bu proje, kullanıcıların rehberde kayıtlı kişilere SMS gönderimi yapabilmesini sağlayan bir **C# .NET WinForms** uygulamasıdır. Kullanıcılar hem anlık SMS gönderebilir hem de ileri tarihli gönderimler planlayabilir.

## 🚀 Özellikler

- 📇 Kişi yönetimi (ekleme, silme, listeleme)
- ✉️ Anlık SMS gönderimi
- 🕒 Planlı SMS gönderimi (ileri tarihli)
- 📁 Mesaj geçmişi kaydı (sms_log.txt)
- 📂 Kişiler TXT dosyasında saklanır (`kisiler.txt`, `rehber.txt`)
- 📅 Takvim üzerinden filtreleme
- 🧾 Yardım ve Geri Bildirim bölümü
- ⚙️ Masaüstüne otomatik kısayol ekleme

## 🛠️ Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|----------|----------|
| `C#` | Uygulama dili |
| `Windows Forms` | Kullanıcı arayüzü |
| `.NET Framework 4.8` | Uygulama altyapısı |
| `Entity Framework 6` | (İsteğe bağlı) veri yönetimi |
| `TXT/SQLite` | Veri depolama (kişiler ve mesajlar) |
| `System.Windows.Forms`, `System.IO`, `System.Timers` | Temel namespace'ler |

## 📂 Proje Yapısı

```
Sms-Otomasyon-New/
├── SmsForm.cs             # Ana form arayüzü
├── SmsSender.cs           # SMS gönderim mantığı
├── kisiler.txt            # Rehber bilgileri
├── sms_log.txt            # Gönderilen mesaj geçmişi
├── Program.cs             # Uygulama başlatıcısı
├── Yardım.cs              # Yardım formu (opsiyonel)
└── Sms-Otomasyon-New.csproj
```

## 🧪 Nasıl Çalışır?

1. Uygulama başlatıldığında `kisiler.txt` içeriği arayüze yüklenir.
2. Kullanıcı isterse kişi ekleyebilir veya silebilir.
3. Bir mesaj yazılır ve bir alıcı seçilir.
4. "Gönder" butonuna basıldığında SMS API'sine (placeholder olarak) istek gönderilir.
5. Mesaj `sms_log.txt` içine kaydedilir.
6. Planlı mesajlar, zamanlayıcı (Timer) ile izlenir ve zamanı geldiğinde gönderilir.

> Not: Gerçek SMS gönderimi için bir servis entegrasyonu (örneğin: Twilio, NetGSM, Infobip) yapılmalıdır.

## ⚙️ Kurulum ve Çalıştırma

1. Visual Studio ile açın: `Sms-Otomasyon-New.sln`
2. Gerekirse `.NET Framework 4.8` yükleyin.
3. `kisiler.txt`, `sms_log.txt` dosyalarının bulunduğundan emin olun.
4. `F5` tuşu ile çalıştırın.

## 📝 Geri Bildirim

Geri bildirim, hata bildirimi ya da önerileriniz için proje içindeki "Yardım ve Geri Bildirim" sekmesini kullanabilir veya bu repoya issue açabilirsiniz.

## 📃 Lisans

MIT Lisansı ile lisanslanmıştır.
