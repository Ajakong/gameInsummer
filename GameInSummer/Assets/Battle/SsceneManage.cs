using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SsceneManage : MonoBehaviour
{
    GameObject player;

    Vector3 pos = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("player");
        Debug.Log("“®‚¢‚Ä‚é‚æ");
        pos = player.transform.position;

        pos = new Vector3(500, 500, 0);
        player.transform.position = pos;
    }
}
