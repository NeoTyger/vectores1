using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlfilMovement : MonoBehaviour
{
    
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)&&(transform.position.x < 14))
        {
            transform.position = new Vector3(transform.position.x + 2, transform.position.y, 0);
            
        }if (Input.GetKeyDown(KeyCode.LeftArrow)&&(transform.position.x > 0))
        {
            transform.position = new Vector3(transform.position.x -2, transform.position.y, 0);
            
        }if (Input.GetKeyDown(KeyCode.UpArrow)&&(transform.position.y < 14))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 2, 0);
            
        }if (Input.GetKeyDown(KeyCode.DownArrow)&&(transform.position.y > 0))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 2, 0);
        }
    }
}
