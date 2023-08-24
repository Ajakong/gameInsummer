using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musukoMove : MonoBehaviour
{
    

    Vector3 move;
    Vector3 localScale;

    Vector3 reset;
    int timer;

    

    // Start is called before the first frame update
    void Start()
    {
        

        Debug.Log("aya");
        localScale = transform.localScale;
        reset= transform.localScale;
        timer = 0;
        move = new Vector3(0.05f, 0, 0);
    }

    private void Update()
    {
        if (timer <= 5)
        {
            localScale += move;
        }
        if(5<=timer&&timer<=10)
        {
            localScale -= move;
        }
        
        if(timer>10)
        {
            localScale = reset;
            timer = 0;
            this.gameObject.SetActive(false);
        }
        transform.localScale = localScale;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        timer++;
    }

   
}
