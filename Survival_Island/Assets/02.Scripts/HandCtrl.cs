using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCtrl : MonoBehaviour
{
    public Animation ComBatSGAni; // �ִϸ��̼� ������Ʈ�� ����
    public Light FlashLight; // �Һ� ������Ʈ�� ����
    public AudioClip FlashSound; // �Ҹ����� -> ��µǴ� �ҽ�
    public AudioSource FlashSound_Source; // ����� �ҽ� -> �Ҹ��� ��µǴ� ��ġ
    void Start() // ���ӽ��� �� ȣ��Ǵ� ����.
    {
        
    }

    void Update() // ���� ���� �� ��� �ݺ��Ͽ� ȣ��Ǵ� ����. �Լ��� �����ϵ��� �ؾ��Ѵ�.
    {
        GunCtrl();
        FlashLightOnOff();

    }

    private void FlashLightOnOff()
    {
        if (Input.GetKeyDown(KeyCode.F)) // Ű���忡�� f�� �Է��ϸ�
        {
            FlashLight.enabled = !FlashLight.enabled; // FlashLight�� light ������Ʈ�� ���¸� �ٲ۴�.
            FlashSound_Source.PlayOneShot(FlashSound, 1.0f); // PlayOneShot(�Ҹ�����, �Ҹ�����) -> �Ҹ����� �ѹ��� ���
        }
    }

    private void GunCtrl()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W)) //���� ����Ʈ Ű�� w�� ������ ����
            ComBatSGAni.Play("running"); // ���ǿ�����Ʈ �� running �ִϸ��̼� ����

        else if (Input.GetKeyUp(KeyCode.LeftShift)) //���� ����Ʈ Ű�� ����ٸ�
            ComBatSGAni.Play("runStop"); // ���ǿ�����Ʈ �� runStop �ִϸ��̼� ����
    }
}
