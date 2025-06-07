using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHpmanager : MonoBehaviour
{
    public int hp = 100; //체력 초기 값은 100

    public RawImage imgBar;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void Damage(int amount)
    {
        if (hp <= 0)
        {
            return; //다시 게임오버 씬으로 로드 되는 것을 막는다.
        }

        hp -= amount; //체력 감소
        imgBar.transform.localScale = new Vector3(hp / 100.0f, 1, 1); //이미지 스케일을 조절하여 체력바를 업데이트

        if (hp <= 0)
        {
            SceneManager.LoadScene("endingScene"); //체력이 0이라면 씬을 로드

           
        }
    }



    // Update is called once per frame
    void Update()
    {

    }

}
