using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleSpawner : MonoBehaviour
{

    ObjectPooler objectPooler;

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        objectPooler.SpawnFromPool("Capsule", transform.position, Quaternion.identity);
        // objectPooler.SpawnFromPool("Cube", transform.position, Quaternion.identity);
        
    }
}
