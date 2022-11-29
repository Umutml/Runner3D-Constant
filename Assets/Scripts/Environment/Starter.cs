using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{

    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGO;

    public GameObject fadeIn;

    public AudioSource readyFX;
    public AudioSource goFX;
    
   
    void Start()
    {
        StartCoroutine(CountSequence());
        
    }

    IEnumerator CountSequence()
    {
        fadeIn.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        readyFX.Play();
        countDown3.SetActive(true);
        yield return new WaitForSeconds(1f);
        readyFX.Play();
        countDown2.SetActive(true);
        yield return new WaitForSeconds(1f);
        readyFX.Play();
        countDown1.SetActive(true);
        yield return new WaitForSeconds(1f);
        goFX.Play();
        countDownGO.SetActive(true);
        PlayerController.canMove = true;
        

    }
    
}
