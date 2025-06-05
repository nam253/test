using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public Text bestScoreText;

    void Start()
    {
        if (Combo.score > Combo.bestscore)
        {
            Combo.bestscore = Combo.score;
        }

        bestScoreText.text = "Best : " + Combo.bestscore.ToString();
    }

    public void gamerestart()
    {
        Combo.score = 0;
        SceneManager.LoadScene("selectScene");
    }

    public void gamequit()
    {
        Application.Quit();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        
    }
}
