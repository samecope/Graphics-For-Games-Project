using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLowerLight : MonoBehaviour
{
    public Transform lowerLightPosition;
    public float rotateSpeed;

    // Update is called once per frame
    private void Update()
    {
        transform.RotateAround(transform.parent.position, new Vector3(0, 1, 0), rotateSpeed * Time.deltaTime);

        transform.position = lowerLightPosition.position;
    }
}
