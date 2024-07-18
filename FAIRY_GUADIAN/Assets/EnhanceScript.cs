using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnhanceScript : MonoBehaviour
{
    //PlayerController pAttack;

    PlayerController pSpeed;

    //ExpBarScript enhance;

    //Testenemy eSpeed;
    Enemy1 eSpeed1;
    //Enemy1 eSpeed1Clone;
    //Enemy2 eSpeed2;
    //Enemy2 eSpeed2Clone;
    Enemy3 eSpeed3;
    //Enemy3 eSpeed3Clone;
    Enemy4 eSpeed4;
    //Enemy4 eSpeed4Clone;

    //float attackTemp;
    float speedTemp;
    float speedTemp2;

    // Start is called before the first frame update
    void Start()
    {
        //pAttack = GameObject.Find("player").GetComponent<PlayerController>();

        pSpeed = GameObject.Find("player").GetComponent<PlayerController>();

        // enhance = GameObject.Find("exp").GetComponent<ExpBarScript>();

        eSpeed1 = GameObject.Find("Enemy1").GetComponent<Enemy1>();
        //eSpeed1Clone = GameObject.Find("Enemy1(Clone)").GetComponent<Enemy1>();
        //eSpeed2 = GameObject.Find("Enemy2").GetComponent<Enemy2>();
        //eSpeed2Clone = GameObject.Find("Enemy2(Clone)").GetComponent<Enemy2>();
        eSpeed3 = GameObject.Find("Enemy3").GetComponent<Enemy3>();
        //eSpeed3Clone = GameObject.Find("Enemy3(Clone)").GetComponent<Enemy3>();
        eSpeed4 = GameObject.Find("Enemy4").GetComponent<Enemy4>();
        //eSpeed4Clone = GameObject.Find("Enemy4(Clone)").GetComponent<Enemy4>();

        speedTemp = pSpeed.speed;
        speedTemp2 = pSpeed.AddSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // 左シフトが押されてる間
        if(Input.GetKey(KeyCode.LeftShift))
        {
            // 敵の動きが止まる
            eSpeed1.speed = 0.0f;
            //eSpeed1Clone.speed = 0.0f;
            //eSpeed2.speed = 0.0f;
            //eSpeed2Clone.speed = 0.0f;
            eSpeed3.speed = 0.0f;
            //eSpeed3Clone.speed = 0.0f;
            eSpeed4.speed = 0.0f;
            //eSpeed4Clone.speed = 0.0f;
            // 強化画面を表示
            transform.position = new Vector3(0, 0, 0);
            //// プレイヤーの攻撃力を0にする
            //attackTemp = pAttack.strength;
            //pAttack.strength *= 0.0f;
            // プレイヤーの動きを止める
            pSpeed.speed = 0.0f;
            pSpeed.AddSpeed = 0.0f;
        }

        // 左シフトが離されたら
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            // 強化画面を閉じる
            transform.position = new Vector3(0, 30, 0);
            // 敵の動きを再開する
            eSpeed1.speed += 0.005f;
            //eSpeed1Clone.speed += 0.005f;
            //eSpeed2Clone.speed += 0.005f;
            //eSpeed2Clone.speed += 0.005f;
            eSpeed3.speed += 0.005f;
            //eSpeed3Clone.speed += 0.005f;
            eSpeed4.speed += 0.005f;
            //eSpeed4Clone.speed += 0.005f;
            //// プレイヤーの攻撃力を元に戻す
            //pAttack.strength = attackTemp;
            // プレイヤーの動きを再開する
            pSpeed.speed = speedTemp;
            pSpeed.AddSpeed = speedTemp2;
        }
    }
}
