using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTriger : MonoBehaviour
{

    public float speedFactor = 2.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement> ().runSpeed *= speedFactor;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
