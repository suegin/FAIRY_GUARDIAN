using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleDirector : MonoBehaviour
{
    ChangeColorRGBA ChangeColorRGBA;
    private Image FadeImage;
    AudioSource audioSource;
    public AudioClip keySound;
    bool keyLimit;
    
    // Start is called before the first frame update
    void Start()
    {
        FadeImage = GetComponent<Image>();
        ChangeColorRGBA = GetComponent<ChangeColorRGBA>();
        audioSource = this.GetComponent<AudioSource>();
        audioSource.clip = keySound;
        keyLimit = true;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyUp(KeyCode.Space) & keyLimit)
        {
            keyLimit = false;
            audioSource.Play();
            ChangeColorRGBA.FadeoutOn();
            ChangeColorRGBA.Update();
        }
        

        
    }
    public void LoadNextScene()
    {
            SceneManager.LoadScene("StageSelectScene");
    }
}
