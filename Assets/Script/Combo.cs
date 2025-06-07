using UnityEngine;
using UnityEngine.UI;

public class Combo : MonoBehaviour
{
    public static Combo Instance; 

    public int comboCount = 0; //현재 콤보를 저장
    public Text comboText; //콤보 수를 저장할 텍스트

    public static int score = 0; //점수를 저장
    public static int bestscore = 0; //최고 점수를 저장

    public Text scoretext; //점수를 저장할 텍스트

    void Start()
    {
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Instance = this;
        UpdateComboUI(); //게임 시작시 ui를 초기화
    }
    public void OnHitBySaber()
    {
        comboCount++; //콤보 수 증가
        score += 10; //점수를 10 증가
        
        UpdateComboUI(); //ui를 업데이트
    }

    public void OnMissedBox()
    {
        comboCount = 0; //콤보를 0으로 초기화
        UpdateComboUI(); //ui를 업데이트
    }

    void UpdateComboUI()
    {
        comboText.text = "Combo \n" + comboCount; //콤보와 콤보 숫자를 표시
    }
    
    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Score : " + score; //wjatnfmf djqepdlxm
    }
}
