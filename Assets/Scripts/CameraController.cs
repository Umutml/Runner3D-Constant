using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject playerGO;
    public Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    private void LateUpdate()
    {
        transform.position = playerGO.transform.position + offset;
    }
}
