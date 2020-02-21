using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeUncouple : MonoBehaviour
{
    public GameObject ThePlayer;

    void OnTriggerEnter()
    {
        ThePlayer.transform.parent = null;
    }
}
