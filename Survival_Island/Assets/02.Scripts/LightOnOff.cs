using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    public Light StairLight;
    public AudioSource Sorce;
    public AudioClip LightSound;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) // is trigger를 사용했을 때 통과하면서 충돌 감지하는 함수
    {
        // 사용자가 호출하지 않아고 조건을 만족하면 스스로 호출하기에 콜백함수라고 한다.
        //여기서 collider는 충돌을 감지하는 구조체이다.
        if(other.gameObject.tag == "Player") // 충돌된 오브젝트의 태그가 플레이어면
        {
            StairLight.enabled = true; //충돌 감지가 되면 불빛이 on된다. light컴퍼넌트 체크가된다.
            Sorce.PlayOneShot(LightSound, 1.0f);
        }
    }
    private void OnTriggerExit(Collider other) // collider 범위에 들어왔다가 빠져나갔을 때 발동하는 함수.
    { //OnTriggerEnter와 한쌍이다.
        if(other.gameObject.tag =="Player")
        {
            StairLight.enabled = false;
            Sorce.PlayOneShot(LightSound, 1.0f);
        }
    }

    void Update()
    {

    }
}
