using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class A : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Platform_Long;



    void Start()
    {
        Invoke("create", 3f);
        // 변수들을 초기화하고 사용할 발판들을 미리 생성
    }

    void create()
    {
        Instantiate(Platform_Long);
        Instantiate(Platform_Long, new Vector3(1, 1, 1), transform.rotation);
    }

    void Update()
    {
        // 순서를 돌아가며 주기적으로 발판을 배치
    }
}