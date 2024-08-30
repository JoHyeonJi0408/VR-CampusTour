using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInMap : MonoBehaviour
{
    [SerializeField] private GameObject go_ButtonInMap;

    //UI들
    [SerializeField] private GameObject FoodButtonsUI;
    [SerializeField] private GameObject HacksaButtonsUI;
    [SerializeField] private GameObject CafeButtonsUI;
    [SerializeField] private GameObject PriterButtonsUI;
    [SerializeField] private GameObject HealthRoomButtonsUI;

    //Button들
    public Button hacsick;
    public Button hacksa;
    public Button youngu_gr;
    public Button print1;
    public Button healthR;

    public void CallMenu() // 일단 private 에서 
    {
        FacilityMenu2.isButtonInMap = true;
        go_ButtonInMap.SetActive(true);
        //FoodButtonsUI.SetActive(true);
    }

    public void ShowButtons(string text)
    {
        if (text.Equals("H")) { HacksaButtonsUI.SetActive(true); hacksa.Select(); }
        else if (text.Equals("F")) { FoodButtonsUI.SetActive(true); hacsick.Select(); }
        else if (text.Equals("P")) { PriterButtonsUI.SetActive(true); print1.Select(); }
        else if (text.Equals("C")) { CafeButtonsUI.SetActive(true); youngu_gr.Select(); }
        else if (text.Equals("B")) { HealthRoomButtonsUI.SetActive(true); healthR.Select(); }
        else
        {
            Debug.Log("ShowButtons 에러");
        }
        
    }
    

    public void onClickButton()
    {
        CloseMenu(); 
        // 네비게이션 기능 수행
    }

    public void CloseMenu()
    {
        FacilityMenu2.isButtonInMap = false;
        go_ButtonInMap.SetActive(false);
        FoodButtonsUI.SetActive(false);
        HacksaButtonsUI.SetActive(false);
        CafeButtonsUI.SetActive(false);
        PriterButtonsUI.SetActive(false);
    }

}
