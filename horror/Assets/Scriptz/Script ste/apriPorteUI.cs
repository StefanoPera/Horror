using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class apriPorteUI : MonoBehaviour
{
    public float distance;
    public GameObject testo;
    public GameObject porta;
    public AudioSource suonoPorta;
    void Update()
    {
        distance = apriPorte.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (distance <= 1.5)
        {
            testo.SetActive(true);
        }
        if (Input.GetButtonDown("interact"))
        {
            if(distance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                testo.SetActive(false);
                porta.GetComponent<Animation>().Play("Door2_open");
                suonoPorta.Play();
            }
        }

    }

    void OnMouseExit()
    {
        testo.SetActive(false);
    }
}
