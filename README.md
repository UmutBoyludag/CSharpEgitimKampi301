<img width="1216" height="666" alt="Ekran görüntüsü 2025-08-25 155644" src="https://github.com/user-attachments/assets/e207d446-bc7f-4a1e-9cf3-9eb9df9a0cbd" />Proje Hakkında

📊 Seyahat İstatistik Uygulaması

Bu proje, C# Windows Forms ve Entity Framework kullanılarak geliştirilmiş bir seyahat/rezervasyon istatistik uygulamasıdır.

🛠️ Kullanılan Teknolojiler

💻 C# (.NET Framework / WinForms)

🗄️ Entity Framework (Database First)

🔍 LINQ sorguları

🚀 Özellikler

🏝️ Toplam lokasyon sayısı (Location.Count())

🪑 Toplam kapasite (Location.Sum(x => x.Capacity))

🧑‍🤝‍🧑 Toplam rehber sayısı (Guide.Count())

📈 Ortalama kapasite ve fiyat hesaplama (Average)

🌍 Son eklenen ülke bilgisi (Max(LocationId))

🏰 Kapadokya toplam kapasitesi

🇹🇷 Türkiye ortalama kapasitesi

🏛️ Roma rehberi bilgisi

🔝 En yüksek kapasiteye sahip lokasyon

💰 En yüksek fiyatlı tur lokasyonu

👩‍💼 Belirli bir rehbere ait tur sayısı (örn: Ayşegül)

⚙️ Çalışma Mantığı

📌 FrmStatistics_Load event’i çalıştığında, Entity Framework üzerinden veritabanına bağlanılır.
📌 LINQ sorguları ile istatistiksel veriler çekilir.
📌 Çekilen sonuçlar form üzerindeki Label bileşenlerine aktarılır.

💻 Örnek Kod
lblLocationCount.Text = db.Location.Count().ToString();
lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
lblGuideCount.Text = db.Guide.Count().ToString();
lblAverageCapacity.Text = db.Location.Average(x => x.Capacity).ToString();
lblAverageLocationPrice.Text = db.Location.Average(x => x.Price).ToString() + " ₺";

🎯 Amaç

Bu uygulama, seyahat acentesi veya turizm şirketleri için istatistiksel verilerin hızlı bir şekilde görüntülenmesini sağlar.
