# 🖥️ Hardware Monitor WinForms

![.NET](https://img.shields.io/badge/.NET-6.0-blue)
![License: MIT](https://img.shields.io/badge/License-MIT-green)

> ✨ **Description:**  
> This project is a **C# WinForms application** designed for real-time monitoring and displaying of computer hardware sensor data. It leverages the **LibreHardwareMonitor** library to provide insights into your CPU, GPU, memory, storage, and other system components.

## 📑 Table of Contents  
- [📜 About the Project](#about-the-project)  
- [⚡ Features](#features)  
- [⚙️ Installation and Usage](#installation-and-usage)  
- [🛠 Technologies](#technologies)  
- [🤝 Contributing](#contributing)  
- [📄 License](#license)  
- [📬 Contact](#contact)  

<a id="about-the-project"></a>
## 📜 About the Project  
This application provides a user-friendly interface to monitor various hardware sensors on your Windows machine. It's built with C# and WinForms, making it a lightweight and efficient tool for keeping an eye on your system's health and performance metrics like temperatures, fan speeds, voltages, and loads.

<a id="features"></a>
## ⚡ Features  
- ✅ Real-time monitoring of CPU, GPU, Memory, Storage, Motherboard, Controller, and Network sensors.  
- ✅ Displays sensor data including hardware name, sensor name, type, value, and unit.  
- ✅ Filtering options for specific sensor types (e.g., Temperature, Fan Speed).  
- ✅ User-friendly Windows Forms interface.  
- ✅ Efficient data updates with UI thread safety.  

<a id="installation-and-usage"></a>
## ⚙️ Installation and Usage  
1.  📥 **Clone the repository:**  
    ```bash
    git clone https://github.com/leventDemirkaya/HardwareMonitorApp.git
    cd HardwareMonitorApp
    ```

2.  💻 **Open and Run the Project:**  
    Open the solution (`.sln` file) in Visual Studio (2019 or newer recommended) or use the .NET CLI:
    ```bash
    dotnet build
    dotnet run
    ```
    *(Ensure you have .NET 6.0 SDK installed.)*

3.  ▶️ **Start Monitoring:**  
    Once the application launches, it will automatically start displaying sensor data. You can use the menu options to filter data by sensor type (e.g., Temperatures, Fan Speeds, or All Sensors).

<a id="technologies"></a>
## 🛠 Technologies  
- 💻 C#  
- 🖥 .NET 6.0  
- 🎨 Windows Forms  
- 📊 [LibreHardwareMonitorLib](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor) (for hardware data access)  

<a id="contributing"></a>
## 🤝 Contributing  
Contributions are highly welcome!  
- 🐞 For bug reports, please use the [Issues](https://github.com/leventDemirkaya/HardwareMonitorApp/issues) tab.  
- 🚀 For feature suggestions or improvements, feel free to open a [Pull Request](https://github.com/leventDemirkaya/HardwareMonitorApp/pulls).  

<a id="license"></a>
## 📄 License  
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

<a id="contact"></a>
## 📬 Contact  
📧 leventdemirkaya@outlook.com
