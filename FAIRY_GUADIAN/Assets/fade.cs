using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorRGBA : MonoBehaviour
{
    public float FadeTime = 0.5f;
    private float time;
    private SpriteRenderer render;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 255);
        render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time < FadeTime)
        {
            float alpha = 1.0f - time / FadeTime;
            Color color = render.color;
            color.a = alpha;
            render.color = color;
        }
    }
}
