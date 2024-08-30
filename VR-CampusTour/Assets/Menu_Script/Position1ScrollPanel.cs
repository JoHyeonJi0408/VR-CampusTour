using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Position1ScrollPanel : MonoBehaviour
{
    [SerializeField] private GameObject show_ScrollView;
    static Text text1;
    string textString = "Position1";
    public Button nowPo;
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
        nowPo.onClick.AddListener(delegate { buttonClicked(nowPo); });
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
        NaviMenu.Position1Scroll = true;
        show_ScrollView.SetActive(true);
    }

    public void CloseMenu()
    {
        SelectMenu.isNaviMenu = false;
        show_ScrollView.SetActive(false);
        //SelectMenu.CallMenu();

    }

    public void buttonClicked(Button button)
    {
        text1 = button.GetComponentInChildren<Text>();
        if (text1 != null) { Debug.Log(text1.text); }
        textString = text1.text;
        naviMenu.setPos1BtnText();
        naviMenu.po1Btn.Select();
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
