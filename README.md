# 🐾 SmartNutriTracker

<div align="center">

![un_socio_mas]([https://tu-enlace-de-imagen.com/imanol.jpg](https://www.google.com/imgres?q=pibble&imgurl=https%3A%2F%2Fi.scdn.co%2Fimage%2Fab67616d0000b27332fdd9cfd9c3b89028ff58e6&imgrefurl=https%3A%2F%2Fopen.spotify.com%2Fintl-es%2Ftrack%2F2ZkNuVzYwNeRucDcejJOJt&docid=TnGavsS8CxkaaM&tbnid=StK4VJ4yOBhVrM&vet=12ahUKEwjsnfr04f6XAxWHpZUCHZCSJ80QnPAOegQINBAA..i&w=640&h=640&hcb=2&ved=2ahUKEwjsnfr04f6XAxWHpZUCHZCSJ80QnPAOegQINBAA))
**Una plataforma web para promover una alimentación más saludable mediante la gestión y el seguimiento nutricional.**

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Blazor](https://img.shields.io/badge/Blazor-Interactive_Server-512BD4?style=for-the-badge&logo=blazor&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![C#](https://img.shields.io/badge/C%23-Language-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![SQL Server](https://img.shields.io/badge/SQL_Server-Database-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server)
[![GitHub](https://img.shields.io/badge/GitHub-Repository-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/chrischidori27-debug/SmartNutriTracker)

**Gestiona · Aprende · Cuida tu nutrición**

</div>

---

## 🌱 Acerca del proyecto

**SmartNutriTracker** es una plataforma web desarrollada para apoyar la gestión nutricional dentro del entorno educativo.

Su propósito es ofrecer herramientas que permitan organizar información relacionada con usuarios, alimentos y menús diarios, facilitando el seguimiento y la administración de información nutricional.

El sistema está orientado a la comunidad educativa y contempla diferentes perfiles de acceso, como estudiantes, docentes, nutricionistas y administradores.

## 🎯 Objetivos

- Promover hábitos de alimentación saludable.
- Facilitar la administración de información nutricional.
- Organizar alimentos y menús diarios.
- Gestionar usuarios mediante roles y permisos.
- Ofrecer una interfaz intuitiva, moderna y accesible.

## ✨ Funcionalidades del sistema

| Funcionalidad | Descripción |
|---|---|
| 👤 Registro de usuarios | Permite registrar nuevos usuarios. |
| 🔐 Gestión de contraseñas | Almacenamiento mediante contraseñas protegidas con hash. |
| 🛡️ Roles de usuario | Diferenciación de perfiles y responsabilidades. |
| 🥗 Gestión de alimentos | Módulo previsto para administrar alimentos e información nutricional. |
| 📅 Menús diarios | Módulo previsto para organizar menús nutricionales. |
| 📋 Auditoría | Base de datos preparada para registrar eventos del sistema. |

> El proyecto se encuentra en desarrollo. Las funcionalidades descritas pueden encontrarse en diferentes etapas de implementación.

## 🧰 Tecnologías utilizadas

| Tecnología | Utilización |
|---|---|
| C# | Lenguaje principal de programación. |
| .NET 10 | Plataforma de desarrollo. |
| Blazor Web App | Construcción de la interfaz web. |
| Interactive Server | Interactividad de los componentes Blazor. |
| Entity Framework Core 10 | Acceso y comunicación con la base de datos. |
| SQL Server LocalDB | Almacenamiento de información. |
| Git y GitHub | Control de versiones y colaboración. |
| Visual Studio | Entorno de desarrollo. |

## 🗄️ Base de datos

El proyecto utiliza **SQL Server LocalDB** como motor de base de datos.

Nombre de la base de datos:

`SmartNutriTracker`

Principales tablas:

| Tabla | Descripción |
|---|---|
| Roles | Almacena los roles disponibles. |
| Usuarios | Contiene la información de los usuarios. |
| Alimentos | Almacena los alimentos y sus datos nutricionales. |
| MenusDiarios | Registra los menús diarios. |
| MenuAlimentos | Relaciona los alimentos con los menús. |
| LogsAuditoria | Almacena registros de auditoría. |

### Roles del sistema

- **Administrador:** control general del sistema.
- **Docente:** seguimiento de estudiantes.
- **Estudiante:** consulta y registro de información.
- **Nutricionista:** gestión nutricional y alimentos.

## 🚀 Instalación y ejecución

### Requisitos previos

Antes de ejecutar el proyecto, asegúrate de contar con:

- Visual Studio 2022 o una versión compatible.
- SDK de .NET 10.
- SQL Server LocalDB.
- SQL Server Management Studio (opcional, para administrar la base de datos).
- Git.

### 1. Clonar el repositorio

```bash
git clone https://github.com/chrischidori27-debug/SmartNutriTracker.git
```

### 2. Abrir el proyecto

Ingresa a la carpeta del proyecto y abre `SmartNutriTracker.csproj` con Visual Studio.

### 3. Configurar la conexión a SQL Server

Abre `appsettings.json` y verifica que la cadena de conexión corresponda a tu instancia de SQL Server LocalDB:

```json
{
  "ConnectionStrings": {
    "ConexionSQL": "Server=(localdb)\\MSSQLLocalDB;Database=SmartNutriTracker;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

Asegúrate de que la base de datos y sus tablas estén creadas antes de ejecutar la aplicación.

### 4. Restaurar dependencias

Desde la terminal del proyecto ejecuta:

```bash
dotnet restore
```

### 5. Compilar el proyecto

```bash
dotnet build
```

### 6. Ejecutar la aplicación

```bash
dotnet run
```

También puedes iniciar el proyecto directamente desde Visual Studio.

## 📁 Estructura del proyecto

```text
SmartNutriTracker/
│
├── Components/
│   ├── Layout/
│   │   ├── MainLayout.razor
│   │   └── NavMenu.razor
│   │
│   ├── Pages/
│   │   ├── Home.razor
│   │   ├── Login.razor
│   │   └── Registro.razor
│   │
│   ├── App.razor
│   └── Routes.razor
│
├── Modelos/
│   ├── Usuario.cs
│   ├── Role.cs
│   └── SmartNutriTrackerContext.cs
│
├── Servicios/
│   └── UsuarioServicio.cs
│
├── wwwroot/
│   ├── app.css
│   └── favicon.png
│
├── assets/
│   └── pibble-banner.png
│
├── appsettings.json
├── Program.cs
└── SmartNutriTracker.csproj
```

## 🔐 Seguridad

SmartNutriTracker contempla medidas básicas de protección de información:

- Contraseñas almacenadas mediante hash.
- Validación de datos durante el registro.
- Comprobación de correos electrónicos duplicados.
- Validación de los roles permitidos en el registro público.
- Separación de responsabilidades mediante servicios y modelos.

## 🐶 Nuestra mascota: Pibble

¡Hola! Soy **Pibble**, la mascota oficial de SmartNutriTracker.

Mi misión es recordarte que una alimentación saludable también puede ser sencilla, organizada y divertida.

**Eat Smart. Live Better.**

## 👥 Equipo de desarrollo

Proyecto académico desarrollado como parte de la asignatura de **Programación Web III**.

- **Institución:** Universidad del Valle (UNIVALLE).
- **Proyecto:** SmartNutriTracker.
- **Repositorio:** [GitHub - SmartNutriTracker](https://github.com/chrischidori27-debug/SmartNutriTracker).

## 📌 Estado del proyecto

**Versión:** 1.0

**Estado:** En desarrollo.

---

<div align="center">

### 💚 SmartNutriTracker

**Pequeños hábitos, grandes cambios.**

Hecho con dedicación por el equipo de desarrollo.

🐾 Pibble te acompaña en el camino.

</div>
