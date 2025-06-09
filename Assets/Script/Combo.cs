using UnityEngine;
using UnityEngine.UI;

public class Combo : MonoBehaviour
{
    public static Combo Instance; 

    public int comboCount = 0; //���� �޺��� ����
    public Text comboText; //�޺� ���� ������ �ؽ�Ʈ

    public static int score = 0; //������ ����
    public static int bestscore = 0; //�ְ� ������ ����

    public Text scoretext; //������ ������ �ؽ�Ʈ

    void Start()
    {
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Instance = this;
        UpdateComboUI(); //���� ���۽� ui�� �ʱ�ȭ
    }
    public void OnHitBySaber()
    {
        comboCount++; //�޺� �� ����
        score += 10; //������ 10 ����
        
        UpdateComboUI(); //ui�� ������Ʈ
    }

    public void OnMissedBox()
    {
        comboCount = 0; //�޺��� 0���� �ʱ�ȭ
        UpdateComboUI(); //ui�� ������Ʈ
    }

    void UpdateComboUI()
    {
        comboText.text = "Combo \n" + comboCount; //�޺��� �޺� ���ڸ� ǥ��
    }
    
    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Score : " + score; //wjatnfmf djqepdlxm
    }
}
