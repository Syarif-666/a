using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject desbox;
    public static bool IsShow = false;

    // Update is called once per frame
    void Update()
    {
        if(IsShow)
        {
            desbox.SetActive(true);
        }
    }
}
