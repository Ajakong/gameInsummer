using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyState : MonoBehaviour
{

    int Hp;
    int PostHp;
    int furyGage;
    

    public bool modeFury;
    // Start is called before the first frame update
    void Start()
    {
        PostHp = 0;
        Hp = 200;
        furyGage = 0;
        modeFury = false;
    }

    // Update is called once per frame
    void Update()
    {
        PostHp = Hp;
        if(Hp==0)
        {

            //勝利演出
            SceneManager.LoadScene("world" + "Scene");
        }
        if(furyGage==200)
        {
            //モード移行
            modeFury = true;
        }
        Debug.Log(Hp);
        if(PostHp==Hp)
        {
            //攻撃受けた演出
        }
    }
    public int hpMove
    {
        get { return Hp; }
        set { Hp = value; }
    }
}
