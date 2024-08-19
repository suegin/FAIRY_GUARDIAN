using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnhanceScript : MonoBehaviour
{
    PlayerController pAttack;

    PlayerController pSpeed;

    ExpBarScript Enhance;

    BarrierDirector Hp;

    float attackTemp;
    float speedTemp;
    float speedTemp2;

    public bool shot;

    public bool spawn;

    public bool barrierDamage;

    AudioSource audioSource;
    public AudioClip enhanceSound;

    // Start is called before the first frame update
    void Start()
    {
        pAttack = GameObject.Find("player").GetComponent<PlayerController>();

        pSpeed = GameObject.Find("player").GetComponent<PlayerController>();

        Enhance = GameObject.Find("exp").GetComponent<ExpBarScript>();

        Hp = GameObject.Find("barrier").GetComponent<BarrierDirector>();

        audioSource = this.GetComponent<AudioSource>();
        audioSource.clip = enhanceSound;

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
        if (Input.GetKey(KeyCode.LeftShift))
        {
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

                audioSource.Play();
            }

            // Sが押されたら
            if (Input.GetKeyDown(KeyCode.S) && Enhance.enhance > 0)
            {
                // バリアの耐久値を3回復
                BarrierDirector.barrierHp += 3;
                Enhance.enhance -= 1;

                audioSource.Play();
            }

            // Dが押されたら
            if (Input.GetKeyDown(KeyCode.D) && Enhance.enhance > 0)
            {
                // スピードを上げる
                speedTemp += 0.002f;
                speedTemp2 += 0.12f;
                Enhance.enhance -= 1;

                audioSource.Play();
            }
        }

        // 左シフトが離されたら
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            // 強化画面を閉じる
            transform.position = new Vector3(0, 30, 0);

            // プレイヤーの攻撃力を元に戻す
            pAttack.strength = attackTemp;
            // プレイヤーの動きを再開する
            pSpeed.speed = speedTemp;
            pSpeed.AddSpeed = speedTemp2;

            shot = true;

            spawn = true;

            barrierDamage = true;
        }
    }
}
