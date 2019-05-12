using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGeremia : MonoBehaviour
{
    public AudioSource jump;
    public RuntimeAnimatorController anim;
    public GameObject geremia;
    public GameObject trigger;
    public GameObject porta;

    void OnTriggerEnter()
    {
        jump.Play();
        geremia.GetComponent<Enemy_Stalking>().enabled = true;
        geremia.GetComponent<Animator>().runtimeAnimatorController = anim;
        StartCoroutine(AddiosGeremia());
    }

    IEnumerator AddiosGeremia()
    {
        yield return new WaitForSeconds(2.0f);
        geremia.SetActive(false);
        porta.GetComponent<Animation>().Play("AnimApriPorta");
        trigger.SetActive(false);
    }
}
