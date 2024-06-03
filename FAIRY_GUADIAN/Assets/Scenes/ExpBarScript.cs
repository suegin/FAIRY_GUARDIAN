using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBarScript : MonoBehaviour
{
    // 最初の経験値上限
    int maxexp = 1000;
    int nowexp = 0;
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
        

        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            nowexp += 150;
        }

        // 経験値が上限を上回ったら
        if (nowexp >= maxexp)
        {
            nowexp = nowexp - maxexp;
            maxexp += 200;
            levelDirector.level += 1;
        }
    }
}
