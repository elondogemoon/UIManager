using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SimplePopup : MonoBehaviour
{
    //UI�� ����������
    //���°� �ڱⰡ
    //���Ȯ��
    [SerializeField] Text Text_Msg;

    //WaitForSeconds _waitForSec = new WaitForSeconds(1.5f);
    private void OnEnable()
    {
        StartCoroutine(CoCloseSelf());  
    }
    
    private void OnDisable()
    {
            
    }

    public void SetUI(string msg)
    {
        Text_Msg.text = msg;
        CheckAndChangeColor(msg);
    }

    private void CheckAndChangeColor(string msg)
    {
        if (msg.Contains("���"))
        {
            Text_Msg.color = Color.red;
        }
    }

    IEnumerator CoCloseSelf()
    {
        yield return new WaitForSeconds(1.5f);
        this.gameObject.SetActive(false);
    }


    //UIBase ����� �ű⿡ OnBeforeEnable()
    //Awake�� OnEnable�� ������ �������� �ʴ� ��찡 �־
    //Ȯ���ϰ� OnEnable�ϱ� ���� ������ ���� ó���� �ʿ��� ��츦 ����
}
