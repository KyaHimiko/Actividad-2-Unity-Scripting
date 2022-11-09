using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    [SerializeField]
    private Vector3 direction;
    public float speed;

    void Update()
    {
        direction = ClampVector3(direction);
        transform.Translate(direction * (speed * Time.deltaTime));
    }

    public static Vector3 ClampVector3(Vector3 target)
    {
        float clampedX = Mathf.Clamp(target.x, -1f, 1f);
        float clampedY = Mathf.Clamp(target.y, -1f, 1f);
        float clampedZ = Mathf.Clamp(target.z, -1f, 1f);

        Vector3 result = new Vector3(clampedX, clampedY, clampedZ);

        return result;
    }
}