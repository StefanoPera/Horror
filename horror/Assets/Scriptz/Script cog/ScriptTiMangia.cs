using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTiMangia : MonoBehaviour
{
    public GameObject trigger;
    public GameObject geremia;
    public RuntimeAnimatorController run;
    void OnTriggerEnter()
    {
        geremia.GetComponent<Animator>().runtimeAnimatorController = run;
        geremia.GetComponent<Enemy_Stalking>().enabled = true;
        geremia.GetComponent<ScriptTiRaggiunge>().enabled = true;

    }

    void OnTriggerExit()
    {
        trigger.SetActive(false);
    }
}
