using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorRGBA2 : MonoBehaviour
{
    StageSelectDirector StageSelectDirector;
    public float FadeSpeed = 0.75f;
    private float time = 0;
    private float alpha = 0;
    //private SpriteRenderer render;
    private Image FadeImage;
    public bool _isFadein = false;  // boolをONにする
    public bool _isFadeout = false; // boolをONにする
    // Start is called before the first frame update
    void Start()
    {
        FadeImage = GetComponent<Image>();
        alpha = FadeImage.color.a;
        StageSelectDirector = GetComponent<StageSelectDirector>();
        FadeImage.color = new Color(0, 0, 0, 0);
        FadeinOn();
    }

    // Update is called once per frame
    public void Update()
    {

        // _isFadeinがtrueにしたら
        if (_isFadein)
        {
            time += Time.deltaTime;
            alpha = 1.0f - time / FadeSpeed;
            FadeImage.color = new Color(0, 0, 0, alpha);
            if (alpha < 0)
            {
                FadeImage.enabled = false;
                _isFadein = false;
            }
        }

        if (_isFadeout)
        {
            time += Time.deltaTime;
            alpha = time / FadeSpeed;
            FadeImage.color = new Color(0, 0, 0, alpha);
            if (alpha > 1)
            {
                //FadeImage.enabled = false;
                _isFadeout = false;
                StageSelectDirector.LoadNextScene();
            }
        }
    }

    public void FadeoutOn()
    {
        FadeImage.enabled = true;
        time = 0;
        _isFadeout = true;

    }
    public void FadeinOn()
    {
        FadeImage.enabled = true;
        time = 0;
        _isFadein = true;
    }
}
