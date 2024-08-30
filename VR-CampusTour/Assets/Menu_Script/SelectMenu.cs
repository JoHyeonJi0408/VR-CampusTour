using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class SelectMenu : MonoBehaviour
{
    [SerializeField] private GameObject go_BaseUi;
    [SerializeField] private GameObject AllButton;
    [SerializeField] private GameObject AllButton2;
    [SerializeField] private GameObject HacksaButton;
    [SerializeField] private GameObject FoodButton;
    [SerializeField] private GameObject HealthButton;
    [SerializeField] private GameObject PrinterButton;
    [SerializeField] private GameObject CafeButton;
    [SerializeField] private GameObject StartMenuUI;

    public static bool isNaviMenu = false;
    public static bool isfacilityMenu = false;
    public static bool isfacilityMenu2 = false;

    public NaviMenu naviMenu;
    public FacilityMenu facilityMenu;
    public FacilityMenu2 facilityMenu2;
    public ButtonInMap buttonInMap;
    public NaviSelectButtonInMap naviSelectButtonInMap;
    public WarpInMapButtons warpInMapButtons;

    public Button naviButton;
    public Button FButton;
    public Button MapButton;
    public Button backStartButton;
    public Button ButtonP1;

    public string startscene = "MenuScene"; // TItle Scenes


    //NaviMenu naviMenu = new NaviMenu.ctor();
    //Unit m_Unit = gameObject.AddComponent("Marine") as Unit

    void Start()
    {
        //naviMenu = gameObject.AddComponent<NaviMenu>() as NaviMenu;
    }

    void Awake()
    {
        //naviButton.transform.GetChild(0).animation["Button_AnimatorController"].time = 0.0f;
        //.parent.GetComponent("AnimationScript").aniStart = true;
    
    //naviButton.transform.GetComponent("AnimationScript").aniStart = true;
        //FButton.animation.normalizeTime = 0;
        //MapButton.animation.normalizeTime = 0;
        //backStartButton.animation.normalizeTime = 0;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || OVRInput.GetDown(OVRInput.Button.Two, OVRInput.Controller.LTouch))
            //OVRInput.GetDown(OVRInput.Button.Four)) // P입력 시 메뉴화면.
        {
            if (!InGame.isSelectMenu)
            {
                CallMenu();
                naviButton.Select();
            }
            else
            {
                
                CloseMenu(); // P누르면 Select Menu도 같이 사라질 수 있도록
                naviMenu.CloseMenu();
                facilityMenu2.CloseMenu();
                buttonInMap.CloseMenu();
                AllButton.SetActive(false);
                AllButton2.SetActive(false);
                HacksaButton.SetActive(false);
                FoodButton.SetActive(false);
                HealthButton.SetActive(false);
                PrinterButton.SetActive(false);
                CafeButton.SetActive(false);

            }
        }
        /*
        if (Input.GetKeyDown(KeyCode.O)) // O입력 시
        {
            if (InGame.isSelectMenu) // 메뉴가 켜져 있을 경우
            {
                CloseMenu(); // O누르면 Select Menu도 같이 사라질 수 있도록
                naviMenu.CloseMenu();
                facilityMenu2.CloseMenu();
                buttonInMap.CloseMenu();
            }
            else
            {

            }

        }
        */
    }

    public void CallMenu() // 일단 private 에서 
    {
        InGame.isSelectMenu = true;
        go_BaseUi.SetActive(true);

        //Time.timeScale = 0f; // 시간을 멈추는 기능
    }

    public void CloseMenu()
    {
        InGame.isSelectMenu = false;
        //EventSystem.current.SetSelectedGameObject(null); // 버튼 선택 모두 취소
        go_BaseUi.SetActive(false);
        //Time.timeScale = 1f;
    }

    public void ClickNaviButton()
    {
        Debug.Log("네비게이션 메뉴 클릭");
        naviMenu.CallMenu();
        naviMenu.po2Btn.Select(); // 클릭 되어있는 버튼이 있어야 키보드로 조종 가능
        CloseMenu();
        InGame.isSelectMenu = true; //navi, facilty가 true이면 p눌러도 안뜨게 true값 줌
    }

    public void ClickfacilityButton()
    {
        Debug.Log("주요시설 메뉴 클릭");
        facilityMenu2.CallMenu();
        facilityMenu2.hacksaB.Select();
        CloseMenu();
        InGame.isSelectMenu = true;
    }

    public void ClickMapButton()
    {
        Debug.Log("맵 메뉴 클릭");
        warpInMapButtons.CallMenu();
        warpInMapButtons.mirae.Select();
        CloseMenu();
        InGame.isSelectMenu = true;
    }

    public void ClickGoStartButton()
    {
        Debug.Log("메뉴화면");
        Application.Quit(); // 게임종료
        CloseMenu();
        SceneManager.LoadScene(startscene); // 메뉴화면으로 돌아간 후 index확인
    }

    public void ClickFacilityButton()
    {
        Debug.Log("Click FacilityButton ");
    }

    public void ClickStartButton()
    {
        CloseMenu();
        StartMenuUI.SetActive(true);
        ButtonP1.Select();
    }


}
