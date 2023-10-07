using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    Vector3 target =new Vector3(0,0.15f,0);

    void Update()
    {
        //1. MoveTowards
        //transform.position = Vector3.MoveTowards(transform.position, target, 1f);//���� ��ġ, ��ǥ����, �ӵ�

        //2. SmoothDamp -> ���۷��� �ӵ��� �̿��Ͽ� �ε巴�� ������ 

        //Vector3 velo = Vector3.zero;// ���� �ӵ�
        //Vector3 velo = Vector3.up * 50;

        //transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        //3. Lerp -> ����
        //transform.position = Vector3.Lerp(transform.position, target, 0.05f);//smoothdamp�ʹ� �ٸ��� ���� ���� ���� ������ ������

        //4, SLerp -> ���� ���� ����

        transform.position = Vector3.Slerp(transform.position, target, 0.05f);
    }
}
