using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    private bool missed = false;
    GameObject player;


    void Start()
    {
        player = GameObject.Find("PlayerHPManager");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 2;

        if (!missed && Camera.main != null)
        {
            Vector3 toBox = transform.position - Camera.main.transform.position;
            float dot = Vector3.Dot(Camera.main.transform.forward, toBox.normalized);

            if (dot < -0.2f) // ī�޶� ����
            {
                missed = true;

                // �޺� �ʱ�ȭ
                if (Combo.Instance != null)
                {
                    Combo.Instance.OnMissedBox();
                    player.GetComponent<PlayerHpmanager>().Damage(10);

                }

                Destroy(gameObject); // �ڽ� ����
            }
        }
    }
}
