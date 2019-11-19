using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class CoroutineClass : MonoBehaviour
{
    public bool canRun = true;
    public IntData index;
    public float seconds = 1f;
    private WaitForSeconds _wfsObj;

    public void Run()
    {
        _wfsObj = new WaitForSeconds(seconds);
        StartCoroutine(OnRun());
    }

    IEnumerator OnRun()
    {
        while (index.value > 0)
        {
            Debug.Log(index.value);
            index.value--;
            yield return _wfsObj;

        }
    }
}    