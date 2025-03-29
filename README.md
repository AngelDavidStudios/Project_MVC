# Documentación del proyecto Calculadora de Propinas
![Vue](https://img.shields.io/npm/v/vue?label=Vue&color=green)
 ![TypeScript](https://img.shields.io/npm/v/typescript?style=flat&label=TypeScript) ![Tailwind](https://img.shields.io/npm/v/tailwindcss?style=flat&label=Tailwind%20CSS&color=06B6D4) ![Vite](https://img.shields.io/npm/v/vite?style=flat&label=Vite&color=646CFF) ![Static Badge](https://img.shields.io/badge/dotnet-purple?logo=dotnet&label=.NET%208.0)




### 🌀 Proyecto MVC de la tematica My Hero Academia 🌀

> Como introducción general este proyecto es realizado con el tema de MVC, en la cual yo debo escoger el framework tanto para FrontEnd como para backend.
> En este caso escogí **Vue** para el FrontEnd y **.NET 8.0** para el Backend, en el cual se realizo un CRUD de los personajes de la serie My Hero Academia.
> Para el Backend .NET use el marco o Framework Aspire para poder realizar el levantamiento tanto el FrontEnd como Backend. Aspire es un marco de orquestación 
> donde al usar dicho patron arquitectónico me permite integrar de forma fácil mis proyectos y ejecutarlos. Ademas Aspire ofrece el tema de la telemetría y el
> Health System para poder monitorear el estado de la aplicación, y en caso de fallos poder corregirlos sin tener que estar en la terminal de comandos.

## Lista de elementos aplicados y aprendidos en este proyecto

| #  | Tema                   | Descripción                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Complejidad |
|----|------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------|
| 00 | **Vue Components**     | Una de las mejores maneras de trabajar en el FrontEnd es la separacion de componentes, para este caso para componente principal lo sub dividi en componentes para tener un mejor orden al codigo y que sea agradable a la vista. Para el caso de Vue use el moderno Composition API junto con el Script Setup                                                                                                                                                                                                                          |![Static Badge](https://img.shields.io/badge/100-green?style=flat&label=Baja)
| 01 | **Props y Emits**      | Al separar los componentes se hace necesario que todos los componentes se comuniquen y esten atento a los estados y cambios, por ello el uso de los props para comunicar desde el Padre hacia los Hijos y los emits viceversa.                                                                                                                                                                                                                                                                                                         |![Static Badge](https://img.shields.io/badge/100-green?style=flat&label=Baja)
| 02 | **Tailwind CSS**       | Para realizar los estilos con efectividad sin necesidad de una caratula llena de estilos mezclados y confusos en CSS. Tailwind es un framework que facilita poner estilos mientras se va diseñando y renderizando cada componente dentro de HTML.                                                                                                                                                                                                                                                                                      |![Static Badge](https://img.shields.io/badge/60-yellow?style=flat&label=Medio)
| 03 | **Types**              | Parte del lenguaje TypeScript los Type son una utilidad valiosa ya que permite declarar los tipos a las variables **(string - number - boolean)** sin dejar ningun rastro de **Any**.                                                                                                                                                                                                                                                                                                                                                  |![Static Badge](https://img.shields.io/badge/90-green?style=flat&label=Baja)
| 04 | **Vue Composables**    | Al igual que la filosofia de los Custom Hooks de React, en Vue existen los Composables donde permite de mejor forma almacenar la logica como las operaciones CRUD del cosumo del API, entre otros.                                                                                                                                                                                                                                                                                                                                     |![Static Badge](https://img.shields.io/badge/90-green?style=flat&label=Baja)
| 05 | **Repository Pattern** | Para que posteriormente la aplicacion sea escalable se hace el uso del patron de repositorio en la cual es una manera correcta de usar las interfaces y el repositorio para las operaciones CRUD ya que el dia de mañana se pide un cambio y en vez de cambiar enteramente los codigos que puede llegar a ser tedioso, la major manera de cambiar es desde la interfaz del repositorio y automaticamente las implementaciones no afectan la aplicaciôn.                                                                                |![Static Badge](https://img.shields.io/badge/90-green?style=flat&label=Baja)
| 05 | **MVC**                | **MVC** es considerado el patron mas antiguo lo cual en su tiempo era el mas efectivo al momento de desarrollar una aplicación. Este patron cosiste en la separacion de resposabilidades, el modelo, la vista y el controlador. Existen varias maneras de implementar el patron MVC, en mi caso aplique el MC para el backend y el V para la vista que es el FrontEnd y lo unifique en un solo proyecto. Este patron sirve mucho para nivel educativo pero para proyectos mas grandes se hae el uso de patrones modernos como el MVVM. |![Static Badge](https://img.shields.io/badge/90-green?style=flat&label=Baja)

## Tecnologias usadas

![Vue](https://img.shields.io/badge/VueJs--TS-%234FC08D?style=for-the-badge&logo=vue.js&label=FRAMEWORK&labelColor=black)
 ![Static Badge](https://img.shields.io/badge/typescript-blue?style=for-the-badge&logo=typescript&label=language&labelColor=black) ![Static Badge](https://img.shields.io/badge/tailwind--css-06B6D4?style=for-the-badge&logo=tailwindcss&label=framework&labelColor=black) ![Static Badge](https://img.shields.io/badge/vite-646CFF?style=for-the-badge&logo=Vite&label=Tool&labelColor=black)
![Aspire](https://img.shields.io/badge/Aspire-%234381C3?style=for-the-badge&logo=dotnet&label=FRAMEWORK&labelColor=black) ![Static Badge](https://img.shields.io/badge/.NET%208.0-%23512BD4?style=for-the-badge&logo=dotnet&label=TOOL&labelColor=black)![Static Badge](https://img.shields.io/badge/CSharp-%23512BD4?style=for-the-badge&logo=dotnet&label=LANGUAGE&labelColor=black)





## Instrucciones

**Si desea revisar el proyecto, puede clonar con git clone o descargar Zip.**

1. Existen dos maneras de ejecutar el proyecto el uno es solamente abrir la solución de Visual Studio o Rider y luego ejeuctar ya que inmediatamente se instala las dependencias de Nugget y de NPM.
---
2. La segunda manera de ejecutar solo el FrontEnd de Vue es acceder a la misma carpeta dentro del proyecto desdecargado llamado **HEROES-UI** ahi ejecutar los siguientes comandos:

``` bash
npm install
```
2. Una vez instalado las dependencias proceda a ejecutar el proyecto mediante el comando:

``` bash
npm run start
```

---

## <img src="https://github.com/AngelDavidStudios/calculadora-propinas/blob/main/src/resources/ads-emote.JPG" width="55" height="55"> Hola, mi nombre es David Angel.
### Multimedia Desginer & Software Architect

Soy diseñador Multimedia cursando una segunda carrera en Ingeniería de Software, me estoy especializando en el desarrollo Backend como arquitecto de software, en este recorrido dia tras dia aprendo tecnologias nuevas.

David Angel Studios es mi marca personal donde mi misión es desarrollar diversos proyectos basado en mi apredizaje de nuevas tecnologias y almacenarlas en mi portafolio personal:

[![Static Badge](https://img.shields.io/badge/Linkedin-4479A1?style=for-the-badge&logo=9gag&label=Angel%20David%20Studios&labelColor=black)](https://www.linkedin.com/in/angeldavidstudios/)
[![Static Badge](https://img.shields.io/badge/Instagram-FF0069?style=for-the-badge&logo=instagram&label=Angel%20David%20Studios&labelColor=black)](https://www.instagram.com/angeldavidstudios/) [![Static Badge](https://img.shields.io/badge/Angel--David--Studios-FF0000?style=for-the-badge&logo=youtube&label=Youtube.com%2F&labelColor=black)](https://www.youtube.com/channel/UC2VYRq169QluoLeagCYrjVg)