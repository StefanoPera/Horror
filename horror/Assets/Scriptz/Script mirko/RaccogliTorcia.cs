using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Feat Ste
public class RaccogliTorcia : MonoBehaviour
{
    public GameObject torciaPlayer;
    public GameObject torcia;
    public GameObject testo;
    public float distance;

    void Update()
    {
        distance = apriPorte.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (distance <= 2.0)
        {
            testo.SetActive(true);
        }
        if (Input.GetButtonDown("interact"))
        {
            if (distance <= 2.5)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                testo.SetActive(false);
                torcia.SetActive(false);
                torciaPlayer.SetActive(true);
            }
        }

    }

    void OnMouseExit()
    {
        testo.SetActive(false);
    }
}
