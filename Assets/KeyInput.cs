using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)//키를 누름
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        //키보드 입력
        /* 
        if (Input.anyKey)//키를 누르고 있음
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");
        if (Input.GetKeyDown(KeyCode.Return))//Return키 입력을 받았을 때 True
            Debug.Log("아이템을 구입하였습니다.");
        if (Input.GetKeyDown(KeyCode.LeftArrow))//왼쪽 방향키 입력
            Debug.Log("왼쪽으로 이동 중");
        if (Input.GetKeyUp(KeyCode.RightArrow))//오른쪽 방향키 입력을 떼었을 때 True
            Debug.Log("오른쪽으로 이동을 멈췄습니다.");
        */
        //마우스 입력
        /*
        if (Input.GetMouseButtonDown(0))//0은 좌클릭, 1은 우클릭
            Debug.Log("미사일 발사");
        if (Input.GetMouseButton(0))
            Debug.Log("미사일 충전 중...");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사");
        */
        //버튼을 이용해서 입력 받기
        if (Input.GetButtonDown("Fire1"))//버튼의 이름은 문자열 형식.
            Debug.Log("점프");
        if (Input.GetButton("Fire1"))
            Debug.Log("점프를 모으는 중...");
        if (Input.GetButtonUp("Fire1"))
            Debug.Log("슈퍼 점프");
        if (Input.GetButtonDown("SuperFire"))
            Debug.Log("필살기");

        //축 입력
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중... " + Input.GetAxis("Horizontal"));//축의 수치 출력
            //Debug.Log("횡 이동 중... " + Input.GetAxisRaw("Horizontal"));//축의 가중치 없는 수치 출력(가속도 출력)
        }

        if (Input.GetButton("Vertical"))
            Debug.Log("종 이동 중... " + Input.GetAxis("Vertical"));
    }
}
