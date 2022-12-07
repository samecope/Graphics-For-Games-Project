using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionForce : MonoBehaviour
{
    public GameObject ExplosionFX;
    public GameObject VolcanoTop;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ExplosionFX.gameObject.SetActive(true);
            VolcanoTop.gameObject.SetActive(false);
            GetComponent<Rigidbody>().AddExplosionForce(1500, new Vector3(645, 220, 888), 200);
        }
    }
}
