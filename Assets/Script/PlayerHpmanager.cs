using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHpmanager : MonoBehaviour
{
    public int hp = 100; //ü�� �ʱ� ���� 100

    public RawImage imgBar;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void Damage(int amount)
    {
        if (hp <= 0)
        {
            return; //�ٽ� ���ӿ��� ������ �ε� �Ǵ� ���� ���´�.
        }

        hp -= amount; //ü�� ����
        imgBar.transform.localScale = new Vector3(hp / 100.0f, 1, 1); //�̹��� �������� �����Ͽ� ü�¹ٸ� ������Ʈ

        if (hp <= 0)
        {
            SceneManager.LoadScene("endingScene"); //ü���� 0�̶�� ���� �ε�

           
        }
    }



    // Update is called once per frame
    void Update()
    {

    }

}
