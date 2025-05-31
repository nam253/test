using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cube : MonoBehaviour
{
    private bool missed = false;

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 2;

        if (!missed && Camera.main != null)
        {
            Vector3 toBox = transform.position - Camera.main.transform.position;
            float dot = Vector3.Dot(Camera.main.transform.forward, toBox.normalized);

            if (dot < -0.2f) // 카메라 뒤쪽
            {
                missed = true;

                // 콤보 초기화
                if (Combo.Instance != null)
                {
                    Combo.Instance.OnMissedBox();
                }

                Destroy(gameObject); // 박스 제거
            }
        }
    }
}
