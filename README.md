# REBOOTMASTER 🚀

[![.NET Core Desktop](https://github.com/amirargani/REBOOTMASTER/actions/workflows/dotnet.yml/badge.svg)](https://github.com/amirargani/REBOOTMASTER/actions)
---

[![License](https://img.shields.io/badge/License-Apache_2.0-D22128?style=for-the-badge&logo=apache)](LICENSE.txt)
[![Language](https://img.shields.io/badge/Language-C%23-239120.svg?style=for-the-badge&logo=csharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-Windows-0078D6.svg?style=for-the-badge&logo=windows)](https://www.microsoft.com/en-us/windows)
[![Framework](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet)
[![Version](https://img.shields.io/badge/Version-v2026.02.02.0-0078D6?style=for-the-badge&logo=semver&logoColor=white)]()

[![REBOOTMASTER](https://github.com/amirargani/REBOOTMASTER/blob/main/REBOOTMASTER/REBOOTMASTER.png)]()

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

### V.2026.02.02.0
* 🚀 **Dashboard Revamp**:
  - **Full UI Redesign**: Complete redesign using a modern grid layout with clearly separated panels for system health and service metrics.
  - **Real-time Monitoring & Logging**: Live dashboard with real-time performance metrics and a new **Live Log** area for instant feedback on service status changes and auto-restart events.
  - **Smart Metrics Panels**: Dedicated indicators for **Monitored Services**, **Auto Restarted Services**, **Stopped Services**, and **System Failures**.
  - **Dual Timer Logic**:
    - `AutoCheckServiceTimer`: Verifies service status at configurable intervals (default: every 30 seconds) and performs automatic recovery attempts.
    - `TimerWhenServiceStopped`: Monitors persistent service failures over configurable time intervals (default: 10 minutes) and triggers escalated email alerts.
    > [!TIP]
    > The interval can be modified in the Settings tab.
  - **Integrated Controls**: `Start` and `Stop` buttons embedded directly into the dashboard, including dynamic reloading of SMTP and interruption configurations.

* 🏗️ **Core Logic & Architecture Updates**:
  - **UI State Management**: Added `DeaktiviereButton()` and `AktiviereButton()` to lock the **Services** and **Settings** tabs while monitoring is active, preventing configuration conflicts.
  - **Centralized Updates**: Introduced `UpdateDashboard()` to efficiently synchronize all service metrics across the UI.
  - **Startup Optimization**: Configured the application to automatically load and update the dashboard on initial startup.
  - **Naming Standards**: Refactored all UI controls, timers, internal methods, and `NotifyIcon` to follow strict **PascalCase** naming conventions.
  - **Documentation**: Added comprehensive **Comments** and descriptive code documentation across all core modules.
  - **Configuration Management**: Improved `XMLUpdate` logic and added `Reload()` capabilities to configuration readers for dynamic runtime updates.

* 🛡️ **Stability, Reliability & Validation**:
  - **Global Error Handling**: Enhanced exception handling in `Program.cs` and `Main.cs` to capture unhandled exceptions and report them via email in non-debug (production) builds.
  - **Smart Email Alerts**: Sends an email whenever a monitored service fails, providing recovery status for **Auto-Restart** enabled services or manual inspection prompts for disabled ones (default: **Auto‑Restart** every 120 seconds).
    > [!TIP]
    > The interval can be modified in the Settings tab.
  - **SMTP Diagnostics**: Added a **“Send Test Email”** feature in the Settings tab for immediate validation of SMTP configurations.
  - **Advanced Validation**: Implemented multi-stage validation for all SMTP and interruption-related settings to prevent configuration errors.

* 🧪 **Unit Testing**: 
  - **Complete Test Suite**: Implemented 28 unit tests using **xUnit** to ensure the reliability of core logic, utility services, configuration readers, and UI components.
  - **Automation Ready**: Fully compatible with CI/CD workflows using `dotnet test`.
  - > [!NOTE]
  - > For more detailed information on how to run tests and what is covered, see the [Unit Testing](#unit-testing) section at the bottom.

* 🏷️ **Project Metadata**:
  - Version updated across assembly, manifest, and UI to **`V.2026.02.02.0`**.

### V.2026.01.19.0
- 🆕 **New Features**:
  - **My Active Services Filter**: Added `myser_Rad` and `services_Rad` radio buttons in `US_Services` to switch between "All Services" and "My Active Services" (configured services).
  - **Smart Selection Recovery**: `Loaded_Services` now restores the previously selected service after list refreshes.
- 🛠️ **Function Updates**:
  - `Loaded_Services()`: Completely refactored to support the new radio button filtering logic.
  - `DeleteAction()`: Enhanced to handle post-deletion selection logic (auto-selects previous item or switches view if empty).
  - `RefreshSelectedServiceDetails()`: Added `EscapeRtf` helper for safer RTF rendering and improved state management for the `Update` button.
  - `ConfirmAction()`: Now calls `RefreshSelectedServiceDetails()` immediately after updates to ensure UI consistency.
- ⚡ **Performance & UX**:
  - `timer_ProgressBar_Tick` / `timer_ProgressBar_Reset_Tick`: Increased progress bar speed (step +5) for a snappier feel.
  - `GetSettingNode`: Logic updated to be more robust.
- ⚙️ **Project Metadata**:
  - Added `ApplicationManifest` (active only in Release/non-Debug modes) and updated `.csproj` with proper assembly versioning and descriptions.

### V.2026.01.16.0
- 🗑️ **Service Management**: Added functionality to add, update, and delete services from the configuration directly via the UI.
- ⚙️ **Configuration**: Updated `XMLUpdate` to support service removal.
- 🎨 **UI**: Enabled the `Delete` button in `US_Services` when a service is selected and exists in the config.
- 👨‍💻 **Technical**: Updated `US_Services` logic including `RefreshSelectedServiceDetails`, `Loaded_Services`, `IsServiceEnabled`, `IsServiceExists`, `GetSettingNode`, and the `Service Description` property.

### V.2025.12.20.0
- 🏷️ **Project**:  Renamed project from `REBOOTMASTER` to `REBOOTMASTER` and updated the source code.
- 🕹️ **Service Controls**: Added direct UI support for `Start`, `Stop`, and `Restart` actions.
- ⚙️ **WMI Integration**: Refactored to use `CimSession` for more robust and detailed service querying.
- 🛠️ **Utility**: Introduced the `ServiceHelper` class to centralize and optimize service management.
- ✨ **Filtering**: Added a toggle to switch between Windows system services and custom applications.
- 📺 **Main**: Implemented accessors for user controls and updated `timer_ProgressBar_Reset_Tick` to use `isStatus`.
- ⚙️ **Settings**: Added command-line.
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

## Unit Testing

To ensure the reliability of the core components, a suite of xUnit unit tests has been implemented. You can run the tests using the following commands from the terminal:

### Basic Test Run
```bash
dotnet test
```

### Detailed Test Run (Recommended for CI/CD)
```bash
dotnet test --logger "console;verbosity=normal"
```

The test suite covers:
- **Security & Encryption**: SHA256 hashing and AES cryptographic operations.
- **Configuration Readers**: Safety and data retrieval from XML config files.
- **Utility Services**: Mail, Notifications, Logging (log4net), and Service Helpers.
- **User Interface**: Initialization and logic for all UserControls and the Main form.
- **Core Application Logic**: Process management and single-instance enforcement (Program).

---

*Developed by Amir Argani*