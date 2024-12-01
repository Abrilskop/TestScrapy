# TestScrapy

TestScrapy es un proyecto de web scraping que utiliza la librería [HtmlAgilityPack](https://www.nuget.org/packages/HtmlAgilityPack/) y [ScrapySharp](https://github.com/Hazakura/ScrapySharp) para extraer información de sitios web. Actualmente, el proyecto incluye ejemplos de cómo hacer scraping en sitios como **Xataka** y **SUNAT**.

## Descripción

El proyecto está diseñado para realizar scraping de sitios web específicos utilizando clases de C# como `HtmlWeb` de **HtmlAgilityPack** y `CssSelect` de **ScrapySharp**. A través de estas herramientas, se puede extraer información estructurada de páginas web.

### Funcionalidades actuales:

- **Scraping de Xataka**: Extraer titulares de noticias en la página principal de Xataka.
- **Scraping de SUNAT**: Obtener información sobre los trámites de SUNAT desde su portal oficial.
- **Scraping del menú de SUNAT**: Extraer los elementos del menú de SUNAT desde la página de menú de servicios.

## Requisitos

Para ejecutar este proyecto en tu máquina local, asegúrate de tener instalado lo siguiente:

- **.NET 8.0** o superior
- **HtmlAgilityPack** y **ScrapySharp** como dependencias de NuGet
