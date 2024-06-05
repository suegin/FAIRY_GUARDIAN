using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    int _strength = 1;
    float AddSpeed = 1;
    Rigidbody2D rigid2D;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); // デフォルトが右向きの画像の場合
        Vector3 scale = transform.localScale; // スケール値取り出し
        // ←が押された時
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.07f * AddSpeed, 0, 0); // 左に1動かす
            scale.x = -1; // 反転する（左向き）

        }
        transform.localScale = scale; // 代入し直す

        // →が押された時
        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            transform.Translate(0.07f * AddSpeed, 0, 0); // 右に1動かす
            scale.x = 1; // そのまま（右向き）
        }
        transform.localScale = scale; // 代入し直す

        // ↑が押された時
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0.07f * AddSpeed, 0); // 上に1動かす
        }

        // ↓が押された時
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -0.07f * AddSpeed, 0); // 下に1動かす
        }

        // Qが押された時
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _strength += 5;     // 攻撃力が5上がる
            AddSpeed += 1.2f;      // 速度が1.2上がる
        }

        // Wが押された時
        if(Input.GetKeyDown(KeyCode.W)) 
        { 
                                                //  半径3.5の円形の攻撃範囲
              

        }

    }
   
}



