using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    // 1 declaración de variables
    public float MontoAConvertir;
    public string codigoMoneda;

    float cotizacionMoneda;

    float montoConvertido;

    // Start is called before the first frame update
    void Start()
    {
        // 2 ingreso y validación de los datos
        if (MontoAConvertir < 1000)
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }
        if (codigoMoneda == "D")
        {
            cotizacionMoneda = 1204.35f;
        } else if (codigoMoneda == "E")
        {
            cotizacionMoneda = 1541.11f;
        } else if (codigoMoneda == "R")
        {
            cotizacionMoneda = 201.24f;
        }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }
        // 3 procesamiento de los datos 

        montoConvertido = MontoAConvertir / cotizacionMoneda;

        // 4 salida de los datos

        Debug.Log("Monto convertido: " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
