using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleRotation : MonoBehaviour
{
    [SerializeField]
    public float velocidad;
    public Vector3 ejes;



    // Update is called once per frame
    void Update()
    {
        ejes = ClampVector3(ejes);
        transform.Rotate(ejes * (velocidad * Time.deltaTime));
    }

    public static Vector3 ClampVector3(Vector3 target)
    {
        float ClampedX = Mathf.Clamp(target.x, -1f, 1f);
        float ClampedY = Mathf.Clamp(target.y, -1f, 1f);
        float ClampedZ = Mathf.Clamp(target.z, -1f, 1f);

        Vector3 result = new Vector3(ClampedX, ClampedY, ClampedZ);

        return result;
    }

}
