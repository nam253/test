using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHpmanager : MonoBehaviour
{
    public int hp = 100;

    public RawImage imgBar;

    public static Text currentScoreText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentScoreText.text = "Score : " + Combo.score;
    }

    public void Damage(int amount)
    {
        if (hp <= 0)
        {
            return;
        }

        hp -= amount;
        imgBar.transform.localScale = new Vector3(hp / 100.0f, 1, 1);

        if (hp <= 0)
        {
            SceneManager.LoadScene("endingScene");

           
        }
    }



    // Update is called once per frame
    void Update()
    {

    }

}
