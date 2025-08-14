# 🖥️ Donanım Sensör İzleyici WinForms

![.NET](https://img.shields.io/badge/.NET-6.0-blue)
![Lisans: MIT](https://img.shields.io/badge/Lisans-MIT-green)

> ✨ **Açıklama:**  
> Bu proje, bilgisayar donanım sensör verilerini gerçek zamanlı olarak izlemek ve görüntülemek için tasarlanmış bir **C# WinForms uygulamasıdır**.  
> **LibreHardwareMonitor** kütüphanesini kullanarak CPU, GPU, bellek, depolama ve diğer sistem bileşenleri hakkında bilgi sağlar.

## 📑 İçindekiler  
- [📜 Proje Hakkında](#proje-hakkinda)  
- [⚡ Özellikler](#ozellikler)  
- [⚙️ Kurulum ve Kullanım](#kurulum-ve-kullanim)  
- [🛠 Teknolojiler](#teknolojiler)  
- [🤝 Katkıda Bulunma](#katkida-bulunma)  
- [📄 Lisans](#lisans)  
- [📬 İletişim](#iletisim)  

<a id="proje-hakkinda"></a>
## 📜 Proje Hakkında  
Bu uygulama, Windows bilgisayarımda çeşitli donanım sensörlerini kullanıcı dostu bir arayüzle izlememi sağlar.  
C# ve WinForms ile geliştirdim; sıcaklık, fan hızı, voltaj ve yük gibi performans metriklerini hafif ve verimli şekilde takip eder.

<a id="ozellikler"></a>
## ⚡ Özellikler  
- ✅ CPU, GPU, Bellek, Depolama, Anakart, Kontrolcü ve Ağ sensörlerini gerçek zamanlı izleme  
- ✅ Donanım adı, sensör adı, tipi, değeri ve birimini gösterme  
- ✅ Belirli sensör tiplerine göre filtreleme (örneğin, Sıcaklıklar, Fan Hızları)  
- ✅ Kullanıcı dostu Windows Forms arayüzü  
- ✅ UI thread güvenliği ile verimli veri güncellemeleri  

<a id="kurulum-ve-kullanim"></a>
## ⚙️ Kurulum ve Kullanım  
1.  📥 **Depoyu klonla:**  
    ```bash
    git clone https://github.com/leventDemirkaya/HardwareMonitorApp.git
    cd HardwareMonitorApp
    ```

2.  💻 **Projeyi aç ve çalıştır:**  
    Visual Studio (2019 veya daha yeni) ile `.sln` dosyasını aç veya .NET CLI kullan:  
    ```bash
    dotnet build
    dotnet run
    ```

3.  ▶️ **İzlemeye başla:**  
    Uygulama açıldığında sensör verileri otomatik olarak gösterilecek. Menüden sensör tipine göre filtreleme yapabilirsin (örneğin, Sıcaklıklar, Fan Hızları veya Tüm Sensörler).

<a id="teknolojiler"></a>
## 🛠 Teknolojiler  
- 💻 C#  
- 🖥 .NET 6.0  
- 🎨 Windows Forms  
- 📊 [LibreHardwareMonitorLib](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor) (donanım verisi erişimi için)  

<a id="katkida-bulunma"></a>
## 🤝 Katkıda Bulunma  
Katkıların benim için çok değerli!  
- 🐞 Hata bildirmek için [Issues](https://github.com/leventDemirkaya/HardwareMonitorApp/issues) sekmesini kullanabilirsin.  
- 🚀 Yeni özellik önerileri veya geliştirmeler için [Pull Request](https://github.com/leventDemirkaya/HardwareMonitorApp/pulls) açabilirsin.  

<a id="lisans"></a>
## 📄 Lisans  
Bu proje MIT Lisansı ile lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakabilirsin.

<a id="iletisim"></a>
## 📬 İletişim  
📧 leventdemirkaya@outlook.com
