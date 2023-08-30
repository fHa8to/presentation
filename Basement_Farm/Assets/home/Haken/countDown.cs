using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countDown : MonoBehaviour
{
    [SerializeField] public GameObject start;
    [SerializeField] public GameObject reset;

    int rand;

    public Text timer;      // �e�L�X�g�^�C�}�[
    float CountDownTime;    // �J�E���g�_�E��
    int num;


    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = 10.0f;      //�@�J�E���g�_�E���J�n�b�����Z�b�g
        //minute = CountDownTime / 60;
        timer = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //�o�ߎ����������Ă���
        CountDownTime -= Time.deltaTime;


        // 0.0�b�ɂȂ�����J�E���g�_�E���^�C����0.0�ŌŒ�(�~�܂����悤�Ɍ�����)
        if (CountDownTime <= 0.0f)
        {
            SceneManager.LoadScene("getScene");
        }
        else
        {
            //�J�E���g�_�E���^�C�����`���ĕ\��
            timer.text = string.Format("{0:00}�b", CountDownTime);
            Debug.Log(CountDownTime);
        }

    }

}
