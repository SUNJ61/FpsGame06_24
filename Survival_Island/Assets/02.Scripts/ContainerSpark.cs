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

    // IsTrigger üũ ���̴� ��Ͽ� ���� ���� üũ�Ѵ�.
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "BULLET")
        {
            Destroy(col.gameObject); // ���ڸ��� �Ѿ�����
            sparkSource.PlayOneShot(sparkClip, 1.0f);
            var spark = Instantiate(sparkPF, col.transform.position, Quaternion.identity);
            //                      ������ , ���(�浹�� ��ġ)   , ȸ�� ���� ���� 
            Destroy(spark, 2.0f); // 2���Ŀ� ������ ����Ʈ ����
            //spark�� ������������ ���� ����Ʈ�� ���� �����ؾ� ��ȯ�����ϴ�.
        }
    }

    void Update()
    {
        
    }
}
