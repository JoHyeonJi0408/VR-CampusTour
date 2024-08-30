using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FacilityMenu2 : MonoBehaviour
{
    [SerializeField] private GameObject go_FacilityMenuUi2;

    public static bool isButtonInMap = false; //false면 안보이고 true이면 보인다
    public ButtonInMap buttonInMap; // 객체참조

    public Button hacksaB;
    public Button cafeB;
    public Button toiletB;
    public Button FoodB;
    public Button PrinterB;

    public void CallMenu()
    {
        SelectMenu.isfacilityMenu2 = true;
        go_FacilityMenuUi2.SetActive(true);
    }

    public void CloseMenu()
    {
        SelectMenu.isfacilityMenu2 = false;
        go_FacilityMenuUi2.SetActive(false);
        //SelectMenu.CallMenu();

    }

    //click 함수들 축약할 필요

    public void ClickhacksaB()
    {
        //Debug.Log("학사지원팀 버튼 클릭");
        buttonInMap.CallMenu();
        buttonInMap.ShowButtons("H");
        CloseMenu();
    }

    public void ClickcafeB()
    {
        //Debug.Log("교내카페 매점 버튼 클릭");
        buttonInMap.CallMenu();
        buttonInMap.ShowButtons("C");
        CloseMenu();
    }

    public void ClickFoodB()
    {
        //Debug.Log("학식당 버튼 클릭");
        buttonInMap.CallMenu();
        buttonInMap.ShowButtons("F");
        CloseMenu();
    }

    public void ClickPrinterB()
    {
        //Debug.Log("프린터룸 버튼 클릭");
        buttonInMap.CallMenu();
        buttonInMap.ShowButtons("P");
        CloseMenu();
    }

    public void ClickHealthRoomB()
    {
        //Debug.Log("보건실 버튼 클릭");
        buttonInMap.CallMenu();
        buttonInMap.ShowButtons("B");
        CloseMenu();
    }

    public void ClickExitButton()
    {
        //Debug.Log("주요시설 메뉴에서 취소버튼 클릭");
        CloseMenu();
    }

}
