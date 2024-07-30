using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelectBGMScript : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip sound1;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        audioSource.clip = sound1;

        if (!TitleBGMScript.DontDestroyEnabled)
        {
            audioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
