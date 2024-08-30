using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NaviSelectButtonInMap : MonoBehaviour
{
    [SerializeField] private GameObject go_ButtonInMap; // close 할때쓸거

    [SerializeField] private GameObject AllButtonsUI; // Button들

    public NaviMenu naviMenu;

    static Text text1;
    string textString = "Position2"; // position2로 나오면 오류난거임.

    public Button Jinri;
    public Button wochon;
    public Button hacksong;
    public Button tamgoo;
    public Button gonghack;
    public Button hackgoon;
    public Button yeongu;
    public Button jisun;
    public Button insung;
    public Button changi;
    public Button nacksan;
    public Button mirae;
    public Button sangsang;
    public Button sangbil;

    public bool ImNavi = false;

    // Start is called before the first frame update
    void Start()
    {
        //if (ImNavi)
        //{
            Jinri.onClick.AddListener(delegate { buttonClicked(Jinri); });
            wochon.onClick.AddListener(delegate { buttonClicked(wochon); });
            hacksong.onClick.AddListener(delegate { buttonClicked(hacksong); });
            tamgoo.onClick.AddListener(delegate { buttonClicked(tamgoo); });
            gonghack.onClick.AddListener(delegate { buttonClicked(gonghack); });
            hackgoon.onClick.AddListener(delegate { buttonClicked(hackgoon); });
            yeongu.onClick.AddListener(delegate { buttonClicked(yeongu); });
            jisun.onClick.AddListener(delegate { buttonClicked(jisun); });
            insung.onClick.AddListener(delegate { buttonClicked(insung); });
            changi.onClick.AddListener(delegate { buttonClicked(changi); });
            nacksan.onClick.AddListener(delegate { buttonClicked(nacksan); });
            mirae.onClick.AddListener(delegate { buttonClicked(mirae); });
            sangsang.onClick.AddListener(delegate { buttonClicked(sangsang); });
            sangbil.onClick.AddListener(delegate { buttonClicked(sangbil); });
        //}
        /*else
        {
            Jinri.onClick.AddListener(delegate { MoveInMap(Jinri); });
            wochon.onClick.AddListener(delegate { MoveInMap(wochon); });
            hacksong.onClick.AddListener(delegate { MoveInMap(hacksong); });
            tamgoo.onClick.AddListener(delegate { MoveInMap(tamgoo); });
            gonghack.onClick.AddListener(delegate { MoveInMap(gonghack); });
            hackgoon.onClick.AddListener(delegate { MoveInMap(hackgoon); });
            yeongu.onClick.AddListener(delegate { MoveInMap(yeongu); });
            jisun.onClick.AddListener(delegate { MoveInMap(jisun); });
            insung.onClick.AddListener(delegate { MoveInMap(insung); });
            changi.onClick.AddListener(delegate { MoveInMap(changi); });
            nacksan.onClick.AddListener(delegate { MoveInMap(nacksan); });
            mirae.onClick.AddListener(delegate { MoveInMap(mirae); });
            sangsang.onClick.AddListener(delegate { MoveInMap(sangsang); });
            sangbil.onClick.AddListener(delegate { MoveInMap(sangbil); });
        }*/
    }

    
    void buttonClicked(Button button)
    {
        text1 = button.GetComponentInChildren<Text>();
        if (text1 != null) { Debug.Log(text1.text); }
        textString = text1.text;
        naviMenu.setPos2BtnText();
        naviMenu.po2Btn.Select();
        CloseMenu();
    }

    public void ImNaviSetTrue()
    {
        ImNavi = true;
    }

    public void ImNaviSetFalse()
    {
        ImNavi = false;
    }

    void MoveInMap(Button button) // 아마도 텔레포트할 함수 
    {
        //텔레포트함수
        CloseMenu();
    }

    public void ShowAllButtons() //버튼들 다 보여준다.
    {
        AllButtonsUI.SetActive(true);
    }

    public void CloseMenu()
    {
        go_ButtonInMap.SetActive(false);
        AllButtonsUI.SetActive(false);
    }

    public void CallMenu()
    {
        go_ButtonInMap.SetActive(true);
        AllButtonsUI.SetActive(true);
    }

    public string returnBtnText()
    {
        return textString;
    }


}
