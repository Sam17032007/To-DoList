
# To-DoList

## Descripci�n

Este es un gestor de tareas de consola desarrollado en **C#** con **.NET Framework 4.8**. La aplicaci�n permite a los usuarios agregar, visualizar, marcar como completadas y eliminar tareas de una lista. Tambi�n se puede asignar una fecha l�mite opcional a cada tarea.

## Caracter�sticas

- **Agregar Tarea**: El usuario puede agregar una nueva tarea con una descripci�n. Opcionalmente, puede a�adir una fecha l�mite.
- **Mostrar Tareas**: Muestra la lista de tareas junto con su estado (Pendiente o Completada).
- **Marcar Tarea como Completada**: El usuario puede seleccionar una tarea y marcarla como completada.
- **Eliminar Tarea**: Permite eliminar una tarea de la lista.
  
## Requisitos

- **Visual Studio** (o cualquier IDE compatible con C#).
- **.NET Framework 4.8**.
  
## C�mo ejecutar

### 1. Clonar el repositorio (opcional si usas un sistema de control de versiones):

```bash
git clone https://github.com/usuario/To-DoList.git
```

### 2. Abrir en Visual Studio:

1. Abre **Visual Studio**.
2. Selecciona la opci�n `Abrir un proyecto o soluci�n`.
3. Navega hasta el directorio donde se encuentra el proyecto y selecciona el archivo `To-DoList.sln`.

### 3. Ejecutar el proyecto:

1. En **Visual Studio**, selecciona el archivo `Program.cs` dentro del Explorador de soluciones.
2. Haz clic en `Iniciar` o presiona `F5` para compilar y ejecutar la aplicaci�n.

## Uso de la Aplicaci�n

Al ejecutar la aplicaci�n, se mostrar� un men� con las siguientes opciones:

```
1. Agregar Tarea
2. Mostrar Tareas
3. Marcar Tarea como Completada
4. Eliminar Tarea
5. Salir
```

### 1. Agregar Tarea
- El usuario debe ingresar la descripci�n de la tarea que desea agregar.
- La aplicaci�n luego pregunta si se desea establecer una fecha l�mite (opcional). Si el usuario responde **"s"**, debe ingresar una fecha en el formato **dd/mm/yyyy**. Si responde **"n"**, la tarea se registrar� sin fecha l�mite.
  
#### Posibles casos:
- Si se ingresa un formato de fecha incorrecto, se le pedir� al usuario que ingrese nuevamente una fecha v�lida hasta que sea correcta.
- Si no se ingresa ninguna descripci�n, la tarea ser� a�adida con una descripci�n vac�a.

**Ejemplo**:
```
Ingrese la descripci�n de la tarea: Comprar frutas
�Desea ingresar una fecha l�mite? (s/n): s
Ingrese la fecha l�mite (dd/mm/yyyy): 25/09/2024
```

### 2. Mostrar Tareas
- Se muestra una lista con todas las tareas existentes. Cada tarea se muestra con su descripci�n, fecha l�mite (si tiene), y su estado (**Completada** o **Pendiente**).
- Si no hay tareas registradas, se mostrar� el mensaje **"No hay tareas"**.

#### Posibles casos:
- Si no hay tareas en la lista, el programa indicar� que no existen tareas.

**Ejemplo**:
```
1. Comprar frutas (Limite: 25/09/2024) - Pendiente
2. Limpiar la casa (Sin fecha l�mite) - Completada
```

### 3. Marcar Tarea como Completada
- Primero se mostrar� la lista de tareas.
- El usuario debe ingresar el n�mero correspondiente a la tarea que desea marcar como completada.
  
#### Posibles casos:
- Si el usuario ingresa un n�mero incorrecto (fuera de rango o no num�rico), se mostrar� el mensaje **"�ndice no v�lido"**.
- Si la tarea ya est� completada, se puede marcar como completada de nuevo sin errores, pero no cambiar� su estado.

**Ejemplo**:
```
Seleccione el n�mero de la tarea que desea marcar como completada: 1
Tarea marcada como completada.
```

### 4. Eliminar Tarea
- Primero se mostrar� la lista de tareas.
- El usuario debe seleccionar el n�mero correspondiente a la tarea que desea eliminar.
  
#### Posibles casos:
- Si el usuario ingresa un n�mero incorrecto (fuera de rango o no num�rico), se mostrar� el mensaje **"�ndice no v�lido"**.
- Si la tarea seleccionada es v�lida, se eliminar� de la lista permanentemente.

**Ejemplo**:
```
Seleccione el n�mero de la tarea que desea eliminar: 2
Tarea eliminada.
```

### 5. Salir
- Al seleccionar esta opci�n, la aplicaci�n se cerrar�.

#### Posibles casos:
- No hay casos especiales en esta opci�n; el programa simplemente termina su ejecuci�n.
