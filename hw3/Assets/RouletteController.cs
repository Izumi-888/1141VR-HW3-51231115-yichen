using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; // ← 新系統要加這行

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 使用新 Input System 的滑鼠偵測
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            this.rotSpeed = 10;
        }

        transform.Rotate(0, 0, this.rotSpeed);

        // 可選：讓轉盤慢慢減速
        this.rotSpeed *= 0.96f;
    }
}
