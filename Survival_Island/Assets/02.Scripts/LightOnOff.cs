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

    private void OnTriggerEnter(Collider other) // is trigger�� ������� �� ����ϸ鼭 �浹 �����ϴ� �Լ�
    {
        // ����ڰ� ȣ������ �ʾư� ������ �����ϸ� ������ ȣ���ϱ⿡ �ݹ��Լ���� �Ѵ�.
        //���⼭ collider�� �浹�� �����ϴ� ����ü�̴�.
        if(other.gameObject.tag == "Player") // �浹�� ������Ʈ�� �±װ� �÷��̾��
        {
            StairLight.enabled = true; //�浹 ������ �Ǹ� �Һ��� on�ȴ�. light���۳�Ʈ üũ���ȴ�.
            Sorce.PlayOneShot(LightSound, 1.0f);
        }
    }
    private void OnTriggerExit(Collider other) // collider ������ ���Դٰ� ���������� �� �ߵ��ϴ� �Լ�.
    { //OnTriggerEnter�� �ѽ��̴�.
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
