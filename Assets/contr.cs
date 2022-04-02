using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contr : MonoBehaviour
{
    string contraok = "123";
    string contra;
    public Text ingresocontra;
    public GameObject Cartel;
    public Text tmensaje;
    // Start is called before the first frame update
    void Start()
    {
        Cartel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void contrasenia()
    {

        contra = ingresocontra.text;

        if(contra == contraok)
        {
            Debug.Log("Bienvenido");
            tmensaje.text = "bienvenido";
            Cartel.SetActive(true);
        }
        else
        {
            Debug.Log("Incorecto");
            tmensaje.text = "incorecto";
           Cartel.SetActive(true);
        }
    }
}
