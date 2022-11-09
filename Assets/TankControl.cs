using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControl : MonoBehaviour
{
    [SerializeField]
    public float velocidad;
    public float velocidadangular;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Rotate(Vector3.up * (-velocidadangular * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.D)) 
        {
            transform.Rotate(Vector3.up * (velocidadangular * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.W)) 
        {
            transform.Translate(Vector3.forward * (velocidad * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.S)) 
        {
            transform.Translate(Vector3.back * (velocidad * Time.deltaTime));
        }
    }
}
