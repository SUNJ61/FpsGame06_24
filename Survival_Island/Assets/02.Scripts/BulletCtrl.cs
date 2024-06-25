using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    public float Speed = 1500f;
    public Rigidbody rb;//����Ƽ���� ������ Rigibody�� �������� ����.
    void Start()
    {               //Vector3.forward�� �۷ι� ��ǥ�� �̻��� �������� �Ѿ��� ���� �� �ִ�.
        rb.AddForce(transform.forward * Speed); //transform.forward(���� ��ǥ)�� ���ǵ� ��ŭ ������.
        Destroy(this.gameObject, 3.0f); // �ڱ��ڽ��� ������Ʈ�� 3���Ŀ� �޸𸮿��� �����Ѵ�.
    }
}
