using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara027 : MonoBehaviour
{
    public static int CharCount027 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char027;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (taiji.Chara8 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char027.SetActive(!false);

        }
        if (taiji.Chara8 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char027.SetActive(false);
        }
    }
}
