using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara014 : MonoBehaviour
{
    public static int CharCount014 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char014;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Hirusukeevolution.hiruku >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char014.SetActive(!false);

        }
        if (Hirusukeevolution.hiruku == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char014.SetActive(false);
        }
    }
}
