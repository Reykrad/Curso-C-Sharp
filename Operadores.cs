using UnityEngine;
using System.Collections;

public class Operadores : MonoBehaviour 
{
/*
	//Operadores aritmeticos
	+ //suma
	- //resta
	* //multiplicacion
	/ //division
	% //modulo o residuo
	++ //+1 incremento
	-- //-1 decremento

	//Operadores de asignacion
	= //Asignacion de valor
	+= //val1 = val1 + val2  >> (val1 += val2)
	-= //val1 = val1 - val2  >> (val1 -= val2)
	*= //val1 = val1 * val2  >> (val1 *= val2)
	/= //val1 = val1 / val2  >> (val1 /= val2)
	%= //val1 = val1 % val2  >> (val1 %= val2)
*/
	public float x = 4.0f;
	public float y = 3.2f;
	public float z;

	void Start()
	{
		//Operadores aritmeticos
		z = x + y; //z = 7.2
		z = x - y; //z = 0.8
		z = x * y; //z = 12.8
		z = x / y; //z = 1.25
		z = x % y; //z = 0.8 >> 0.8 es un residuo de la division entre 4 y 3.2
		z++; //z = 1 >> le aumenta 1
		z--; //z = -1 >> le quita 1

		//Operadores de asignacion
		x = y; // x = 3.2
		x += y; // x = 7.2
		x -= y; // x = 0.8
		x *= y; // x = 12.8
		x /= y; // x = 1.25
		x %= y; // x = 0.8
	}


}
