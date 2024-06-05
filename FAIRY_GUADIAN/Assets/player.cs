using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{

    int _strength = 1;
    float AddSpeed = 1;
    Rigidbody2D rigid2D;
   
    // Start is called before the first frame update

    private void Update()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
       if(collision.gameObject.tag=="Enemy")
        {
            Debug.Log("1damage");
            float x = Input.GetAxisRaw("Horizontal"); // デフォルトが右向きの画像の場合
            Vector3 scale = transform.localScale; // スケール値取り出し
                                                  // ←が押された時
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-0.07f, 0, 0); // 左に1動かす
                scale.x = -1; // 反転する（左向き）

            }
            transform.localScale = scale; // 代入し直す

            // →が押された時
            if (Input.GetKey(KeyCode.RightArrow))
            {

                transform.Translate(0.07f, 0, 0); // 右に1動かす
                scale.x = 1; // そのまま（右向き）
            }
            transform.localScale = scale; // 代入し直す

            // ↑が押された時
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, 0.07f, 0); // 上に1動かす
            }

            // ↓が押された時
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, -0.07f, 0); // 下に1動かす
            }

            // Qが押された時
            if (Input.GetKeyDown(KeyCode.Q))
            {
                _strength += 5;     // 攻撃力が5上がる
                AddSpeed += 2f;      // 速度が5上がる
            }



        }
    }
}
