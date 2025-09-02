using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // 외부에서 참조하게 만들거임 근데 .. 다른곳에서 값이 바뀔수도있자너.. 퍼블릭이어가지구.. 
    // 프로퍼티는 이렇게 만든다네.....
    public float xmove{get; private set;}
    public float zmove{get; private set;}
    void Start()
    {
        
    }

    void Update()
    {
        // up down 
        xmove = Input.GetAxis("Horizontal");

        // 양옆
        zmove = Input.GetAxis("Vertical");
    }
}
