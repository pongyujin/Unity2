using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 8.0f;
    // 핵심임 스크립트 자료형은 스크립트 이름임
    PlayerInput playerinput;
    Rigidbody playerRigid;
    void Start()
    {
        playerinput = GetComponent<PlayerInput>();
        playerRigid = GetComponent<Rigidbody>();
    }

    // 고정적으로 fixed 1초에 60번
    // update 메서드는 성능 좋아서 계속 업데이트가 되는데 
    // fixed는 고정적으로해서 저성능으로도 돌아간다 ... 
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        float xspeed = playerinput.xmove * speed;
        float zspeed = playerinput.zmove * speed;

        Vector3 newVelocity = new Vector3(xspeed, 0, zspeed);
        playerRigid.velocity = newVelocity;

    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}
