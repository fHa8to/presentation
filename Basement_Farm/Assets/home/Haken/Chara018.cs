using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara018 : MonoBehaviour
{
    public static int CharCount018 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char018;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Faceevolution.face >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char018.SetActive(!false);

        }
        if (Faceevolution.face == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char018.SetActive(false);
        }
    }
}
