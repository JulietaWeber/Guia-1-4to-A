using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientacion : MonoBehaviour
{
    public string nombreAlumno;
    public int añoAlumno;
    public string orientacionAlumno;

    string tic = "T";
    string diseño = "D";
    string gestion = "G";
    string medios = "M";
    string humanidades = "H";

    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == "")
        {
            Debug.Log("Error. No se ha ingresado ningún caracter");
        }
        else if (añoAlumno < 1 || añoAlumno > 5)
        {
            Debug.Log("Error. El año ingresado no está dentro del rango");
        }
        // orientacion == t || 
        // orientacion != t &&
        else if (orientacionAlumno != "T" && orientacionAlumno != "D" && orientacionAlumno != "G" && orientacionAlumno != "M" && orientacionAlumno != "H")
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");   
        }
        else if (añoAlumno < 3)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
        }
        else
        {
            Debug.Log("Muchas gracias " + nombreAlumno);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
