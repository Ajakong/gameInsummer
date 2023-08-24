using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    
    float speed;

    public bool encountFlag;
    int encountCharge;

    public int areaNum;

    public string emptyObj;
    public string emptyObj2;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        
        speed = 0.005f;
        encountFlag = false;
        encountCharge=0;
        areaNum = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //移動
        Vector3 position = transform.position;

        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            speed = 0.0025f;
            encountCharge++;
        }
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            speed = 0.0025f;
            encountCharge++;
        }
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            speed = 0.0025f;
            encountCharge++;
        }
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            speed = 0.0025f;
            encountCharge++;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            position.y += speed;
            //position.z += speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            position.y -= speed;
            //position.z -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= speed;
        }


        transform.position = position;
        speed = 0.005f;



        //エンカウント処理

        if (encountCharge > 50)
        {
            encountCharge = 0;


            if (areaNum == 1)
            {
                var encount = Random.Range(0, 2);

                if (encount == 1) SceneManager.LoadScene("battle" + "Scene");
            }
        }

        //マップ移動
        if(transform.position.y > 9)
        {
            areaNum = 2;
                   }
        if (transform.position.y > 50)
        {
            areaNum = 3;
           
        }

    }
        
            
        
    
            
    

    
}
