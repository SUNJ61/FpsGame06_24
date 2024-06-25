using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    public float Speed = 1500f;
    public Rigidbody rb;//유니티에서 설정한 Rigibody를 가져오기 위함.
    void Start()
    {               //Vector3.forward는 글로벌 좌표라 이상한 방향으로 총알이 나갈 수 있다.
        rb.AddForce(transform.forward * Speed); //transform.forward(로컬 좌표)로 스피드 만큼 나간다.
        Destroy(this.gameObject, 3.0f); // 자기자신의 오브젝트를 3초후에 메모리에서 삭제한다.
    }
}
