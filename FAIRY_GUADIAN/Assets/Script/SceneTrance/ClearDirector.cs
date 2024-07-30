using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClearDirector : MonoBehaviour
{
    ChangeColorRGBA5 ChangeColorRGBA5;
    private Image FadeImage;

    // Start is called before the first frame update
    void Start()
    {
        FadeImage = GetComponent<Image>();
        ChangeColorRGBA5 = GetComponent<ChangeColorRGBA5>();

        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Assert(ChangeColorRGBA5 != null);

        

        if (ChangeColorRGBA5 != null)
        {
            Debug.Log("“ü‚Á‚Ä‚¢‚é");

            if (Input.GetKeyDown(KeyCode.Space))
            {
                ChangeColorRGBA5.FadeoutOn();
                ChangeColorRGBA5.Update();
            }
        }


        


    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene("StageSelectScene");
    }
}
