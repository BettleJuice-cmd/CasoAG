# Sistema Integral de Estructuras de Datos: Gestión de Redes y Catálogo 

Este proyecto implementa dos estructuras de datos fundamentales (**Árbol Binario** y **Grafo Ponderado**) mediante una aplicación de escritorio desarrollada en C# (Windows Forms). El objetivo es resolver problemas de optimización de rutas y gestión de inventario/catálogo.

## 1. Módulo de Grafos (Optimización de Rutas)

Este módulo gestiona la red de caminos de un parque temático para optimizar los recorridos.

### Algoritmos Implementados

| Algoritmo | Propósito | Clase de Lógica |
| :--- | :--- | :--- |
| **Dijkstra** | Encuentra la **ruta más corta** entre dos edificios (nodos), minimizando la distancia total (el peso de las aristas). 
| **BFS** (Breadth-First Search) | Implementado en la función de conexidad para verificar si todos los edificios del parque son accesibles entre sí. 

### Funcionalidades de la Interfaz

* **Gestión de Edificios y Distancias:** Permite al usuario agregar dinámicamente nodos (edificios) y aristas ponderadas (distancias en metros).
* **Cálculo de Ruta:** Muestra la secuencia de la ruta óptima y la distancia total calculada por Dijkstra.
* **Validación de Conexidad:** Alerta al usuario si existen zonas o edificios aislados, garantizando la integridad de la red.

---

## 2. Módulo de Árboles (Gestión de Catálogo)

Este módulo utiliza un **Árbol Binario de Búsqueda (ABB)** para organizar y acceder eficientemente a un catálogo de datos.

### Implementación del Árbol Binario

* **Estructura:** Árbol Binario de Búsqueda (ABB).
* **Búsqueda Eficiente:** Permite buscar y acceder a elementos del catálogo rápidamente.
* **Recorridos:** Implementación de las principales técnicas de recorrido de árboles para la visualización y depuración de datos:
    * **Preorden:** Muestra los datos para copiar o duplicar la estructura (raíz -> izquierdo -> derecho).
    * **Postorden:** Muestra los datos listos para eliminar el árbol o evaluar expresiones (izquierdo -> derecho -> raíz).

---

## 3. Tecnologías y Estructuras de Datos

| Componente | Detalle |
| :--- | :--- |
| **Lenguaje** | C\# (.NET Framework/Core) |
| **Interfaz** | Windows Forms (WinForms) |
| **Grafo** | **Diccionario Anidado** (`Dictionary<string, Dictionary<string, int>>`) para representar el Grafo Ponderado. |
| **Árbol** | **Clase Nodo** que apunta a hijos `izquierdo` y `derecho` para construir el Árbol Binario de Búsqueda. |

---

## 4. Guía Rápida de Uso

1.  **Carga e Inicialización:** Abrir la solución (`.sln`) en Visual Studio y ejecutar (**F5**).
2.  **Uso del Módulo Grafo:**
    * Ir a la pestaña de Grafos.
    * Agregar edificios y establecer distancias.
    * Seleccionar Origen/Destino y presionar **"ENCONTRAR RUTA"**.
3.  **Uso del Módulo Árbol:**
    * Ir a la pestaña de Árboles.
    * Insertar elementos del catálogo.
    * Presionar los botones para visualizar los resultados de los recorridos (**Preorden, Postorden**).
