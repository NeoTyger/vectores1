using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CatanGenerator : MonoBehaviour
{

    public List<GameObject> casellesCatan;

    private float radi = 2.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(casellesCatan[0], new Vector2(0, 0), Quaternion.identity);

        /*for (int angle = 0; angle < 360; angle = 60)
        {
            Instantiate(casellesPrefabs[1], new Vector2(radi*Math.Cos()), Quaternion.identity);
        }*/
        
        Instantiate(casellesCatan[1], new Vector2(radi, 0), Quaternion.identity);
        Instantiate(casellesCatan[2], new Vector2(radi*2, radi*Math.Cos(30.0f)), Quaternion.identity);
        Instantiate(casellesCatan[3], new Vector2(-radi, 0), Quaternion.identity);
        Instantiate(casellesCatan[4], new Vector2(-radi*2, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
