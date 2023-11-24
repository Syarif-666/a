using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOBJ : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Enable")
        {
            GameController.IsShow = true;
        }
    }
}
