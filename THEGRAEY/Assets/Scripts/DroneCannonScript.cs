using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneCannonScript : MonoBehaviour
{
    public float cannonStrength;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Rigidbody cannonTarget = other.GetComponent<Rigidbody>();
            cannonTarget.velocity = direction * cannonStrength;
        }
    }
}
