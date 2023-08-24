using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    

    float speed;

    public int DDOLFlag; 

    public bool encountFlag;
    int encountCharge;

    public int areaNum;

    public string emptyObj;
    public string emptyObj2;

    Vector3 enPos = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        DDOLFlag = 0;
        DontDestroyOnLoad(this.gameObject);
        enPos = Vector3.zero;
        
        speed = 0.005f;
        encountFlag = false;
        encountCharge=0;
        areaNum = 1;

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(encountCharge);
        //移動
        Vector3 position = transform.position;
        
        if (encountCharge == 0)
        {
            
             position=enPos;
        }
        transform.position = enPos;
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
            

            var encount = Random.Range(0, 2);

            if (encount == 1)
            {
                encountCharge = 0;
                if (areaNum == 1)
                {
                    enPos = transform.position;
                    Debug.Log(enPos);
                    SceneManager.LoadScene("battle" + "Scene");
                }
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
