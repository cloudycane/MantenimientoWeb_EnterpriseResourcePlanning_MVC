# MantenimientoWeb Enterprise Resource Planning (ERP) MVC - Manejo de Sistema Inventario (Inventory Management System)
 
![gif](https://user-images.githubusercontent.com/74038190/219923823-bf1ce878-c6b8-4faa-be07-93e6b1006521.gif)

<h2>Enlace para la página: http://mantenimientoweb.somee.com</h2>
<h2>Table of contents</h2>
 <li>Sobre el proyecto</li>
 <li>Características del proyecto</li>
 <li>Funciones</li>
<h4>Estructura</h4>
     <li>Capa de Dominio o Core</li>
     <li>Capa de Aplicación</li>
     <li>Capa de Infraestructura</li>
     <li>Capa de Presentación</li>

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



