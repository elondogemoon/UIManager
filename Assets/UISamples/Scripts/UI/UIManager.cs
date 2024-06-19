using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UIType
{
    SimplePopup,
    MainUI,
}
public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get;  set; }//프로퍼티
    [SerializeField] SimplePopup _simplePopup;

    private Dictionary<UIType,GameObject> _openedUIDic = new Dictionary<UIType, GameObject> ();

    private void Awake()
    {
        Instance = this;
    }
    private void OpenUI(UIType uiType, GameObject uiObject)
    {
        if (_openedUIDic.ContainsKey(uiType)==false )
        {
            uiObject.SetActive (true);
            _openedUIDic.Add(uiType, uiObject);
        }
    }
    

    //extension이 무조건 MVVMㅔ에서만 사용하는 건 아님
    public void OpenSimplePopup(string msg)
    {
        if(_simplePopup != null)
        {
            OpenUI(UIType.SimplePopup, _simplePopup.gameObject);
            //_simplePopup.gameObject.SetActive(true); -> OpenUI로 역할 이전 
            _simplePopup.SetUI(msg);
        }
    }
}
