using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainUI : MonoBehaviour
{
    //[SerializeField] SimplePopup Popup_simplePopup;

    public void OnClick_PopupSimpleMsg()
    {        
        UIManager.Instance.OpenSimplePopup("심플 팝업 출력");
    }
}
