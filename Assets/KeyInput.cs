using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)//Ű�� ����
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
        //Ű���� �Է�
        /* 
        if (Input.anyKey)//Ű�� ������ ����
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");
        if (Input.GetKeyDown(KeyCode.Return))//ReturnŰ �Է��� �޾��� �� True
            Debug.Log("�������� �����Ͽ����ϴ�.");
        if (Input.GetKeyDown(KeyCode.LeftArrow))//���� ����Ű �Է�
            Debug.Log("�������� �̵� ��");
        if (Input.GetKeyUp(KeyCode.RightArrow))//������ ����Ű �Է��� ������ �� True
            Debug.Log("���������� �̵��� ������ϴ�.");
        */
        //���콺 �Է�
        /*
        if (Input.GetMouseButtonDown(0))//0�� ��Ŭ��, 1�� ��Ŭ��
            Debug.Log("�̻��� �߻�");
        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� ���� ��...");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�");
        */
        //��ư�� �̿��ؼ� �Է� �ޱ�
        if (Input.GetButtonDown("Fire1"))//��ư�� �̸��� ���ڿ� ����.
            Debug.Log("����");
        if (Input.GetButton("Fire1"))
            Debug.Log("������ ������ ��...");
        if (Input.GetButtonUp("Fire1"))
            Debug.Log("���� ����");
        if (Input.GetButtonDown("SuperFire"))
            Debug.Log("�ʻ��");

        //�� �Է�
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��... " + Input.GetAxis("Horizontal"));//���� ��ġ ���
            //Debug.Log("Ⱦ �̵� ��... " + Input.GetAxisRaw("Horizontal"));//���� ����ġ ���� ��ġ ���(���ӵ� ���)
        }

        if (Input.GetButton("Vertical"))
            Debug.Log("�� �̵� ��... " + Input.GetAxis("Vertical"));
    }
}
