using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBarScript : MonoBehaviour
{
    // �ŏ��̕K�v�o���l
    int maxexp = 1000;
    // ���݂̌o���l��
    public int nowexp = 0;

    // �v���C���[�̋����ɕK�v�Ƃ���l
    public int enhance = 0;

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
    public void Update()
    {
        expBar.value = nowexp;
        expBar.maxValue = maxexp;

        // �K�v�o���l�ʎ�ɓ��ꂽ��
        if (nowexp >= maxexp)
        {
            // �o���l���ߕ���K�p����
            nowexp = nowexp - maxexp;
            // �K�v�o���l���グ��
            maxexp += 200;
            // ���x����1�オ��
            levelDirector.level += 1;
            // ��������̂ɕK�v�Ȓl��1������
            enhance += 1;
        }
    }
}
