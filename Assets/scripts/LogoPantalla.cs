using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoPantalla : MonoBehaviour
{

	//Estas variables representan las diferentes pantallas
	[Header("Pantallas")]
	public GameObject Pantalla1Logo;
	public GameObject Pantalla2Inicio;
	public GameObject Pantalla3Fondos;
	public GameObject Pantalla4Personajes;
	public GameObject Pantalla5Camara;
	public GameObject Pantalla6Timer;
	public GameObject Pantalla7Ayuda;
	public GameObject Pantalla8Descarga;
	
	//Variable que representa el boton contuniar del logo
	[Header("Boton logo")]
	public Button LogoBoton; 
	
	// Start is called before the first frame update
	void Start()
	{
		LogoBoton.onClick.AddListener(()=>CargarPantalla(Pantalla2Inicio));
		CargarPantalla(Pantalla1Logo);
	}

	// Update is called once per frame
	void Update()
	{
        
	}
    
	//Con esta funcion apaga/enciende las pantallas para la navegacion
	void CargarPantalla(GameObject estado)
	{
		Pantalla1Logo.SetActive(false);
		Pantalla2Inicio.SetActive(false);
		Pantalla3Fondos.SetActive(false);
		Pantalla4Personajes.SetActive(false);
		Pantalla5Camara.SetActive(false);
		Pantalla6Timer.SetActive(false);
		Pantalla1Logo.SetActive(false);
		Pantalla7Ayuda.SetActive(false);
		Pantalla8Descarga.SetActive(false);

		estado.SetActive(true);

	}
}