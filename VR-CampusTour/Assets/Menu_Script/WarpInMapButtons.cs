using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WarpInMapButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject go_ButtonInMap; // close 할때쓸거

    [SerializeField]
    private GameObject AllButtonsUI; // Button들

    public Test1 test1;


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
    }


    void MoveInMap(Button button) // 아마도 텔레포트할 함수 
    {
        text1 = button.GetComponentInChildren<Text>();
        if (text1 != null) { Debug.Log(text1.text); }
        textString = text1.text;
        Debug.Log("워프 스크립트 불러냄");
        test1.SetVector(textString);
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
