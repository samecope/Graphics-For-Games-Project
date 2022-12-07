using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float xMovement;
    public float yMovement;
    public float zOffset;
    public Transform point;

    public float rotationSpeed;

    float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.unscaledDeltaTime * rotationSpeed;
        Rotate();
    }

    void Rotate()
    {
        float x = -Mathf.Cos(timer) * xMovement;
        float y = Mathf.Sin(timer) * yMovement;
        Vector3 pos = new Vector3(x, y, zOffset);
        transform.position = pos + point.position;
        transform.Rotate(0f, 10f * Time.unscaledDeltaTime, 20f * Time.unscaledDeltaTime, Space.Self);
    }
}
