using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBarScript : MonoBehaviour
{
    // �ŏ��̌o���l���
    int maxexp = 1000;
    int nowexp = 0;
    public Slider expBar;
    // Start is called before the first frame update
    void Start()
    {
        expBar = GetComponent<Slider>();
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

        // �o���l���������������
        if (nowexp >= maxexp)
        {
            nowexp = nowexp - maxexp;
            maxexp += 200;
        }
    }
}
