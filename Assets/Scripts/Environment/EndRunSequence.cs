using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRunSequence : MonoBehaviour
{
    public GameObject defCoins;
    public GameObject defDis;

    public GameObject endScreen;
    public GameObject fadeOut;

    private void Start()
    {
        StartCoroutine(EndSequence());
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(3);
        defCoins.SetActive(false);
        defDis.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(1);
        fadeOut.SetActive(true);
    }



}
