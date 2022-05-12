using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clase8
{
    public class Program
    {
        // Consigna 1
        private static Arquero arquero = new Arquero();
        public class Jugador{
            string nombre;
            int numero;
            int habilidad;
            int velocidad;
            int x, y;    //ubicación

            public void PonerNombre(string nom)
            {
                this.nombre = nom;
            }
            public void PonerNumero(int num)
            {
                this.numero = num;
            }
            public void PonerHabilidad(int hab)
            {
                this.habilidad = hab;
            }
            public int ObtenerHabilidad()
            {
                return this.habilidad;
            }
            public int ObtenerVelocidad()
            {
                return this.velocidad;
            }
            public string ObtenerNombre()
            {
                return this.nombre;
            }
            public void Mover(int xax, int yax)
            {
                this.x = xax;
                this.y = yax;
            }
            public void Patear(int fuerza)
            {
                if (fuerza >= 1 && fuerza <= 3)
                    Console.WriteLine( "Disparo debil");
                else if (fuerza >= 4 && fuerza <= 8)
                    Console.WriteLine("Disparo medio");
                else
                    Console.WriteLine("Disparo potente");
            }
        }
        public class Arquero: Jugador
        {
            public void TomarConLasManos()
            {
                Console.WriteLine("El arquero toma el balon");
            }
        }

        // Consigna 2 2.1 (POINT incluye su uso en las clases de la consigna 2.3)
        public struct POINT
        {
            public int x, y;
        }
        public abstract class CSpaceShip
        {
            public POINT posicion;
            public uint velocidad;
            void Volar(int xax, int yax)
            {
                this.posicion.x = xax;
                this.posicion.y = yax;
            }
            void Disparar()
            {
                POINT pos = GetXYPos();
                Console.WriteLine("Disparo desde: " + pos.x + "," + pos.y);
            }
            void Acelerar()
            {
                // sin implementar
            }
            public POINT GetXYPos()
            {
                return posicion;
            }
            public bool GetColision(POINT puntoEval)
            {
                // sin implementar
                return true;
            }
        }

        // Consigna 2 2.2
        public class CHeroe : CSpaceShip
        {
            static string proyectil = "|";
            public CHeroe()
            {
                // Tiene una posicion X por defecto
                this.posicion.x = 0;
            }
            public virtual void Volar(int yax)
            {
                this.posicion.x = 0;
                this.posicion.y = yax;
            }
            public virtual void Disparar()
            {
                POINT pos = this.GetXYPos();
                Console.WriteLine("Disparo desde: " + pos.x + "," + pos.y + "proyectil: " + proyectil);
            }
        }

        public class CAlien: CSpaceShip
        {
            static string proyectil = "*";
            public virtual void Disparar()
            {
                POINT pos = this.GetXYPos();
                Console.WriteLine("Disparo desde: " + pos.x + "," + pos.y + "proyectil: " + proyectil);
            }
            public virtual void Acelerar(uint vel)
            {
                this.velocidad += vel;
            }
        }

        public static void Main(string[] args)
        {
            // Consigna 1 comienzo de programa
            Iniciar_Instancia_Arquero();
            // Muestra datos jugador (arquero)
            Mostrar_Datos_Arquero();
            // Evalua si agarra con la mano
            Evaluar_Agarrar_Balon();
            // Patea el balon
            Evaluar_Patear_Balon();
            // Pide tecla para continuar
            Console.ReadLine();
        }

        private static void Iniciar_Instancia_Arquero()
        {
            arquero.PonerNombre("Martin Valles");
            arquero.PonerNumero(1);
            arquero.PonerHabilidad(99);
        }
        private static void Mostrar_Datos_Arquero()
        {
            Console.WriteLine("Jugador: "+arquero.ObtenerNombre());
            Console.WriteLine("Velocidad actual: " + arquero.ObtenerVelocidad());
            Console.WriteLine("Habilidad: " + arquero.ObtenerHabilidad());
            Console.WriteLine();
        }
        private static void Evaluar_Agarrar_Balon()
        {
            string respuesta;
            Console.WriteLine("Arquero agarra el balon con la mano? (s/n)");
            Console.WriteLine();
            respuesta = Console.ReadLine();

            if(respuesta == "s" || respuesta == "S")
                arquero.TomarConLasManos();
        }
        private static void Evaluar_Patear_Balon()
        {
            int fuerza;
            Console.WriteLine("Indicar fuerza con la que se patea el balon: (1 a 10)");
            Console.WriteLine();
            fuerza = int.Parse(Console.ReadLine());

            arquero.Patear(fuerza);
        }
    }
}
