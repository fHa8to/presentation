using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara005 : MonoBehaviour
{
    public static int CharCount005 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char005;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (EyeEvolution.eye2 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char005.SetActive(!false);

        }
        if (EyeEvolution.eye2 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char005.SetActive(false);
        }
    }
}
