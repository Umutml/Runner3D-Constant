using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{

    public GameObject[] sections;
    public int zPos = 60;
    public bool creatingSection = false;
    public int secNum;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(sections[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 60;
        
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
