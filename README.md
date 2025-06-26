# 🗨️ Simple TCP Chat

[![C#](https://img.shields.io/badge/C%23-Language-blue)](https://learn.microsoft.com/en-us/dotnet/csharp/)

Welcome to this basic TCP chat application written in C#!  
It consists of two console programs working together to send and receive messages over the network.

---

## 🚀 Features

- **ServerApp**: A TCP server that listens for client connections and echoes received messages with timestamps.
- **ClientApp**: A TCP client that connects to the server and sends messages.
- Real-time message exchange via console.
- Exit gracefully by typing `exit`.

---

## 🎯 Prerequisites

- [.NET 6 SDK or higher](https://dotnet.microsoft.com/download)
- A command line terminal (PowerShell, CMD, Terminal, etc.)

---

## 🛠️ Setup & Running the Project

### 1. Clone or Download the Project Files

Ensure you have these two folders:

/ServerApp
/ClientApp

---

### 2. Start the Server

Open a terminal, navigate to the `ServerApp` folder, then run:

```bash
cd "path/to/ServerApp"
dotnet run
```

it will write:

`Server started. Waiting for a connection...`

Open a other terminal, navigate to the `ClientApp` folder, then run:

```bash
cd ClientApp
dotnet run
```

it will write:

```bash
Connected to the server!
You:
```
You can now write in the client terminal and it will upload it to the terminal server
