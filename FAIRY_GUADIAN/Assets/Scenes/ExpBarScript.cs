using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBarScript : MonoBehaviour
{
    // 最初の必要経験値
    int maxexp = 1000;
    // 現在の経験値量
    public int nowexp = 0;

    LevelDirector levelDirector;
    public Slider expBar;
    public GameObject level;
    // Start is called before the first frame update
    void Start()
    {
        expBar = GetComponent<Slider>();
        levelDirector = level.GetComponent<LevelDirector>();  
    }

    // Update is called once per frame
    void Update()
    {
        expBar.value = nowexp;
        expBar.maxValue = maxexp;
        
        //// 経験値獲得条件
        //if (Input.GetKeyDown(KeyCode.Space)) 
        //{ 
        //    // 経験値を獲得
        //    nowexp += 150;
        //}

        // 必要経験値量手に入れたら
        if (nowexp >= maxexp)
        {
            // 経験値超過分を適用する
            nowexp = nowexp - maxexp;
            // 必要経験値を上げる
            maxexp += 200;
            // レベルが1上がる
            levelDirector.level += 1;
        }
    }
}
