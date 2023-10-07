using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Transform tr;//오브젝트는 기본적으로 Transform을 가지고 있으므로 초기화할 필요 없음
        //오브젝트가 기본적으로 가지는 Transform 변수는 transform임.

        int number = 4;//스칼라
        //Vector3 vec = new Vector3(5, 5, 5);//벡터 값

        //transform.Translate(vec);
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 vec = new Vector3(0, 0.1f, 0);//벡터 값
        //transform.Translate(vec);

        Vector3 vec = new Vector3(//키보드 입력을 통한 오브젝트 이동
            Input.GetAxis("Horizontal")*Time.deltaTime,
            Input.GetAxis("Vertical")*Time.deltaTime, 0);
        transform.Translate(vec);
    }
}
