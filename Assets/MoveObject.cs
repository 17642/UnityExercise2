using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Transform tr;//������Ʈ�� �⺻������ Transform�� ������ �����Ƿ� �ʱ�ȭ�� �ʿ� ����
        //������Ʈ�� �⺻������ ������ Transform ������ transform��.

        int number = 4;//��Į��
        //Vector3 vec = new Vector3(5, 5, 5);//���� ��

        //transform.Translate(vec);
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 vec = new Vector3(0, 0.1f, 0);//���� ��
        //transform.Translate(vec);

        Vector3 vec = new Vector3(//Ű���� �Է��� ���� ������Ʈ �̵�
            Input.GetAxis("Horizontal")*Time.deltaTime,
            Input.GetAxis("Vertical")*Time.deltaTime, 0);
        transform.Translate(vec);
    }
}
