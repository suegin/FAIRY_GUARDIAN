using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnhanceScript : MonoBehaviour
{
    PlayerController pAttack;

    PlayerController pSpeed;

    ExpBarScript Enhance;

    BarrierDirector Hp;

    Enemy1 eSpeed1;
    Enemy2 eSpeed2;
    Enemy3 eSpeed3;
    Enemy4 eSpeed4;

    float attackTemp;
    float speedTemp;
    float speedTemp2;

    public bool shot;

    public bool spawn;

    public bool barrierDamage;

    // Start is called before the first frame update
    void Start()
    {
        pAttack = GameObject.Find("player").GetComponent<PlayerController>();

        pSpeed = GameObject.Find("player").GetComponent<PlayerController>();

        Enhance = GameObject.Find("exp").GetComponent<ExpBarScript>();

        Hp = GameObject.Find("barrier").GetComponent<BarrierDirector>();

        eSpeed1 = GameObject.Find("Enemy1").GetComponent<Enemy1>();
        eSpeed2 = GameObject.Find("Enemy2").GetComponent<Enemy2>();
        eSpeed3 = GameObject.Find("Enemy3").GetComponent<Enemy3>();
        eSpeed4 = GameObject.Find("Enemy4").GetComponent<Enemy4>();

        attackTemp = pAttack.strength;
        speedTemp = pSpeed.speed;
        speedTemp2 = pSpeed.AddSpeed;

        shot = true;

        spawn = true;

        barrierDamage = true;
    }

    // Update is called once per frame
    void Update()
    {
        // 左シフトが押されてる間
        if(Input.GetKey(KeyCode.LeftShift))
        {
            // 敵の動きが止まる
            eSpeed1.speed = 0.0f;
            eSpeed2.speed = 0.0f;
            eSpeed3.speed = 0.0f;
            eSpeed4.speed = 0.0f;
            // 強化画面を表示
            transform.position = new Vector3(0, 0, 0);
            // プレイヤーの攻撃力を0にする
            pAttack.strength *= 0.0f;
            // プレイヤーの動きを止める
            pSpeed.speed = 0.0f;
            pSpeed.AddSpeed = 0.0f;
            
            shot = false;

            spawn = false;

            barrierDamage = false;

            // Aが押されたら
            if (Input.GetKeyDown(KeyCode.A) && Enhance.enhance > 0)
            {
                // 攻撃力を0.5上げる
                attackTemp += 0.5f;
                Enhance.enhance -= 1;
            }

            // Sが押されたら
            if (Input.GetKeyDown(KeyCode.S) && Enhance.enhance > 0)
            {
                // バリアの耐久値を3回復
                Hp.barrierHp += 3;
                Enhance.enhance -= 1;
            }

            // Dが押されたら
            if (Input.GetKeyDown(KeyCode.D) && Enhance.enhance > 0)
            {
                // スピードを上げる
                speedTemp += 0.002f;
                speedTemp2 += 0.12f;
                Enhance.enhance -= 1;
            }
        }

        // 左シフトが離されたら
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            // 強化画面を閉じる
            transform.position = new Vector3(0, 30, 0);
            // 敵の動きを再開する
            eSpeed1.speed += 0.005f;
            eSpeed2.speed += 0.005f;
            eSpeed3.speed += 0.005f;
            eSpeed4.speed += 0.005f;
            // プレイヤーの攻撃力を元に戻す
            pAttack.strength = attackTemp;
            // プレイヤーの動きを再開する
            pSpeed.speed = speedTemp;
            pSpeed.AddSpeed = speedTemp2;

            shot = true;

            spawn = true;

            barrierDamage = true;

            Debug.Log(Hp.barrierHp);
        }
    }
}
