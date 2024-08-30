using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class NaviMenu : MonoBehaviour
{
    [SerializeField] private GameObject go_NaviMenuUi;
    [SerializeField] private GameObject go_AllButtonInMap;
    //[SerializeField] private GameObject SoundObj;

    public SelectMenu selectMenu;
    public Position1ScrollPanel position1ScrollPanel;
    public Position2ScrollPanel position2ScrollPanel;
    public NaviSelectButtonInMap naviSelectButtonInMap;

    public static bool Position1Scroll = false;
    public static bool Position2Scroll = false;

    public Button po1Btn;
    public Button po2Btn;

    public string po1Text;
    public string po2Text;

    //navigation
    public NavMeshAgent agent; // 네비게이션 에이전트.
    public Transform start; // 시작 위치.
    public Transform destination; // 목적지 위치.
    public GameObject navi; // 목적지까지 움직여 줄 빈 GameObject.
    public GameObject player; // 움직이는 player.

    private float TimeLeft = 1.2f;
    private float nextTime = 0.0f;
    private int count = 0;

    public static bool navigation_start = false; // 네비게이션 시작을 위한 변수.

    //public static bool sound_start = false;

    // Update is called once per frame


    void Update()
    {
    }

    void Start()
    {
        //SoundObj.SetActive(true);
    }
    

    public void setPos1BtnText()
    {
        po1Text = position1ScrollPanel.returnBtnText();
        po1Btn.GetComponentInChildren<Text>().text = po1Text;
    }

    public void setPos2BtnText()
    {
        //po2Text = position2ScrollPanel.returnBtnText();
        po2Text = naviSelectButtonInMap.returnBtnText();
        po2Btn.GetComponentInChildren<Text>().text = po2Text;
    }

    public void CallMenu()
    {
        SelectMenu.isNaviMenu = true;
        go_NaviMenuUi.SetActive(true);
        po2Btn.GetComponentInChildren<Text>().text = "Position";
    }

    public void CloseMenu()
    {
        SelectMenu.isNaviMenu = false;
        go_NaviMenuUi.SetActive(false);
        //SelectMenu.CallMenu();

    }

    public void AllBubbleDel()
    {
        GameObject[] tempobj = GameObject.FindGameObjectsWithTag("Finish");
        foreach (GameObject ob in tempobj)
        {
            Destroy(ob);
        }
    }

    public void ClickExitButton()
    {
        //Debug.Log("네비게이션 메뉴에서 취소버튼 클릭");
        CloseMenu();
        //InGame.isSelectMenu = true;
    }

    public void ClickstarttButton()

    {
        CloseMenu();
        AllBubbleDel();
        //Sound.sound_start = true;
        //SoundObj.SetActive(true);
        //Navigation.sound_start = true;
        Navigation.navigation_enabled = true;
        Navigation.navigation_start = true;
        // start위치 player위치로 초기화.
        start.transform.position = player.transform.position;
        // navi위치 start로 초기화.
        navi.transform.position = start.transform.position;
        Vector3 naviPoint = new Vector3();
        naviPoint = navi.transform.position;// navi위치 저장.
        naviPoint.y = naviPoint.y + 1;// 캡슐이기때문에 y값 +1
        //메뉴 닫고 네비게이션 코드 실행되어야함.
        //건물 이름을 넘겨줄 예정. return po2Text!
        switch (po2Text)
        {
            case "낙산관":
                destination.transform.position = new Vector3(211.66f, 0.0f, 106.58f);
                //destination.transform.position = new Vector3(0.7f, 0.0f, 11.88f);
                break;
            case "인성관 창의관":
                destination.transform.position = new Vector3(207.33f, 0.0f, 97.65f);
                break;
            case "미래관":
                destination.transform.position = new Vector3(194.14f, 0.0f, 120.82f);
                //destination.transform.position = new Vector3(28.84f, 0.0f, -8.05f);
                break;
            case "우촌관":
                destination.transform.position = new Vector3(184.18f, 0.0f, 177.38f);
                break;
            case "상상관":
                destination.transform.position = new Vector3(97.71f, 0.6f, 155.56f);
                break;
            case "진리관":
                destination.transform.position = new Vector3(96.84f, 0.0f, 185.86f);
                break;
            case "학송관":
                destination.transform.position = new Vector3(70.33f, 0.0f, 210.62f);
                break;
            case "탐구관":
                destination.transform.position = new Vector3(35.96f, 0.0f, 230.54f);
                break;
            case "학군단":
                destination.transform.position = new Vector3(20.82f, 0.0f, 217.2f);
                break;
            case "연구관":
                destination.transform.position = new Vector3(76.98f, 7.0f, 103.49f);
                break;
            case "지선관":
                destination.transform.position = new Vector3(71.27f, 7.0f, 99.43f);
                break;
            case "공학관":
                destination.transform.position = new Vector3(55.8f, 9.0f, 43.55f);
                break;
            case "상상빌리지":
                destination.transform.position = new Vector3(62.66f, 9.0f, 26.14f);
                break;
        }
        //Debug.Log("네비게이션 기능 실행");
        //CloseMenu();
        
    }

    public void ClickPosition1Button()
    {
        //Debug.Log("Position 1 버튼 클릭");
        //position1ScrollPanel.CallMenu();
       // po1Btn.GetComponentInChildren<Text>() = "aaa";
    }

    public void ClickPosition2Button()
    {
        //Debug.Log("Position 2 버튼 클릭");
        //position2ScrollPanel.CallMenu();
        naviSelectButtonInMap.CallMenu();
        naviSelectButtonInMap.mirae.Select();
        naviSelectButtonInMap.ImNaviSetTrue();
        //naviSelectButtonInMap.ImNavi = true;
        //go_AllButtonInMap.SetActive(true);
        //selectMenu.CallMenu();
    }

}
