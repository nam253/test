using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    private bool missed = false; //큐브가 화면을 벗어 났는지 추적
    GameObject player; //playerHPManager를 참조할 변수


    void Start()
    {
        player = GameObject.Find("PlayerHPManager"); //playermanager를 찾아 player에 할당
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 2;//2의 속도로 앞으로 움직여라

        if (!missed && Camera.main != null)//큐브를 놓치지 않았고 메인 카메라가 있을 경우
        {
            Vector3 toBox = transform.position - Camera.main.transform.position;//큐브의 위치에서 카메라의 위치를 빼기
            float dot = Vector3.Dot(Camera.main.transform.forward, toBox.normalized);
            //카메라의 앞 방향 벡터와 카메라에서 큐브로 향하는 벡터 간의 내적을 계산

            if (dot < -0.2f) // 계산된 내적 값이 -0.2보다 작을 경우 큐브가 카메라의 뒤쪽
            {
                missed = true;

                // �޺� �ʱ�ȭ
                if (Combo.Instance != null)
                {
                    Combo.Instance.OnMissedBox(); //combo 스크립트에서 onmissedbox를 호출
                    player.GetComponent<PlayerHpmanager>().Damage(10); //damage(10)함수를 호출

                }

                Destroy(gameObject); // 오브젝트를 파괴하여 메모리에서 삭제
            }
        }
    }
}
