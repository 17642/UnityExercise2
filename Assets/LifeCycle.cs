using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //초기화
    private void Awake()//오브젝트 생성 시 최초 실행(1번만)
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    private void OnEnable()//오브젝트 활성화 시 마다 실행
    {
        Debug.Log("플레이어가 로그인했습니다");
    }
    private void Start() // 업데이트 직전 최초 실행
    {
        Debug.Log("사냥 장비를 챙겼습니다");
    }
    //프레임 단위 업데이트
    private void FixedUpdate()//물리 연산 업데이트
    {
        Debug.Log("이동->");
    }

    private void Update()// 로직 업데이트
    {
        Debug.Log("몬스터 사냥");
    }

    private void LateUpdate()//모든 업데이트 끝난 후
    {
        Debug.Log("경험치 획득");
    }

    private void OnDisable()//비활성화 시마다 실행(삭제될 때도)
    {
        Debug.Log("플레이어가 로그아웃했습니다");
    }

    private void OnDestroy()//오브젝트가 삭제될 때
    {
        Debug.Log("플레이어 데이터를 삭제하였습니다");
    }
    
}
