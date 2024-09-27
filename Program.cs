using System;
using System.Collections.Generic;

namespace To_DoList
{
    class Program
    {
        static void Main()
        {
            // Se crea una lista para almacenar las tareas
            List<Tarea> tareas = new List<Tarea>();
            bool continuar = true;

            // Ciclo principal para mostrar el menú hasta que el usuario decida salir
            while (continuar)
            {
                Console.Clear();  // Limpiar la consola para mostrar el menú limpio cada vez
                Console.WriteLine("Gestor de Tareas - To-Do List");
                Console.WriteLine("1. Agregar Tarea");
                Console.WriteLine("2. Mostrar Tareas");
                Console.WriteLine("3. Marcar Tarea como Completada");
                Console.WriteLine("4. Eliminar Tarea");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                // Leer la opción seleccionada por el usuario y ejecutar la acción correspondiente
                switch (Console.ReadLine())
                {
                    case "1":
                        AgregarTarea(tareas);  // Llama al método para agregar una tarea
                        break;
                    case "2":
                        MostrarTareas(tareas);  // Llama al método para mostrar las tareas
                        break;
                    case "3":
                        MarcarTareaCompletada(tareas);  // Llama al método para marcar una tarea como completada
                        break;
                    case "4":
                        EliminarTarea(tareas);  // Llama al método para eliminar una tarea
                        break;
                    case "5":
                        continuar = false;  // Cambia la variable para salir del ciclo
                        break;
                    default:
                        // Mensaje si el usuario ingresa una opción no válida
                        Console.WriteLine("Opción no válida. Presione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Método para agregar una nueva tarea a la lista
        static void AgregarTarea(List<Tarea> tareas)
        {
            Console.Write("Ingrese la descripción de la tarea: ");
            string descripcion = Console.ReadLine();

            DateTime? fechaLimite = null;  // Variable nullable para la fecha límite, inicialmente sin valor

            // Pregunta al usuario si quiere agregar una fecha límite
            Console.Write("¿Desea ingresar una fecha límite? (s/n): ");
            string respuesta = Console.ReadLine();

            if (respuesta?.ToLower() == "s")  // Si la respuesta es "s", pedir la fecha límite
            {
                Console.Write("Ingrese la fecha límite (dd/mm/yyyy): ");
                DateTime fecha;

                // Validación de que la fecha ingresada es válida
                while (!DateTime.TryParse(Console.ReadLine(), out fecha))
                {
                    Console.Write("Fecha no válida. Ingrese nuevamente (dd/mm/yyyy): ");
                }

                fechaLimite = fecha;  // Asigna la fecha válida a la variable
            }

            // Añadir la nueva tarea a la lista con la descripción y la fecha límite (si aplica)
            tareas.Add(new Tarea { Descripcion = descripcion, FechaLimite = fechaLimite });
            Console.WriteLine("Tarea agregada. Presione una tecla para continuar.");
            Console.ReadKey();  // Pausa antes de volver al menú
        }

        // Método para mostrar todas las tareas
        static void MostrarTareas(List<Tarea> tareas)
        {
            Console.WriteLine("Listado de Tareas:");

            // Verificar si no hay tareas en la lista
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas.");
            }
            else
            {
                // Recorrer la lista de tareas y mostrarlas con su índice
                for (int i = 0; i < tareas.Count; i++)
                {
                    string fechaLimiteTexto = tareas[i].FechaLimite.HasValue ? tareas[i].FechaLimite.Value.ToShortDateString() : "Sin fecha límite";
                    // Muestra la descripción, fecha límite y estado de la tarea (completada o pendiente)
                    Console.WriteLine($"{i + 1}. {tareas[i].Descripcion} (Limite: {fechaLimiteTexto}) - {(tareas[i].Completada ? "Completada" : "Pendiente")}");
                }
            }
            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();  // Pausa antes de volver al menú
        }

        // Método para marcar una tarea como completada
        static void MarcarTareaCompletada(List<Tarea> tareas)
        {
            MostrarTareas(tareas);  // Muestra las tareas antes de seleccionar cuál marcar como completada
            Console.Write("Seleccione el número de la tarea que desea marcar como completada: ");
            int indice;

            // Validar el número ingresado por el usuario
            if (int.TryParse(Console.ReadLine(), out indice) && indice > 0 && indice <= tareas.Count)
            {
                // Marca la tarea seleccionada como completada
                tareas[indice - 1].Completada = true;
                Console.WriteLine("Tarea marcada como completada. Presione una tecla para continuar.");
            }
            else
            {
                // Mensaje si el número ingresado no es válido
                Console.WriteLine("Índice no válido. Presione una tecla para continuar.");
            }
            Console.ReadKey();  // Pausa antes de volver al menú
        }

        // Método para eliminar una tarea de la lista
        static void EliminarTarea(List<Tarea> tareas)
        {
            MostrarTareas(tareas);  // Muestra las tareas antes de seleccionar cuál eliminar
            Console.Write("Seleccione el número de la tarea que desea eliminar: ");
            int indice;

            // Validar el número ingresado por el usuario
            if (int.TryParse(Console.ReadLine(), out indice) && indice > 0 && indice <= tareas.Count)
            {
                // Elimina la tarea seleccionada
                tareas.RemoveAt(indice - 1);
                Console.WriteLine("Tarea eliminada. Presione una tecla para continuar.");
            }
            else
            {
                // Mensaje si el número ingresado no es válido
                Console.WriteLine("Índice no válido. Presione una tecla para continuar.");
            }
            Console.ReadKey();  // Pausa antes de volver al menú
        }
    }

    // Clase que representa una tarea con una descripción, una fecha límite opcional y un estado de completada
    class Tarea
    {
        public string Descripcion { get; set; }  // Descripción de la tarea
        public DateTime? FechaLimite { get; set; }  // Fecha límite opcional (nullable)
        public bool Completada { get; set; } = false;  // Estado de la tarea (false por defecto, no completada)
    }
}
