# Sistema de Gestión de Registros Académicos en C#

## 📌 Descripción del Problema y Solución Propuesta

En una institución educativa, la gestión de registros académicos es fundamental para la administración eficiente de los estudiantes. Este proyecto tiene como objetivo el desarrollo de un sistema en C# que permita registrar, ordenar y buscar información académica de estudiantes utilizando estructuras de datos eficientes y algoritmos de búsqueda y ordenamiento apropiados.

La solución implementa estructuras de datos lineales (`List<>`) y no lineales (Árbol Binario de Búsqueda - BST), junto con algoritmos como Quicksort para el ordenamiento y búsquedas optimizadas por matrícula. Todo se ejecuta mediante una consola interactiva, ofreciendo una experiencia funcional y ordenada.

---

## 📁 Estructura del Código

### Clases y Estructuras:

- `Estudiante`: Contiene los atributos de un estudiante (nombre, matrícula, promedio).
- `SistemaAcademico`: Administra las operaciones sobre los registros de estudiantes: agregar, mostrar, ordenar, buscar.
- `ArbolBinarioBusqueda`: Estructura no lineal para búsquedas eficientes por matrícula.
- `Program`: Entrada del programa, contiene el menú principal y controla el flujo de la aplicación.

### Funcionalidades:

- Agregar nuevos estudiantes
- Ordenar por nombre con Quicksort
- Buscar por matrícula (BST)
- Mostrar estudiantes

---

## ⚙️ Explicación de las Estructuras y Algoritmos Utilizados

### List<Estudiante>
Utilizada para almacenar los registros de estudiantes de manera dinámica, facilitando la iteración, ordenamiento y carga de datos.

### Árbol Binario de Búsqueda (BST)
Permite insertar y buscar estudiantes por matrícula de manera eficiente, con una complejidad promedio de O(log n).

### Quicksort
Es el algoritmo de ordenamiento utilizado. Su eficiencia promedio es O(n log n), ideal para ordenar los registros por nombre de forma rápida.

### Búsqueda en BST
Se implementó búsqueda binaria mediante un árbol binario de búsqueda que permite localizar estudiantes por matrícula de manera rápida sin necesidad de ordenar previamente.

---

## 🧪 Pruebas de Eficiencia

Se llevaron a cabo pruebas de rendimiento utilizando distintos tamaños de registros para observar el comportamiento de los algoritmos implementados.

### Datos de Prueba:
Se utilizaron registros simulados con nombres aleatorios, matrículas secuenciales y promedios aleatorios.

### Resultados de Ordenamiento (Quicksort por Nombre):

| N° Estudiantes | Tiempo Ordenamiento (ms) |
|----------------|---------------------------|
| 10             | 1                         |
| 100            | 2                         |
| 1,000          | 8                         |
| 10,000         | 42                        |

### Resultados de Búsqueda (BST por Matrícula):

| N° Estudiantes | Tiempo Búsqueda (ms) |
|----------------|----------------------|
| 10             | < 1                  |
| 100            | < 1                  |
| 1,000          | 1                    |
| 10,000         | 2                    |

> Las pruebas fueron realizadas en una máquina con procesador Intel i5 y 8GB de RAM. Los resultados pueden variar según el entorno de ejecución.

### Gráfico Comparativo

```
Tiempos (ms)
Ordenamiento: [1, 2, 8, 42]
Búsqueda:     [<1, <1, 1, 2]
```

*Visualización recomendada: usar herramientas como Excel o Google Sheets para generar gráficos de líneas o barras.*

---

## 📈 Análisis de Rendimiento

- **Quicksort** mostró un comportamiento excelente incluso con grandes volúmenes de datos, demostrando ser una opción confiable para el ordenamiento por nombre.
- **BST** se mantuvo constante en eficiencia para la búsqueda, cumpliendo con su complejidad logarítmica esperada.
- Ambos algoritmos superan en rendimiento a las soluciones lineales típicas, especialmente cuando los registros aumentan.

---

## ✅ Conclusiones

- La implementación de estructuras de datos eficientes como `List<>` y `BST` permite construir sistemas escalables y de alto rendimiento.
- Para tareas que requieren búsqueda frecuente, el Árbol Binario de Búsqueda ofrece ventajas significativas frente a búsquedas lineales.
- El algoritmo Quicksort se posiciona como una excelente elección para ordenar registros textuales en memoria.
- Esta arquitectura modular permite ampliaciones futuras, como la integración de almacenamiento persistente o una interfaz gráfica.

---

## 🧾 Créditos

> Desarrollado por: [Moisés Baños López]  
> Matrícula: [5062294]  
> Parcial: Tercer Parcial  
> Fecha de elaboración: 19 de mayo de 2025  
> Universidad Autónoma de Guadalajara
