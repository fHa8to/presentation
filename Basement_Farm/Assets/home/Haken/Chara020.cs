using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara020 : MonoBehaviour
{
    public static int CharCount020 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char020;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Bakuteriaevolution.kisei >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char020.SetActive(!false);

        }
        if (Bakuteriaevolution.kisei == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char020.SetActive(false);
        }
    }
}
