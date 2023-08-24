using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;


[RequireComponent(typeof(Animator))]
public class PlayerControl : MonoBehaviour
{

    GameObject musuko;



    //Animator anim;
    //[SerializeField] AudioSource Dush;

    public float Speed = 0;   // プレイヤー移動速度
    public float Jump = 0;   //ジャンプのパワー
    bool GravityFall;

    Rigidbody2D rbody;


    public bool JumpFlag = false;
    public bool GroundFlag = false;
    public bool TurnFlag = false;
    public bool flagAttack=true;

    private bool IsMoving = false;

    int attackTimer;

    void Start()
    {
        
        musuko = GameObject.Find("bakamusuko");
        musuko.SetActive(false);

        //anim = GetComponent<Animator>();
        //anim.SetBool("IsMoving", false);
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 3;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        GravityFall = false;
        attackTimer = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            JumpFlag = true;
        }
        if(GravityFall)
        {
            transform.Translate(0, 0, 0);
            GravityFall =false;

        }
        if(!GravityFall)
        {
            rbody.gravityScale = 5;
        }
        if (JumpFlag)
        {
            Jump = 3.0f;
            transform.Translate(0, Jump, 0);
            JumpFlag = false;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GravityFall = true;
        }

       
    }

    void FixedUpdate()
    {
        // 右矢印で右移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Speed += 0.5f;
            TurnFlag = false;


        }
        //左矢印で左移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Speed += -0.5f;
            TurnFlag = true;

        }
        if (this.gameObject.transform.position.x > 13f)
        {
            Speed -= 0.5f;
        }
        if (this.gameObject.transform.position.x < -13f)
        {
            Speed += 0.5f;
        }
        

        transform.Translate(Speed, 0, 0);
        if (Speed != 0)
        {
            //anim.SetBool("IsMoving", true);
        }
        else
        {
            Debug.Log("areyoufool");
            //anim.SetBool("IsMoving", false);
        }
        //this.GetComponent<SpriteRenderer>().flipX = TurnFlag;
        Speed = 0;

        //攻撃
        if (Input.GetKey(KeyCode.W) && flagAttack == true)
        {
            attackTimer = 0;

            Debug.Log("ayaya");
            musuko.SetActive(true);
        }

        if (attackTimer < 20)
        {
            flagAttack = false;
            Debug.Log("booya");
        }
        else
        {
            flagAttack = true;
            Debug.Log("fooo");
        }

        attackTimer++;
        
    }
}
