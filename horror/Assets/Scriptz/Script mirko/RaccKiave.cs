using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//feat Ste
public class RaccKiave : MonoBehaviour
{
    public GameObject Kiave;
    public GameObject Geremia;
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
                Geremia.SetActive(true);
                Kiave.SetActive(false);
            }
        }

    }

    void OnMouseExit()
    {
        testo.SetActive(false);
    }
}
