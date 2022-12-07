using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBottomLight : MonoBehaviour
{
    public Transform bottomLightPosition;
    public float rotateSpeed;


    // Update is called once per frame
    private void Update()
    {
        transform.RotateAround(transform.parent.position, new Vector3(0, 1, 0), rotateSpeed * Time.deltaTime);

        transform.position = bottomLightPosition.position;
    }
}
