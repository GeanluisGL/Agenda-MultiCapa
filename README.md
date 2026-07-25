```markdown
# 📒 Agenda Electrónica Multicapa

[![GitHub](https://img.shields.io/badge/Repositorio-GeanluisGL%2FAgenda--MultiCapa-blue?logo=github)](https://github.com/GeanluisGL/Agenda-MultiCapa)
[![Estado del Proyecto](https://img.shields.io/badge/Estado-Completado-brightgreen)]()
[![Lenguaje](https://img.shields.io/badge/Lenguaje-C%23-purple)]()

## 📝 Descripción del Proyecto

Este proyecto es una **agenda electrónica** desarrollada como práctica de programación bajo una **arquitectura multicapa**. Su objetivo principal es implementar las cuatro funcionalidades básicas de un sistema de gestión de contactos:

-   ➕ **Insertar**: Añadir nuevos contactos a la agenda.
-   ✏️ **Modificar**: Actualizar la información de contactos existentes.
-   ❌ **Eliminar**: Borrar contactos de la agenda.
-   🔍 **Buscar**: Consultar y localizar contactos de manera eficiente.

La aplicación está construida siguiendo los principios de separación de responsabilidades vistos en clase, lo que facilita su mantenimiento, escalabilidad y pruebas.

## 🏗️ Arquitectura del Proyecto

La solución está organizada en las siguientes capas, cada una con una responsabilidad clara dentro del proyecto:

```text
Agenda-MultiCapa/
├── D_EA/           # Capa de Datos (Data Access Layer)
├── E_EA/           # Capa de Entidades (Entities Layer)
├── N_EA/           # Capa de Negocio (Business Logic Layer)
├── P_EA/           # Capa de Presentación (Presentation Layer)
├── packages/       # Paquetes NuGet utilizados
├── AE(A).sln       # Archivo de solución de Visual Studio
├── Querry(A).sql   # Scripts de la base de datos
└── Links.txt       # Enlaces de interés o referencias
```

### Descripción de Capas

1.  **`P_EA` (Capa de Presentación)**: Es la interfaz de usuario. Aquí se encuentra el formulario o consola que interactúa directamente con el usuario final. Su función es mostrar los datos y capturar las entradas del usuario.

2.  **`N_EA` (Capa de Negocio)**: Contiene la lógica de negocio de la aplicación. Actúa como un intermediario, procesando los datos que recibe de la presentación, aplicando reglas de negocio (validaciones, cálculos, etc.) y comunicándose con la capa de datos para recuperar o persistir información.

3.  **`D_EA` (Capa de Datos)**: Responsable del acceso y la persistencia de los datos. Se encarga de las operaciones CRUD (Crear, Leer, Actualizar, Eliminar) contra la base de datos, ejecutando procedimientos almacenados y traduciendo los resultados a objetos que la capa de negocio pueda entender.

4.  **`E_EA` (Capa de Entidades)**: Define las clases que representan los objetos del mundo real (por ejemplo, `Contacto`). Estas clases son simples (POCOs) y se utilizan para transportar datos a través de las diferentes capas, sin lógica de negocio.

## 🗄️ Base de Datos

La estructura de la base de datos se define en el script `Querry(A).sql`. Este script incluye:

-   La creación de las tablas necesarias para almacenar los contactos.
-   Procedimientos almacenados (`SP_INSERT`, `SP_UPDATE`, `SP_DELETE`, `SP_SELECT`) para manejar las operaciones de datos desde la capa de acceso a datos.

> **Nota:** El repositorio muestra un commit reciente (13 de julio de 2026) con una corrección en la sintaxis para el procedimiento `SP_UPDATE`, lo que indica que el proyecto ha sido mantenido y mejorado.

## 🚀 Tecnologías Utilizadas

-   **Lenguaje de Programación:** C#
-   **Framework / Plataforma:** .NET (especificado en la solución `AE(A).sln`)
-   **Base de Datos:** SQL Server (inferido por el script `Querry(A).sql`)
-   **Arquitectura:** Multicapa / N-Tier

## ⚙️ Cómo Ejecutar el Proyecto

Para poner en marcha la aplicación en tu entorno local, sigue estos pasos:

1.  **Clonar el repositorio:**
    ```bash
    git clone https://github.com/GeanluisGL/Agenda-MultiCapa.git
    ```

2.  **Abrir la solución:** Abre el archivo `AE(A).sln` con Visual Studio (versión 2019 o superior recomendada).

3.  **Configurar la Base de Datos:**
    -   Ejecuta el script `Querry(A).sql` en tu instancia de SQL Server para crear la base de datos, las tablas y los procedimientos almacenados.
    -   Actualiza la cadena de conexión en la capa de datos (`D_EA`) para que apunte a tu servidor SQL.

4.  **Compilar y Ejecutar:** Compila la solución y ejecuta el proyecto de la capa de presentación (`P_EA`).

## 🤝 Contribuciones

Este es un proyecto de práctica académica, pero si tienes sugerencias o mejoras, no dudes en abrir un *issue* o enviar un *pull request*.

## 👤 Autor

-   **GeanluisGL** - [Perfil de GitHub](https://github.com/GeanluisGL)

---
