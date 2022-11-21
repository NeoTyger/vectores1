using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public List<GameObject> casellesPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        //caselles blanques
        Instantiate(casellesPrefabs[0], new Vector2(0, 0), Quaternion.identity);
        //caselles negres
        Instantiate(casellesPrefabs[1], new Vector2(2, 0), Quaternion.identity);

        for (int columna = 0; columna < 4; columna++)
        {
            for (int fila = 0; fila < 4; fila++)
            {
                Instantiate(casellesPrefabs[0], new Vector2(fila*4, 4*columna), Quaternion.identity);
                Instantiate(casellesPrefabs[1], new Vector2(2+fila*4, 4*columna), Quaternion.identity);
                Instantiate(casellesPrefabs[1], new Vector2(fila*4, 2+4*columna), Quaternion.identity);
                Instantiate(casellesPrefabs[0], new Vector2(2+fila*4, 2+4*columna), Quaternion.identity);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
