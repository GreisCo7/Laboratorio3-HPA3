# Laboratorio 3

## Objetivo
Desarrollar soluciones en C# aplicando los principios de la Programación Orientada a Objetos (POO), diseño de interfaces gráficas de usuario (GUI) interactivas mediante Windows Forms, persistencia temporal de datos y la implementación de una arquitectura unificada de ventanas múltiples (MDI).

## Requisitos Previos

| Tecnología | Versión / Tipo |
| :--- | :--- |
| **Lenguaje** | C# (.NET Framework / .NET) |
| **Entorno de Desarrollo** | Microsoft Visual Studio 2022 |
| **Interfaz Gráfica** | Windows Forms (Escritorio) |
| **Control de Versiones** | Git & GitHub |

## Estructura del Proyecto

| Carpeta / Archivo | Función |
| :--- | :--- |
| **Laboratorio3T1/** | Proyecto de consola que modela la lógica interna del juego de azar Craps |
| **Laboratorio3T2/** | Proyecto GUI de Windows Forms para captura y visualización de datos |
| **Laboratorio3T3/** | Formulario contenedor principal (MDI Padre) y pantallas secundarias (Hijas) |

## Instalación y Ejecución

### 1. Clonar el repositorio
```bash
git clone https://github.com
```

### 2. Abrir en el entorno local
Abra la solución o carpetas del proyecto directamente desde **Microsoft Visual Studio 2022**.

### 3. Ejecutar el proyecto
Seleccione el proyecto que desea probar como proyecto de inicio, y presione la tecla **F5** o dé clic en el botón "Iniciar".

---

## Resultados

### 1. Modelado de Clases y Lógica de Negocio (Consola)
* **Descripción:** Modelado de la lógica interna de una aplicación utilizando los fundamentos de la Programación Orientada a Objetos (POO) y estructuras de control para resolver simulaciones basadas en el azar.
* **Explicación:** Se desarrolló el caso de estudio del Juego de Craps. Se encapsuló la lógica usando propiedades y métodos específicos para tirar dados con la clase `Random`. Se crearon enumeraciones (`enum Estado` y `enum NombresDados`) para controlar el flujo de victoria, derrota o continuidad del jugador mediante conversiones explícitas de tipo (casting).

<img width="457" height="509" alt="image" src="https://github.com/user-attachments/assets/b2d03592-f56e-402d-b28c-589058473b1f" />


### 2. Interfaces Gráficas de Usuario en Windows Forms (Escritorio)
* **Descripción:** Diseño y construcción de una interfaz gráfica de usuario (GUI) para la captura, persistencia temporal y visualización tabular de datos de colaboradores.
* **Explicación:** Se maquetó un formulario de registro con controles básicos (`TextBox`, `Label`). Se implementó un contenedor `ArrayList` para almacenar los objetos de la clase `Persona.cs` en memoria. Estos datos se enlazaron de forma directa a un `DataGridView` (`dgvdatos`) mediante su propiedad `DataSource`. También se integraron componentes avanzados como `DateTimePicker` para la fecha de nacimiento y un `ToolStrip` para la barra de herramientas superior.

<img width="703" height="730" alt="image" src="https://github.com/user-attachments/assets/03ec5785-47c7-47c8-b04d-a11aaa67f809" />


### 3. Interfaces de Documentos Múltiples (MDI)
* **Descripción:** Implementación de una arquitectura jerárquica de ventanas donde una pantalla principal unificada actúa como el contenedor operativo de múltiples pantallas secundarias.
* **Explicación:** Se convirtió el formulario principal en un contenedor MDI Padre modificando la propiedad `IsMdiContainer = true`. Desde un botón del `ToolStrip`, se programó la apertura de la ventana hija (`frmVentanaTexto`), asociando su propiedad `.MdiParent = this;` antes de invocarla con el método `.Show()`.

<img width="433" height="377" alt="image" src="https://github.com/user-attachments/assets/f9c746bc-42dc-4777-8c71-32ab69d965e0" />


---

## Fecha de Ejecución
13 de Septiembre de 2026

| Datos del Estudiante | Detalles |
| :--- | :--- |
| **Nombre** | Greisy Coronado |
| **Correo** | greisy.coronado@utp.ac.pa |
| **Curso** | Herramientas de Programación Aplicada III |
| **Instructor** | Ing. Irina Fong |
