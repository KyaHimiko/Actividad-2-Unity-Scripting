using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScale : MonoBehaviour
{
    [SerializeField]
    public Vector3 ejes;
    public float velocidad;
    // Update is called once per frame
    void Update()
    {
        ejes = CapsuleRotation.ClampVector3(ejes);
        transform.localScale += ejes * (velocidad * Time.deltaTime);
    }
}
