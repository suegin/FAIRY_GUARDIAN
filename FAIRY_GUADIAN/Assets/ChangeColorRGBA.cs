using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorRGBA : MonoBehaviour
{
    public float FadeSpeed = 0.75f;
    private float time = 0;
    private float alpha = 0;
    //private SpriteRenderer render;
    private Image FadeImage;
    public bool _isFadein = false;  // bool‚ðON‚É‚·‚é
    public bool _isFadeout = false; // bool‚ðON‚É‚·‚é
    // Start is called before the first frame update
    void Start()
    {

        //GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 255);
        //render = GetComponent<SpriteRenderer>();
        FadeImage = GetComponent<Image>();
        alpha = FadeImage.color.a;
        
    }

    // Update is called once per frame
    void Update()
    {
        // _isFadein‚ªtrue‚É‚µ‚½‚ç
        if (_isFadein)
        {
            time += Time.deltaTime;
            alpha = 1.0f - time / FadeSpeed;
            FadeImage.color = new Color(0, 0, 0, alpha);
            if (alpha < 0)
            {
                FadeImage.enabled = false;
                _isFadein = false ;
            }
        }

        if (_isFadeout) 
        {
            time += Time.deltaTime;
            alpha = time / FadeSpeed;
            FadeImage.color = new Color(0, 0, 0, alpha);
            if (alpha > 1)
            {
                FadeImage.enabled = false;
                _isFadein = false;
            }
        }
        
        /*time += Time.deltaTime;
        alpha += FadeSpeed * Time.deltaTime;
        FadeImage.color = new Color(0, 0, 0, alpha);
        if (alpha > 1) 
        {
            FadeImage.enabled = false;
        }*/
        /*time += Time.deltaTime;
        if (time < FadeTime)
        {
            float alpha = 1.0f - time / FadeTime;
            Color color = render.color;
            color.a = alpha;
            render.color = color;
        }*/

    }
    public void FadeoutOn()
    {
        _isFadeout = true;
    }

}
