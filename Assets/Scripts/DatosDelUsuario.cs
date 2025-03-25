using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombreUsuario;
    [SerializeField] int edadUsiario;
    [SerializeField] float estaturaUsiario;
    [SerializeField] bool esDonante;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombreUsuario);
        Debug.Log("Tengo " + edadUsiario + " años.");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
