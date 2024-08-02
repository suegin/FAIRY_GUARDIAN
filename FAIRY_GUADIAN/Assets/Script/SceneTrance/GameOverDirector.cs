using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverDirector : MonoBehaviour
{
    ChangeColorRGBA4 ChangeColorRGBA4;
    private Image FadeImage;
    private bool _isLoadGame = false;
    private bool _isLoadStage = false;
    AudioSource audioSource;
    public AudioClip keySound;
    bool keyLimit;
    void Start()
    {
        FadeImage = GetComponent<Image>();
        ChangeColorRGBA4 = GetComponent<ChangeColorRGBA4>();
        audioSource = this.GetComponent<AudioSource>();
        audioSource.clip = keySound;
        keyLimit = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return) & keyLimit)
        {
            keyLimit = false;
            audioSource.Play();
            ChangeColorRGBA4.FadeoutOn();
            ChangeColorRGBA4.Update();
            _isLoadGame = true;
        }
        if (Input.GetKeyUp(KeyCode.Space) & keyLimit)
        {
            keyLimit = false;
            audioSource.Play();
            ChangeColorRGBA4.FadeoutOn();
            ChangeColorRGBA4.Update();
            _isLoadStage = true;
        }
    }

    public void LoadNextScene()
    {
        if (_isLoadGame) 
        {
            _isLoadGame = false;
            SceneManager.LoadScene("GameScene");
        }
        else if (_isLoadStage)
        {
            _isLoadStage = false;
            SceneManager.LoadScene("StageSelectScene");
        }
    }
}
