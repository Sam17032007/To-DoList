
# To-DoList

## Descripción

Este es un gestor de tareas de consola desarrollado en **C#** con **.NET Framework 4.8**. La aplicación permite a los usuarios agregar, visualizar, marcar como completadas y eliminar tareas de una lista. También se puede asignar una fecha límite opcional a cada tarea.

## Características

- **Agregar Tarea**: El usuario puede agregar una nueva tarea con una descripción. Opcionalmente, puede añadir una fecha límite.
- **Mostrar Tareas**: Muestra la lista de tareas junto con su estado (Pendiente o Completada).
- **Marcar Tarea como Completada**: El usuario puede seleccionar una tarea y marcarla como completada.
- **Eliminar Tarea**: Permite eliminar una tarea de la lista.
  
## Requisitos

- **Visual Studio** (o cualquier IDE compatible con C#).
- **.NET Framework 4.8**.
  
## Cómo ejecutar

### 1. Clonar el repositorio (opcional si usas un sistema de control de versiones):

```bash
git clone https://github.com/usuario/To-DoList.git
```

### 2. Abrir en Visual Studio:

1. Abre **Visual Studio**.
2. Selecciona la opción `Abrir un proyecto o solución`.
3. Navega hasta el directorio donde se encuentra el proyecto y selecciona el archivo `To-DoList.sln`.

### 3. Ejecutar el proyecto:

1. En **Visual Studio**, selecciona el archivo `Program.cs` dentro del Explorador de soluciones.
2. Haz clic en `Iniciar` o presiona `F5` para compilar y ejecutar la aplicación.

## Uso de la Aplicación

Al ejecutar la aplicación, se mostrará un menú con las siguientes opciones:

```
1. Agregar Tarea
2. Mostrar Tareas
3. Marcar Tarea como Completada
4. Eliminar Tarea
5. Salir
```

### 1. Agregar Tarea
- El usuario debe ingresar la descripción de la tarea que desea agregar.
- La aplicación luego pregunta si se desea establecer una fecha límite (opcional). Si el usuario responde **"s"**, debe ingresar una fecha en el formato **dd/mm/yyyy**. Si responde **"n"**, la tarea se registrará sin fecha límite.
  
#### Posibles casos:
- Si se ingresa un formato de fecha incorrecto, se le pedirá al usuario que ingrese nuevamente una fecha válida hasta que sea correcta.
- Si no se ingresa ninguna descripción, la tarea será añadida con una descripción vacía.

**Ejemplo**:
```
Ingrese la descripción de la tarea: Comprar frutas
¿Desea ingresar una fecha límite? (s/n): s
Ingrese la fecha límite (dd/mm/yyyy): 25/09/2024
```

### 2. Mostrar Tareas
- Se muestra una lista con todas las tareas existentes. Cada tarea se muestra con su descripción, fecha límite (si tiene), y su estado (**Completada** o **Pendiente**).
- Si no hay tareas registradas, se mostrará el mensaje **"No hay tareas"**.

#### Posibles casos:
- Si no hay tareas en la lista, el programa indicará que no existen tareas.

**Ejemplo**:
```
1. Comprar frutas (Limite: 25/09/2024) - Pendiente
2. Limpiar la casa (Sin fecha límite) - Completada
```

### 3. Marcar Tarea como Completada
- Primero se mostrará la lista de tareas.
- El usuario debe ingresar el número correspondiente a la tarea que desea marcar como completada.
  
#### Posibles casos:
- Si el usuario ingresa un número incorrecto (fuera de rango o no numérico), se mostrará el mensaje **"Índice no válido"**.
- Si la tarea ya está completada, se puede marcar como completada de nuevo sin errores, pero no cambiará su estado.

**Ejemplo**:
```
Seleccione el número de la tarea que desea marcar como completada: 1
Tarea marcada como completada.
```

### 4. Eliminar Tarea
- Primero se mostrará la lista de tareas.
- El usuario debe seleccionar el número correspondiente a la tarea que desea eliminar.
  
#### Posibles casos:
- Si el usuario ingresa un número incorrecto (fuera de rango o no numérico), se mostrará el mensaje **"Índice no válido"**.
- Si la tarea seleccionada es válida, se eliminará de la lista permanentemente.

**Ejemplo**:
```
Seleccione el número de la tarea que desea eliminar: 2
Tarea eliminada.
```

### 5. Salir
- Al seleccionar esta opción, la aplicación se cerrará.

#### Posibles casos:
- No hay casos especiales en esta opción; el programa simplemente termina su ejecución.
