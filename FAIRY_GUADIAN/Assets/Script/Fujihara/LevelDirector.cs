using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelDirector : MonoBehaviour
{
    public int level = 1;

    TextMeshProUGUI levelText;

    ExpBarScript Enhance;
    TextMeshProUGUI EnhanceText;

    // Start is called before the first frame update
    void Start()
    {
       levelText = GetComponent<TextMeshProUGUI>();
       Enhance = GameObject.Find("exp").GetComponent<ExpBarScript>();
       EnhanceText = GetComponent <TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // ƒŒƒxƒ‹‚ð•\Ž¦
        levelText.text = "Level:" + level + " " + "Enhance:" + Enhance.enhance;
    }
}
