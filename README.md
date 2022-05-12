# TecAvPro-clase8
TecAvPro-clase8

1) Definir una clase para un video juego de fútbol que identifique a un jugador, sin importar la posición en el campo de juego. Como mínimo debe poseer los atributos:

string nombre;
int numero;
int habilidad;  
int velocidad;
int x, y;    //ubicación

Y las funciones miembros:

ObtenerHabilidad(), ObtenerVelocidad() y ObtenerNombre() .
Mover():  que recibe dos parámetros enteros que especifican el desplazamiento para x y el desplazamiento para y.
Patear(): recibe un parámetro entero, (número entre 1 y 10), que indica con que fuerza patea el balón. Si la fuerza está entre 1 y 3 mostrar mensaje  “Disparo debil”, si está entre 4 y 8 mostrar “Disparo medio” y si es 9 ó 10 “Disparo potente”.

Derivar de esta clase otra que particularmente identifique a un arquero y que herede todos los datos y funciones miembros agregando la función TomarConLasManos() que simplemente mostrará el mensaje: “El arquero toma el balón”.

El programa deberá crear un instancia de la clase arquero y ejemplificar todos los métodos del objeto.

2) Una empresa de software que se dedica al desarrollo de videos juegos tiene la intención de sacar al mercado una nueva versión del tan famoso juego “mata marcianos”, “GALAGA que implementará las últimas características gráficas 3D en un sistema enteramente orientado a objetos.
Para esto se pide:

2.1)	Definir una clase abstracta que represente una nave espacial, (podría llamarse CSpaceShip). Y que implemente funciones como Volar(), Disparar(), GetXYPos() y Acelerar().

- Volar(): recibe dos enteros que representan el desplazamiento de la nave en pantalla.
- Disparar(): Imprime en pantalla un caracter en la posición donde se encuentra la nave.
- GetXYPos(): Devuelve un puntero a una estructura POINT, que indica la posición xy en pantalla.
- GetColisión(): Devuelve  1 o 0 en caso que exista una colisión con otra nave y se le pasa una variable de tipo POINT.
(algunas funciones pueden ser virtuales).

2.2)	Derivar de CSpaceShip dos nuevas clases CHeroe y CAlien. Las dos clases implementan de igual forma la funciones GetColision() y GetXYPos(). 
Para la implementación de las otras funciones tenga en cuenta lo siguiente:

- Las naves marcianas vuelan en todas direcciones. Y el héroe siempre vuela hacia los lados, (eje y siempre igual al valor por defecto).
- Sólo los Aliens aceleran, para esto se le pasa un valor entero entre -5 y 5 a la función miembro Acelerar() la cual decrementa o incrementa el dato miembro velocidad.
- Tanto los aliens como el héroe efectúan disparos. El disparo de los marcianos es un ‘*’ y el del héroe ‘|’.

2.3) Escribir un programa que ejemplifique el uso de las clases.

Ejemplo de estructura POINT:
	
public  struct POINT
{
  int x;
  int y;
};
