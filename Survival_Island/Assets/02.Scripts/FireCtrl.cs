using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    [Header("���۳�Ʈ��")]
    public GameObject bulletPrefab; //�Ѿ� ������Ʈ ��������
    public Transform firePos; // �߻� ��ġ ����
    public Animation fireAni; // �Ѿ� �߻� �Ҷ� �ִϸ��̼�
    public AudioSource fireSource; // �Ѿ� �߻� �Ҹ� ��� ��ġ
    public AudioClip fireClip; //�Ѿ� �߻� �Ҹ�
    public ParticleSystem muzzleFlash; // ����Ʈ ����

    [Header("���� ������")]
    public float fireTime;
    public HandCtrl handCtrl;
    void Start()
    {
        //���� �� ��ũ��Ʈ�� �ִ� gameObject(������Ʈ)�� �����ϴ� ���۳�Ʈ HandCtrl�� handCtrl�� ����
        handCtrl = this.gameObject.GetComponent<HandCtrl>();
        fireTime = Time.time; // ����ð��� ����
        muzzleFlash.Stop();
    }

  
    void Update()
    {
        #region �ܹ�
        //0 ���콺 ���� ��ư ������ �� / 1 ���콺 ������ ��ư / 2 ���콺 ��
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Fire();
        //}
        #endregion
        #region ����
            if (Input.GetMouseButton(0)) //������ ���� ��� ȣ��ȴ�. �����̰� ������ ������Ʈ�� ������.
            {
                if (Time.time - fireTime > 0.2f) // ����ð����� ���� �ð��� �� �ð��� 0.1���� Ŭ ���
                {//��, �� ������ 0.1���� �����̸� �ִ� ȿ���� �ִ�.
                    if(handCtrl.isRun == false)
                        Fire();
                    fireTime = Time.time;
                }
            }
        #endregion
        if(Input.GetMouseButtonUp(0)) //���콺 ���� ��ư�� ����� �� �ߵ�
        {
            muzzleFlash.Stop();
        }
    }
    void Fire()
    {
        //          ������        ���            ��� ȸ���ϴ���
        Instantiate(bulletPrefab, firePos.position, firePos.rotation); //������Ʈ ���� �Լ�.
        fireSource.PlayOneShot(fireClip, 1.0f);
        fireAni.Play("fire");
        muzzleFlash.Play();
    }
}

