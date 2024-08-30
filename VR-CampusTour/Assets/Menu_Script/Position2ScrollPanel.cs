using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Position2ScrollPanel : MonoBehaviour
{
    [SerializeField] private GameObject show_ScrollView2;
    static Text text1;
    string textString = "Position2";
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

    public NaviMenu naviMenu;

    // Start is called before the first frame update
    void Start()
    {
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallMenu()
    {
        NaviMenu.Position2Scroll = true;
        show_ScrollView2.SetActive(true);
    }

    public void CloseMenu()
    {
        SelectMenu.isNaviMenu = false;
        show_ScrollView2.SetActive(false);
        //SelectMenu.CallMenu();

    }

    public void buttonClicked(Button button)
    {
        text1 = button.GetComponentInChildren<Text>();
        if (text1 != null) { Debug.Log(text1.text); }
        textString = text1.text;
        naviMenu.setPos2BtnText();
        naviMenu.po2Btn.Select();
    }

    public string returnBtnText()
    {
        return textString;
    }

    public void onClick()
    {
        CloseMenu();
    }


}
