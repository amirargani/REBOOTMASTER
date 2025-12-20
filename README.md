# REBOOTMASTER 🚀

[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE.txt)
![Platform](https://img.shields.io/badge/Platform-Windows-0078D6?style=flat&logo=windows)
![Language](https://img.shields.io/badge/Language-C%23-239120?style=flat&logo=c-sharp)
[![.NET Version](https://img.shields.io/badge/.NET-10.0--windows-blue.svg)](https://dotnet.microsoft.com/download)
![Version](https://img.shields.io/badge/Version-v2025.12.20.0-blue.svg)
![REBOOTMASTER](https://github.com/amirargani/REBOOTMASTER/blob/main/REBOOTMASTER_Free/REBOOTMASTER.png)

## Overview 🛠️

**REBOOTMASTER** is a robust monitoring service designed to ensure the continuous availability of critical applications. It proactively tracks the status of configured services and responds immediately to unexpected failures by automatically restarting the affected processes.

Minimize downtime and maintain a stable IT infrastructure with automated recovery capabilities.

---

## Key Features ✅

- **Real-time Monitoring**: Services are checked at high frequency (every few seconds).
- **Automated Recovery**: Instant restart of failed services to minimize downtime.
- **Fail-safe Notifications**: Receive email alerts if a service cannot be recovered after multiple attempts.
- **Modern Tech Stack**: Built with .NET 10 for optimal performance on Windows.
- **Secure Configuration**: AES encryption for sensitive data (like email credentials).

## Getting Started 📘

### Prerequisites
- Windows OS
- [.NET 10 Runtime](https://dotnet.microsoft.com/download/dotnet/10.0)

### Installation
1. **Download**: Get the latest release from the [Releases](https://github.com/amirargani/REBOOTMASTER/releases) page.
2. **Setup**: Run the installer and follow the on-screen instructions.

### Usage
1. **Configure Emails**: Go to the **Settings** tab and enter your SMTP details for notifications.
2. **Select Services**: In the **Services** tab, select the programs you want to monitor and save your selection.
3. **Start Monitoring**: Click the **Start** button to begin the monitoring process.

---

## Technical Details ⚙️

| Component | Technology | Description |
| :--- | :--- | :--- |
| **Framework** | .NET 10 (Windows Forms) | Modern, high-performance UI framework. |
| **Logging** | log4net | Professional logging for diagnostic purposes. |
| **Security** | AES Encryption | Secure storage of configuration data. |
| **Communication** | SMTP / MailService | Automated failure notifications via email. |

> [!TIP]
> Always check the `log` files if you encounter issues. The system provides detailed error tracking.

---

## Changelog 📜

### V.2025.12.20.0
- 🏷️ **Project**:  Renamed project from `REBOOTMASTER_Free` to `REBOOTMASTER` and updated the source code.
- 🕹️ **Service Controls**: Added direct UI support for `Start`, `Stop`, and `Restart` actions.
- ⚙️ **WMI Integration**: Refactored to use `CimSession` for more robust and detailed service querying.
- 🛠️ **Utility**: Introduced the `ServiceHelper` class to centralize and optimize service management.
- ✨ **Filtering**: Added a toggle to switch between Windows system services and custom applications.
- 📺 **Main**: Implemented accessors for user controls and updated `timer_ProgressBar_Reset_Tick` to use `isStatus`.
- ⚙️ **Settings**: Added command-line argument support.
- 🎨 **UI/UX**: Enhanced `US_Services` with RTF‑formatted descriptions, interactive tooltips, and implemented code‑behind logic.
- 📁 **Templates**: Added a new folder for random selection of professional email notification templates.
- 🏗️ **Architecture**: Decoupled service logic for significantly improved maintainability.

### V.2025.12.18.0
- ✨ **Maintenance**: Corrected spelling mistakes across the documentation.
- 🎨 **UI**: Enhanced `Services` UserControl

### V.2025.12.04.0
- 🚀 **Feature**: Implemented `Log Class` with `log4net` integration.
- 🛡️ **Security**: Added `Security Class` with AES encryption/decryption.
- 📧 **Mail**: New `MailService` and `NotificationService` for email alerts.
- 🎨 **UI**: Enhanced `Settings` UserControl and added custom `ToolTipWindows`.
- 🔄 **Core**: Optimized `Program Class` for single-instance enforcement and .NET 10 compatibility.

### V.2025.09.19.0
- 🌱 **Initial Release**: Basic Windows Forms design and project structure.
- 🧩 **UI Management**: Added `USControl` and `Transition` classes for dynamic UI handling.
- ✉️ **Messaging**: Implemented `Message Class` for custom notifications.

---

## Recommendation 💡
Please consult with your IT department or software developer before deploying this tool in a production environment to ensure compatibility with your existing infrastructure.

---

*Developed by Amir Argani*
