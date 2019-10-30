using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prova : MonoBehaviour
{
    public GameObject geremia;

    // Update is called once per frame
    void OnTriggerExit()
    {
        GameObject spawnPoint = GameObject.Find("SpawnPointProva");
        geremia.transform.position = spawnPoint.transform.position;
    }
}
