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

    float cotizacionDolar = 1204.35f;
    float cotizacionEuro = 1541.11f;
    float cotizacionReal = 201.24f;

    float minimoAConvertir = 1000;

    // Start is called before the first frame update
    void Start()
    {
        // 2 ingreso y validación de los datos
        if (MontoAConvertir < minimoAConvertir)
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }
        if (codigoMoneda == "D")
        {
            cotizacionMoneda = cotizacionDolar;
        } else if (codigoMoneda == "E")
        {
            cotizacionMoneda = cotizacionEuro;
        } else if (codigoMoneda == "R")
        {
            cotizacionMoneda = cotizacionReal;
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
