using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //�ʱ�ȭ
    private void Awake()//������Ʈ ���� �� ���� ����(1����)
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    private void OnEnable()//������Ʈ Ȱ��ȭ �� ���� ����
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�");
    }
    private void Start() // ������Ʈ ���� ���� ����
    {
        Debug.Log("��� ��� ì����ϴ�");
    }
    //������ ���� ������Ʈ
    private void FixedUpdate()//���� ���� ������Ʈ
    {
        Debug.Log("�̵�->");
    }

    private void Update()// ���� ������Ʈ
    {
        Debug.Log("���� ���");
    }

    private void LateUpdate()//��� ������Ʈ ���� ��
    {
        Debug.Log("����ġ ȹ��");
    }

    private void OnDisable()//��Ȱ��ȭ �ø��� ����(������ ����)
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�");
    }

    private void OnDestroy()//������Ʈ�� ������ ��
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�");
    }
    
}
