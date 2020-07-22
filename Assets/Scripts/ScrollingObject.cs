﻿using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

// 게임 오브젝트를 계속 왼쪽으로 움직이는 스크립트
public class ScrollingObject : MonoBehaviour {

    public static float speed = 0.06f;

    private void Update() {
        if (!GameManager.instance.isGameover)
        {
            transform.Translate(Vector3.left * speed);
        }
        // 게임 오브젝트를 왼쪽으로 일정 속도로 평행 이동하는 처리
    }
}