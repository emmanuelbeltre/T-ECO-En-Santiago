using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class SeleccionPersonajes : MonoBehaviour{
	
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
	//Estas variables representan cada botón de selección de personajes
	
	[Header("Botones/Selección")]	
	public Button botonPersonaje1;
	public Button botonPersonaje2;
	public Button botonPersonaje3;
	public Button botonPersonaje4;
	public Button botonPersonaje5;
	public Button botonPersonaje6;
	public Button botonAtrasPersonajes;
	public Button botonRestarurarPersonajes;
	public Button botonContinuarPersonajes;
	
   
	//Estas variables representan los videos de cada personaje que se puede elejir.
	[Header("Personajes")]
	public GameObject PerspnajeVideo1;
	public GameObject PerspnajeVideo2;
	public GameObject PerspnajeVideo3;
	public GameObject PerspnajeVideo4;
	public GameObject PerspnajeVideo5;
	public GameObject PerspnajeVideo6;
	
	
	
	[Header ("Variables extras")]
	public int	 conteo;
	public Text mensajeAlerta;
	public GameObject[] Personas;

    void Start()
    {
	    conteo = 0;
	    botonContinuarPersonajes.GetComponent<Button>().interactable = false;
	    botonPersonaje1.onClick.AddListener(()=> MostrarPersonajePantalla(PerspnajeVideo1));
	    botonPersonaje2.onClick.AddListener(()=> MostrarPersonajePantalla(PerspnajeVideo2));
	    botonPersonaje3.onClick.AddListener(()=> MostrarPersonajePantalla(PerspnajeVideo3));
	    botonPersonaje4.onClick.AddListener(()=> MostrarPersonajePantalla(PerspnajeVideo4));
	    botonPersonaje5.onClick.AddListener(()=> MostrarPersonajePantalla(PerspnajeVideo5));
	    botonPersonaje6.onClick.AddListener(()=> MostrarPersonajePantalla(PerspnajeVideo6));

		
	    //sizeArreglo.onClick.AddListener(()=> SizeDelArreglo(Personas, "Persona"));
	    //sizeArreglo.onClick.AddListener(()=> MostrarAlerta());
    }

    void Update()
    {
        
    }
    
    
	//Con esta función podremos mostrar y ocultar cada uno de los personaje con solo presionando su botón correspondiente
	void MostrarPersonajePantalla(GameObject personaje){

		if (personaje.activeSelf)
		{
			personaje.SetActive(false);
			conteo = conteo-1; 
			Debug.Log(conteo);
		}else{
			conteo = conteo+1;
			//Con esta condición al al tener 4 personajes seleccionados no se nos permetirá seleccionar un quinto personaje.
			if(conteo>4){
				MostrarAlerta();
				conteo = conteo-1;
				Debug.Log(conteo);
				
				return ;
			}
			
			personaje.SetActive(true);
			Debug.Log(conteo);
		}
		
		//Con Esta condicion se habilita/deshabilita el boton de contunuar en la seleccion de personajes	
		if (conteo != 4)
		{
			botonContinuarPersonajes.GetComponent<Button>().interactable = false;
		}
		else{botonContinuarPersonajes.GetComponent<Button>().interactable = true;}
	
		
	}
	//Esta función ejecuta mi IEnumerator, que basicamente implementa dos métodos
	void MostrarAlerta()=>StartCoroutine(MiContador());

	//Este método me permite mostrar el mensaje en pantalla durante solo 3 segundos y luego sustituir el texto por una cadena vacía
	IEnumerator MiContador()
	{
		mensajeAlerta.text = "Solo Debe Seleccionar 4 personajes, intente deseleccionar uno de los ya seleccionado";
		yield return new WaitForSeconds(3);
		mensajeAlerta.text = "";
	 
	}
	
	void SizeDelArreglo(GameObject[] miArr, string miTag){
		miArr = GameObject.FindGameObjectsWithTag(miTag);
		
		
		for(int i =0; i <= miArr.Length-1 ; i++){
			Debug.Log("El objeto "+  i + " tiene el nombre" + miArr[i].name);
		}
	}
	
	//Con esta funcion apaga/enciende las pantallas para la navegacion
	void CargarPantalla(GameObject estado)
	{
		//p_inico.SetActive(false);
		//p_cuentas.SetActive(false);
		//p_trasacciones.SetActive(false);

		//estado.SetActive(true);

	}
	
}
