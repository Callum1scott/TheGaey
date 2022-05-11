using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBreaker : MonoBehaviour
{
    public GameObject Laser;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void turnOff()
    {
        Laser.SetActive(false);
    }
}
