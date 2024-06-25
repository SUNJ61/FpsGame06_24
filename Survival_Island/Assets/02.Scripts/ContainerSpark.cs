using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerSpark : MonoBehaviour
{
    public GameObject sparkPF;
    public AudioSource sparkSource;
    public AudioClip sparkClip;
    void Start()
    {
        
    }

    // IsTrigger 체크 없이는 블록에 막힐 때를 체크한다.
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "BULLET")
        {
            Destroy(col.gameObject); // 맞자마자 총알제거
            sparkSource.PlayOneShot(sparkClip, 1.0f);
            var spark = Instantiate(sparkPF, col.transform.position, Quaternion.identity);
            //                      무엇을 , 어디서(충돌한 위치)   , 회전 없이 생성 
            Destroy(spark, 2.0f); // 2초후에 생성된 이펙트 제거
            //spark를 선언한이유는 새로 이펙트를 만들어서 제거해야 소환가능하다.
        }
    }

    void Update()
    {
        
    }
}
