using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    Vector3 target =new Vector3(0,0.15f,0);

    void Update()
    {
        //1. MoveTowards
        //transform.position = Vector3.MoveTowards(transform.position, target, 1f);//현재 위치, 목표지점, 속도

        //2. SmoothDamp -> 레퍼런스 속도를 이용하여 부드럽게 움직임 

        //Vector3 velo = Vector3.zero;// 참조 속도
        //Vector3 velo = Vector3.up * 50;

        //transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        //3. Lerp -> 보간
        //transform.position = Vector3.Lerp(transform.position, target, 0.05f);//smoothdamp와는 다르게 값이 적을 수록 느리게 움직임

        //4, SLerp -> 구면 선형 보간

        transform.position = Vector3.Slerp(transform.position, target, 0.05f);
    }
}
