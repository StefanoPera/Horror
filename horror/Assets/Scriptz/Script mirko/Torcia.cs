using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torcia : MonoBehaviour
{
    public GameObject torcia;
    private bool accesa;
    void Start()
    {
        accesa = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            if (accesa == true)
            {
                torcia.SetActive(false);
                accesa = false;
            }


            else
            {
                Debug.Log("accesa come tua mamma");
                torcia.SetActive(true);
                accesa = true;
            }

        }
    }
}
