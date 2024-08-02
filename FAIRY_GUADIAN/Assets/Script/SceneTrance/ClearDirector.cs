using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClearDirector : MonoBehaviour
{
    ChangeColorRGBA5 ChangeColorRGBA5;
    private Image FadeImage;
    AudioSource audioSource;
    public AudioClip keySound;
    bool keyLimit;

    // Start is called before the first frame update
    void Start()
    {
        FadeImage = GetComponent<Image>();
        ChangeColorRGBA5 = GetComponent<ChangeColorRGBA5>();
        audioSource = this.GetComponent<AudioSource>();
        audioSource.clip = keySound;
        keyLimit = true;
    }

    // Update is called once per frame
    void Update()
    {
        // null‰ñ”ð
        if (ChangeColorRGBA5 != null & Input.GetKeyDown(KeyCode.Space) & keyLimit)
        {
            keyLimit = false;
            audioSource.Play();
            ChangeColorRGBA5.FadeoutOn();
            ChangeColorRGBA5.Update();
        }
        
        
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene("StageSelectScene");
    }
}
