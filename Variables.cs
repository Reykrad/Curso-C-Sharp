using UnityEngine;
using System.Collections;
using System;

public class Variables : MonoBehaviour 
{
	
	//TipoVariable NombreVariable = Valor;

	//Variable Publica
	public int x = 5;

	//Variable Privada
	private int y = 6;

	//Variable Publica Oculta
	[System.NonSerialized]
	public int z = 3;

	//Variable Global
	static int w = 2;


	//Tipos de Variables
	public string cadenaDeTexto = "Hola"; //cadena de texto
	public int numeroEntero = 10;
	public float numeroConDesimales = 5.32f;
	public bool tipoLogico = true;
	public int[] arregloDeEnteros;

	//Unity3D
	public GameObject gameObject; //Objetos dentro de la scena
	public Transform[] transform; //Transform de objetos (Rotar, Mover, Escalar)
	public Rigidbody rigi3D; //Manipulacion del RigidBody como (Masa, Drag, Angular Drag, Gravity, etc)
	public Rigidbody2D rigi2D; //Igual que el anterior pero con objetos 2D
	public Collision collision3D; //Valores activados cuando se detecta una colision
	public Collision2D collision2D; //Igual que la anterior pero en 2d
	public AudioClip audio; //Los valores de audio de un GameObject
	public AnimationClip animationClip; //Valores de animacion

}
