# MantenimientoWeb Enterprise Resource Planning (ERP) MVC - Manejo de Sistema Inventario (Inventory Management System)
 
![gif](https://user-images.githubusercontent.com/74038190/219923823-bf1ce878-c6b8-4faa-be07-93e6b1006521.gif)

Enlace para la página: http://mantenimientoweb.somee.com/
<h2>Table of contents</h2>
 <li>Sobre el proyecto</li>
 <li>Características del proyecto</li>
 <li>Funciones</li>
 <li>Proceso del diseño de la arquitectura de la aplicación</li>
<h4>Estructura</h4>
     <li>Capa de Dominio o Core</li>
     <li>Capa de Aplicación</li>
     <li>Capa de Infraestructura</li>
     <li>Capa de Presentación</li>
     <li>Capa de Pruebas - <i>no hay contenidos, pero sirve para futuro uso**</i></li>
<h1>Sobre el proyecto</h1>
<b>-Fecha de creación del proyecto: </b> 23 de Agosto 2024 - 12 de Septiembre 2024
<br>
<b>-Lenguajes de Programación: </b> C#, HTML, CSS, JavaScript, JQuery, bootstrap, SQL Server
<br>
<b>-Entorno de Trabajo:</b> Visual Studios 2022, ASPNET MVC 6, .NET 6, SQL Management Server Studio
<br>
<b>-Descripción: Se trata de una simple aplicación de planificación de recursos empresariales (Entreprise Resource Planning) para un sistema de manejo de inventarios (Inventory Management System).</b>
<hr>
<h1>Características del proyecto</h1>
<b>-Dashboard: </b> Organiza y facilita la navegación en las distintas entidades y funcionalidades del proyecto. <br>
<b>-CRUD Operations: </b> Permite el usuario para crear, ver detalles, actualizar, y eliminar datos en el proyecto. <br>
<b>-Busqueda: </b> Permite el usuario hacer una busqueda de lo que desea buscar.
<br>
<b>-Arquítectura: </b> Onion o Clean Architecture/ Arquitectura Por Capas. <br>
<b>-Metodología del desarrollo: </b> Agile Development
<hr>
<h1>Funciones</h1>
<b>-Entidades: </b> Empresa, Producto, Inventario <br>
<b>-ViewModels: </b> Sirve para validar los inputs del usuario (filtración de datos) antes de pasar a los business models (entidades) <br>
<b>-Repositorios y Servicios: </b> Sirve para guardar los métodos para la obtención de datos y las operaciones CRUD antes de pasar a los Controllers (necesitara Dependecy Injection para usar repositorios y servicios).
<br>
<hr>
<h1>Fases o Proceso del diseño de la arquitectura de la aplicación</h1>
📚Aprendizaje: Guía de Arquitectura N-Capas Orientada al Dominio con .NET 4.0

<h2>1ª Fase: Identificación de los Objetivos de Iteración --Iteración 1--</h2>
<b>Objetivos Identificados de Iteración:</b>
<li><u>Creación de la entidad de productos y la relación con categorías y proveedores(empresa):</u> Informara el sistema si se puede empezar almacenar información básica sobre los productos. Sin un SOLID principle para gestionar los productos, no se puede avanzar en otras funcionalidades como la creación de la entidad de Inventario.</li>
<li><u>Diseñar la interfaz para el registro de productos:</u>Creación de interfaz para que los usuarios pueden registrar productos, asignarles categorías y asociarlos con proveedores.</li>
<li><u>Implementar la lógica de negocio para validación de datos:</u> En mi caso, antes de pasar las entidades y registrar datos en la base de datos, he creado ViewModels para hacer los "business logics" y "business validations" y luego aplicarlos en las entidades a partir de un mapeo de ViewModels a Entidades o viceversa (también se puede hacer con un AutoMapper). </li>
<li><u>Establecer la infraestructura de la base de datos:</u> configuration de connection strings para conectar con SQL Server y crear las primeras tablas necesarias como Empresas, Productos, etc. ya que el sistema necesita una base de datos para poder almacenar y gestionar la información desde las primeras iteraciones. Si el Entity Framework se trata de Table-First, las tablas se pueden crear dentro de SQL Management Studio y se trata de Code-First se hacen migraciones dentro del ApplicationDbContext/Consola de Nuget Package Manager</li>
<h2>2ª Fase: Seleccionar los casos de uso (Use Cases) arquitecturalmente importantes</h2>
<li>En mi proyecto he utilizado Use Cases o Casos de Usos en  forma de GetQueries o queries para hacer una lectura o consultas.</li>
<li>Podría integrar más Casos de Usos en el proyecto como la gestión de usuarios (Autenticación y Autorización), Gestión de Pedidos, Generación de Reportes, Notificaciones y Alertas, Gestión de Roles y Permisos, Carrito de Compras, etc. pero estos elementos es para un proyecto de gran escalabilidad y complejidad.</li>
<h2>3ª Fase: Realizar un esquema del sistema</h2>
<h2>4ª Fase: Identificación de los principales riesgos y definición de solución</h2>
<h2>5ª Fase: Creación de arquitecturas candidatas</h2>
<h2>6ª Fase: Aspectos de Domain Driven Design</h2>
<hr>

<h1>Estructura/Arquitectura: Capa de Dominio o Core</h1> 
<p>La capa más interno del proyecto. Aquí almacenemos las entidades que vamos a usar en el proyecto.</p>
<br>
<b>-Referencia:</b> N/A

<hr>
<h1>Estructura/Arquitectura: Capa de Aplicación</h1>
<p>Aquí almacenemos los DTOs, Servicios de Aplicación, Use Cases, etc.</p>
<br>
<b>-Referencia: </b> Capa de Dominio o Core

<hr>
<h1>Estructura/Arquitectura: Capa de Infraestructura </h1> 
<p>Aquí almacenemos los repositorios, sus interfaces, datos para la base de datos, ApplicationDbContext, etc.</p>
<br>
<b>-Referencia: </b> Capa de Aplicación y Capa de Dominio o Core

<hr>
<h1>Estructura/Arquitectura: Capa de Presentación </h1> 
<p>La capa más externa del proyecto. Aquí almacenemos los Controllers, ViewModels y Models, Views, Partial Views, Contents (css,js, jqueries, bootstraps), etc.</p>
<br>
<b>-Referencia: </b> Capa de Aplicación, Capa de Infraestructura, Capa de Dominio.



