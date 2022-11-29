using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;
    
 

    private void OnTriggerEnter(Collider other)
    {
        CollactableControl.coinCount += 1;
        coinFX.Play();
        gameObject.SetActive(false);
        Destroy(gameObject, 1f);
    }
}
