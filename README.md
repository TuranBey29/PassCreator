<h1 align="center">🔐 PassCreator</h1>
<p align="center">Kolay, hızlı ve güvenli şifre üretici konsol uygulaması (.NET Core)</p>

<p align="center">
  <img src="https://img.shields.io/badge/.NET-6.0-purple?style=for-the-badge&logo=dotnet" />
  <img src="https://img.shields.io/badge/Platform-Console-blue?style=for-the-badge" />
  <img src="https://img.shields.io/badge/License-MIT-green?style=for-the-badge" />
</p>

---

## 📌 Proje Hakkında

**PassCreator**, basit komut satırı parametreleriyle güçlü, rastgele şifreler oluşturmanı sağlar.
İstersen özel karakterler ekleyebilir ve ürettiğin şifreyi otomatik olarak panoya kopyalayabilirsin.
**Tamamen yerel ve hızlı çalışır** — internet bağlantısına gerek yok!

## 🖥️ Özellikler

✅ Kullanımı kolay
✅ Güçlü ve rastgele şifre üretimi
✅ Özel karakter ekleme desteği
✅ Panoya kopyalama
✅ Detaylı yardım ekranı
✅ %100 açık kaynak ve ücretsiz

---

## ⚙️ Kurulum

> **Gereksinimler:** .NET 6 veya üzeri ([https://dotnet.microsoft.com](https://dotnet.microsoft.com))

```bash
git clone https://github.com/kullaniciAdin/PassCreator.git
cd PassCreator
dotnet restore
```

## 🚀 Kullanım

Şifre üretmek için:

```bash
dotnet run [parametreler]
```

### 📊 Parametreler

| Parametre         | Kısa Açıklama          | Detay              |
| ----------------- | ---------------------- | ------------------ |
| `-length <sayi>` | Şifre uzunluğu         | Varsayılan: **12** |
| `-special`       | Özel karakterler ekle  | !@#\$%^&\*()       |
| `-copy`          | Şifreyi panoya kopyala | Otomatik kopyalar  |
| `-help`          | Yardım ekranı göster   | Komutları açıklar  |

### 📝 Örnek Kullanımlar

```bash
dotnet run -length 16
dotnet run -length 20 --special
dotnet run -length 24 --special --copy
dotnet run -help
```

---

## 🛠️ Kullanılan Teknolojiler

* [.NET 6](https://dotnet.microsoft.com/)
* [TextCopy (Clipboard Library)](https://github.com/CopyText/TextCopy)

---

## 📂 Proje Yapısı

```
PassCreator/
│
├── Program.cs
├── PassCreator.csproj
├── README.md
└── LICENSE
```

---

## 🤝 Katkıda Bulunma

Her türlü katkıya açığım!
✨ Yeni özellik önerileri, 🐛 hata bildirimleri ve 📥 pull request gönderebilirsin.

```bash
git checkout -b yeni-ozellik
git commit -m "Yeni özellik eklendi"
git push origin yeni-ozellik
```

---

## 📄 Lisans

Bu proje MIT lisansı ile lisanslanmıştır.
Detaylar için [LICENSE](LICENSE) dosyasına bakabilirsiniz.

---

## 👨‍💻 Geliştirici

**Furkan Lapçin**
🌐 [furkanlapcin.com](https://furkanlapcin.com)

---

⭐ **Projeyi beğendiyseniz** → [Repo’ya ⭐ star vermeyi unutmayın!](https://github.com/kullaniciAdin/PassCreator)
