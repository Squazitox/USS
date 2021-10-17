# Bienvenido a la guía de contribución de documentos de GitHub <!-- omit in toc -->


¡Gracias por invertir su tiempo en contribuir a nuestro proyecto! Cualquier contribución que hagas se reflejará en [docs.github.com](https://docs.github.com/en) :sparkles:.


Lea nuestro [Code of Conduct](./CODE_OF_CONDUCT.md) para mantener a nuestra comunidad accesible y respetable.

En esta guía, obtendrá una visión general del flujo de trabajo de contribución desde la apertura de un problema, la creación de un PR, la revisión y la fusión del PR.

Utilice el icono <img src="./assets/images/table-of-contents.png" width="25" height="25" /> de la tabla de contenido en la esquina superior izquierda de este documento para llegar rápidamente a una sección específica de esta guía.

## Nueva guía para colaboradores

Para obtener una visión general del proyecto, lea el archivo [README](README.md). Aquí hay algunos recursos para ayudarlo a comenzar con las contribuciones de código abierto:

- [Encontrar formas de contribuir al código abierto en GitHub](https://docs.github.com/en/get-started/exploring-projects-on-github/finding-ways-to-contribute-to-open-source-on-github)
- [Configurar Git](https://docs.github.com/en/get-started/quickstart/set-up-git)
- [Flujo de GitHub](https://docs.github.com/en/get-started/quickstart/github-flow)
- [Colaboración con solicitudes de extracción](https://docs.github.com/en/github/collaborating-with-pull-requests)

## Empezar

Para navegar por nuestra base de código con confianza, consulte [la introducción al trabajo en el repositorio de documento](/contributing/working-in-docs-repository.md) :confetti_ball:.. Para obtener más información sobre cómo escribimos nuestros archivos de markdown, consulta la referencia de GitHub Markdown.

Verifique qué tipos de contribuciones aceptamos antes de realizar cambios. Algunos de ellos ni siquiera requieren escribir una sola línea de código ✨.

### Cuestiones

## Crear un nuevo problema

Si detecta un problema con los documentos, busque si ya existe un problema. Si no existe un problema relacionado, puede abrir un nuevo problema utilizando un formulario de problemarelevante.

## Resolver un problema

Revise nuestros problemas existentes para encontrar uno que le interese. Puede reducir la búsqueda utilizando como filtros. Consulte Etiquetas para obtener más información.labels

### Realizar cambios

#### Realizar cambios en la interfaz de usuario

Haz clic en Hacer una contribución en la parte inferior de cualquier página de documentos para realizar pequeños cambios, como un error tipográfico, una corrección de oración o un vínculo roto. Esto lo lleva al archivo donde puede realizar los cambios y crear una solicitud de extracción para una revisión..md

#### Realizar cambios localmente

1. [Instalar Git LFS](https://docs.github.com/en/github/managing-large-files/versioning-large-files/installing-git-large-file-storage).

2. Bifurcar el repositorio.

- Usando GitHub Desktop:

- [Comenzar con GitHub Desktop](https://docs.github.com/en/desktop/installing-and-configuring-github-desktop/getting-started-with-github-desktop)lo guiará a través de la configuración de Desktop.

- Una vez que el escritorio está configurado, puede usarlo para [bifurcar el repositorio](https://docs.github.com/en/desktop/contributing-and-collaborating-using-github-desktop/cloning-and-forking-repositories-from-github-desktop)

- Usando la línea de comandos:

- [Bifurque el repositorio](https://docs.github.com/en/github/getting-started-with-github/fork-a-repo#fork-an-example-repository) para que pueda realizar los cambios sin afectar al proyecto original hasta que esté listo para fusionarlos.

Espacios de código de GitHub:

Bifurque, edite y obtenga una vista previa con GitHub Codespaces sin tener que instalar y ejecutar el proyecto localmente.
Instale o actualice a Node.js v16. Para obtener más información, consulte la guía de desarrollo.

¡Crea una rama de trabajo y comienza con tus cambios!

Confirme su actualización
Comete los cambios una vez que estés satisfecho con ellos. Consulta la guía de contribución de Atom para saber cómo usar emoji para mensajes de confirmación.

Una vez que sus cambios estén listos, no olvide auto-revisar para acelerar el proceso de revisión⚡.

Solicitud de extracción
Cuando haya terminado con los cambios, cree una solicitud de extracción, también conocida como PR.

Complete la plantilla "Listo para revisión" para que podamos revisar su PR. Esta plantilla ayuda a los revisores a comprender sus cambios, así como el propósito de su solicitud de extracción.
No olvide vincular las relaciones públicas al problema si está resolviendo uno.
Habilite la casilla de verificación para permitir las ediciones del mantenedor de modo que la rama se pueda actualizar para una combinación. Una vez que envíe su PR, un miembro del equipo de Docs revisará su propuesta. Podemos hacer preguntas o solicitar información adicional.
Podemos solicitar que se realicen cambios antes de que se pueda fusionar un PR, ya sea utilizando cambios sugeridos o comentarios de solicitud de extracción. Puede aplicar los cambios sugeridos directamente a través de la interfaz de usuario. Puede realizar cualquier otro cambio en su bifurcación y luego comprometerlo en su sucursal.
A medida que actualice su PR y aplique cambios, marque cada conversación como resuelta.
Si tiene algún problema de combinación, consulte este tutorial de git para ayudarlo a resolver conflictos de combinación y otros problemas.
¡Tus relaciones públicas se fusionan!
Felicitaciones 🎉🎉 El equipo de GitHub te agradece ✨.

Una vez que se fusionen sus relaciones públicas, sus contribuciones serán visibles públicamente en los documentos de GitHubs.

Ahora que eres parte de la comunidad de documentos de GitHub, mira de qué otra manera puedes contribuir a los documentos.

Windows
Este sitio se puede desarrollar en Windows, sin embargo, se deben tener en cuenta algunos gotchas potenciales:

Expresiones regulares: Windows usa para terminaciones de línea, mientras que los sistemas basados en Unix usan . Por lo tanto, cuando trabaje en expresiones regulares, use en lugar de para admitir ambos entornos. El sistema operativo Node.js. La propiedad EOL se puede usar para obtener un marcador de fin de línea específico del sistema operativo.\r\n\n\r?\n\n
Rutas: Los sistemas Windows utilizan para el separador de rutas, que sería devuelto por y otros. Puede usar , etc. y el módulo de barra diagonal, si necesita barras diagonales, como para construir URL, o asegurarse de que su código funcione con cualquiera de los dos.\path.joinpath.posixpath.posix.join
Bash: No todos los desarrolladores de Windows tienen un terminal que sea totalmente compatible con Bash, por lo que generalmente se prefiere escribir scripts en JavaScript en lugar de Bash.
Error de nombre de archivo demasiado largo: hay un límite de 260 caracteres para un nombre de archivo cuando Git se compila con . Si bien no se garantiza que las sugerencias a continuación funcionen y posiblemente podrían causar otros problemas, algunas soluciones incluyen: msys
Actualizar la configuración de Git: git config --system core.longpaths true
Considere la posibilidad de usar un cliente git diferente en Windows
