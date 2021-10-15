using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with object with tag " + other.tag);
        if(other.CompareTag("Basketball"))
        {
            Debug.Log("Now we should spawn a cube or something");
            this.transform.position = transform.position + new Vector3(10, 10, 0);
        }
    }
}
