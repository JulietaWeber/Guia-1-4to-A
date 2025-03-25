using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int cantidadAlumnos;
    float magnitudTerremoto;
    string nombreAlumno;
    bool compuHabilitada;

    // Start is called before the first frame update
    void Start()
    {
        cantidadAlumnos = 24;
        magnitudTerremoto = 9.3f;
<<<<<<< HEAD
        nombreAlumno = "Julieta";
=======
        nombreAlumno = "Jeronimo";
>>>>>>> c93d6cba8d1f533f280c41f2a0b483c25e88a314
        compuHabilitada = false;

        Debug.Log(cantidadAlumnos);
        Debug.Log(magnitudTerremoto);
        Debug.Log(nombreAlumno);
        Debug.Log(compuHabilitada);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
