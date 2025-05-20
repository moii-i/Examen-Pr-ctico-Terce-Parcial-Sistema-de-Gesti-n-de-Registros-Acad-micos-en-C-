// Programa principal para el Examen del Tercer Parcial
// Proyecto: Sistema de Gestión de Registros Académicos

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SistemaAcademico
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public double Promedio { get; set; }

        public override string ToString()
        {
            return $"Matrícula: {Matricula}, Nombre: {Nombre}, Promedio: {Promedio:F2}";
        }
    }

    class NodoBST
    {
        public Estudiante Estudiante;
        public NodoBST Izquierdo;
        public NodoBST Derecho;

        public NodoBST(Estudiante estudiante)
        {
            Estudiante = estudiante;
        }
    }

    class ArbolBinarioBusqueda
    {
        public NodoBST Raiz;

        public void Insertar(Estudiante estudiante)
        {
            Raiz = Insertar(Raiz, estudiante);
        }

        private NodoBST Insertar(NodoBST nodo, Estudiante estudiante)
        {
            if (nodo == null) return new NodoBST(estudiante);

            int comparacion = string.Compare(estudiante.Matricula, nodo.Estudiante.Matricula);
            if (comparacion < 0)
                nodo.Izquierdo = Insertar(nodo.Izquierdo, estudiante);
            else
                nodo.Derecho = Insertar(nodo.Derecho, estudiante);

            return nodo;
        }

        public Estudiante Buscar(string matricula)
        {
            NodoBST actual = Raiz;
            while (actual != null)
            {
                int comparacion = string.Compare(matricula, actual.Estudiante.Matricula);
                if (comparacion == 0) return actual.Estudiante;
                else if (comparacion < 0) actual = actual.Izquierdo;
                else actual = actual.Derecho;
            }
            return null;
        }
    }

    class SistemaAcademico
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        ArbolBinarioBusqueda bst = new ArbolBinarioBusqueda();

        public void AgregarEstudiante()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Matrícula: ");
            string matricula = Console.ReadLine();
            Console.Write("Promedio: ");
            double promedio = double.Parse(Console.ReadLine());

            var estudiante = new Estudiante { Nombre = nombre, Matricula = matricula, Promedio = promedio };
            estudiantes.Add(estudiante);
            bst.Insertar(estudiante);
        }

        public void MostrarEstudiantes()
        {
            Console.WriteLine("\nLista de Estudiantes:");
            foreach (var e in estudiantes)
                Console.WriteLine(e);
        }

        public void BuscarPorMatricula()
        {
            Console.Write("Ingrese matrícula: ");
            string mat = Console.ReadLine();
            var resultado = bst.Buscar(mat);
            if (resultado != null) Console.WriteLine("\nEncontrado:\n" + resultado);
            else Console.WriteLine("Estudiante no encontrado.");
        }

        public void OrdenarPorNombre()
        {
            Stopwatch sw = Stopwatch.StartNew();
            Quicksort(estudiantes, 0, estudiantes.Count - 1);
            sw.Stop();
            Console.WriteLine($"\nRegistros ordenados por nombre en {sw.ElapsedMilliseconds} ms");
        }

        void Quicksort(List<Estudiante> lista, int izquierda, int derecha)
        {
            if (izquierda >= derecha) return;

            int i = izquierda, j = derecha;
            var pivote = lista[(izquierda + derecha) / 2].Nombre;

            while (i <= j)
            {
                while (string.Compare(lista[i].Nombre, pivote) < 0) i++;
                while (string.Compare(lista[j].Nombre, pivote) > 0) j--;
                if (i <= j)
                {
                    var temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                    i++; j--;
                }
            }

            if (izquierda < j) Quicksort(lista, izquierda, j);
            if (i < derecha) Quicksort(lista, i, derecha);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SistemaAcademico sistema = new SistemaAcademico();

            while (true)
            {
                Console.WriteLine("\n--- Sistema de Gestión Académica ---");
                Console.WriteLine("1. Agregar Estudiante");
                Console.WriteLine("2. Mostrar Estudiantes");
                Console.WriteLine("3. Buscar por Matrícula");
                Console.WriteLine("4. Ordenar por Nombre (Quicksort)");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1": sistema.AgregarEstudiante(); break;
                    case "2": sistema.MostrarEstudiantes(); break;
                    case "3": sistema.BuscarPorMatricula(); break;
                    case "4": sistema.OrdenarPorNombre(); break;
                    case "0": return;
                    default: Console.WriteLine("Opción no válida."); break;
                }
            }
        }
    }
}
