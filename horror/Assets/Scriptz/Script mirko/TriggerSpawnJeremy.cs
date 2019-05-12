using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawnJeremy : MonoBehaviour
{
    public GameObject newJeremy;
    public GameObject thisTrigg;

    void OnTriggerEnter()
    {
        newJeremy.SetActive(true);
    }
    void OnTriggerExit()
    {
        thisTrigg.SetActive(false);
    }
}
