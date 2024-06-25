using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    [Header("컴퍼넌트들")]
    public GameObject bulletPrefab; //총알 오브젝트 가져오기
    public Transform firePos; // 발사 위치 설정
    public Animation fireAni; // 총알 발사 할때 애니메이션
    public AudioSource fireSource; // 총알 발사 소리 출력 위치
    public AudioClip fireClip; //총알 발사 소리
    public ParticleSystem muzzleFlash; // 이펙트 설정

    [Header("각종 변수들")]
    public float fireTime;
    public HandCtrl handCtrl;
    void Start()
    {
        //지금 이 스크립트가 있는 gameObject(오브젝트)에 존재하는 컴퍼넌트 HandCtrl를 handCtrl에 대입
        handCtrl = this.gameObject.GetComponent<HandCtrl>();
        fireTime = Time.time; // 현재시간을 대입
        muzzleFlash.Stop();
    }

  
    void Update()
    {
        #region 단발
        //0 마우스 왼쪽 버튼 눌렀을 때 / 1 마우스 오른쪽 버튼 / 2 마우스 휠
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Fire();
        //}
        #endregion
        #region 연사
            if (Input.GetMouseButton(0)) //누르는 동안 계속 호출된다. 딜레이가 없으면 오브젝트가 과생성.
            {
                if (Time.time - fireTime > 0.2f) // 현재시간에서 과거 시간을 뺀 시간이 0.1보다 클 경우
                {//즉, 위 조건은 0.1초의 딜레이를 주는 효과가 있다.
                    if(handCtrl.isRun == false)
                        Fire();
                    fireTime = Time.time;
                }
            }
        #endregion
        if(Input.GetMouseButtonUp(0)) //마우스 왼쪽 버튼을 띄웠을 때 발동
        {
            muzzleFlash.Stop();
        }
    }
    void Fire()
    {
        //          무엇이        어디서            어떻게 회전하는지
        Instantiate(bulletPrefab, firePos.position, firePos.rotation); //오브젝트 생성 함수.
        fireSource.PlayOneShot(fireClip, 1.0f);
        fireAni.Play("fire");
        muzzleFlash.Play();
    }
}

