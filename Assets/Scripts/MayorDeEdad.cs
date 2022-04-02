using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayorDeEdad : MonoBehaviour
{
    public int IngresoTexto;
    public Text textoCartelito;
    // Start is called before the first frame update
    void Start()
    {
        if (IngresoTexto >= 18)
        {

            textoCartelito.text = "Sos mayor de edad";
            Debug.Log("Sos mayor de edad");

        }
        else
        {

            textoCartelito.text = "Sos menor de edad";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
