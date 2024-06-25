using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCtrl : MonoBehaviour
{
    public Animation ComBatSGAni; // 애니메이션 컴포넌트에 접근
    public Light FlashLight; // 불빛 컴포넌트에 접근
    public AudioClip FlashSound; // 소리파일 -> 출력되는 소스
    public AudioSource FlashSound_Source; // 오디오 소스 -> 소리가 출력되는 위치
    public bool isRun = false;
    void Start() // 게임시작 전 호출되는 공간.
    {
        
    }

    void Update() // 게임 시작 후 계속 반복하여 호출되는 공간. 함수만 존재하도록 해야한다.
    {
        GunCtrl();
        FlashLightOnOff();

    }

    private void FlashLightOnOff()
    {
        if (Input.GetKeyDown(KeyCode.F)) // 키보드에서 f를 입력하면
        {
            FlashLight.enabled = !FlashLight.enabled; // FlashLight의 light 컴포넌트의 상태를 바꾼다.
            FlashSound_Source.PlayOneShot(FlashSound, 1.0f); // PlayOneShot(소리파일, 소리볼륨) -> 소리파일 한번만 출력
        }
    }

    private void GunCtrl()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))//왼쪽 쉬프트 키와 w를 누르는 동안
        {
            isRun = true;
            ComBatSGAni.Play("running"); // 샷건오브젝트 내 running 애니메이션 실행
        }

        else if (Input.GetKeyUp(KeyCode.LeftShift)) //왼쪽 쉬프트 키를 띄웠다면
        {
            isRun = false;
            ComBatSGAni.Play("runStop"); // 샷건오브젝트 내 runStop 애니메이션 실행
        }
    }
}
