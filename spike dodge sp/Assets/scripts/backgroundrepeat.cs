using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundrepeat : MonoBehaviour
{
    // Start is called before the first frame update

    private float scrollspeed = 1f;
    Vector3 startPos;
   

    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((new Vector3(0,-1,0)) *scrollspeed*Time.deltaTime);

        
        if (transform.position.y < -9.98)
        {
            transform.position = startPos;
        }
        
    }
}
