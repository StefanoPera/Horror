using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class CamFix : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        StartCoroutine(Fix());
    }

    IEnumerator Fix()
    {
        yield return new WaitForSeconds(6.0f);
        player.GetComponent<FirstPersonController>().enabled = true;
        player.GetComponent<Animator>().enabled = false;
    }

}
