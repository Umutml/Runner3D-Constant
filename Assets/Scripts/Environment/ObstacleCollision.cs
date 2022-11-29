using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject Player;
    public GameObject characterModel;
    public AudioSource crashThud;
    public GameObject mainCam;

    private LevelDistance levelControldis;
    private EndRunSequence endRunSequence;

    // Update is called once per frame
    private void Start()
    {
        levelControldis = GameObject.Find("LevelControl").GetComponent<LevelDistance>();
        endRunSequence = GameObject.Find("LevelControl").GetComponent<EndRunSequence>();
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        Player.GetComponent<PlayerController>().enabled = false;
        characterModel.GetComponent<Animator>().SetBool("Backwards", true);
        crashThud.Play();
       // mainCam.GetComponent<Animator>().enabled = true;
        levelControldis.enabled = false;
        endRunSequence.enabled = true;
    }
}
