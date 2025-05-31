using UnityEngine;
using UnityEngine.UI;

public class Combo : MonoBehaviour
{
    public static Combo Instance;

    public int comboCount = 0;
    public Text comboText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Instance = this;
        UpdateComboUI();
    }
    public void OnHitBySaber()
    {
        comboCount++;
        UpdateComboUI();
    }

    public void OnMissedBox()
    {
        comboCount = 0;
        UpdateComboUI();
    }

    void UpdateComboUI()
    {
        comboText.text = "Combo \n" + comboCount;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
