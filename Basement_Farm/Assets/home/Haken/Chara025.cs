using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara025 : MonoBehaviour
{
    public static int CharCount025 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char025;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Musibaevolution.musiba2 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char025.SetActive(!false);

        }
        if (Musibaevolution.musiba2 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char025.SetActive(false);
        }
    }
}
