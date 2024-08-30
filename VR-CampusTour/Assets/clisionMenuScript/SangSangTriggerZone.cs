using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SangSangTriggerZone : MonoBehaviour
{
    [SerializeField] private GameObject go_showMenuUi;//눌러보세요 UI
    [SerializeField] private GameObject go_BuildingText;
    [SerializeField] private GameObject go_Menu; // 그 건물의 메뉴
    [SerializeField] private GameObject go_showInside;
    //public static bool isShowMenu = false;
    public Button button1; // 기준이 될 버튼
    public int buttonCount = 0;

    public Text BuildingText;

    public bool ketSelected = false;
    public bool showText = false;

    public bool coliterOn = false;


    // Start is called before the first frame update
    void Start()
    {
        //BuildingText.text = "공학관"; // text를 공학관으로 바꿔줄것임.
    }

    void Awake() // Start전에 실행하는 함수.
    {
        //BuildingText.text = "공학관"; // text를 공학관으로 바꿔줄것임.
    }

    // Update is called once per frame
    // 
    void Update()
    {
        if (coliterOn)
        {
            if (Input.GetKeyDown(KeyCode.I) || OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.LTouch)) //메뉴 선택 버튼 누를 경우 캐릭터는 움직일 수 없도록 ...  
            {
                if (go_Menu.activeSelf == true && go_showInside.activeSelf == false)
                {
                    Time.timeScale = 1f;
                    ketSelected = false;
                    go_Menu.SetActive(false);
                    EventSystem.current.SetSelectedGameObject(null); // 버튼 선택 할 수 없음
                    //go_showInside.CloseMenu();
                    //go_showInside.SetActive(false);

                }
                else if (go_showInside.activeSelf == true)
                {
                    go_showInside.SetActive(false);
                }
                else
                {
                    Time.timeScale = 0f; // 시간을 멈추게 해야 버튼을 클릭 할 수 있게되는데 수정 가능할까 ㅜㅜ
                    button1.Select(); // 버튼 하나 선택된 상태여야 키보드로 선택이 가능함.
                    go_Menu.SetActive(true);
                    //go_showInside.SetActive(true);
                    ketSelected = true;
                }
                //button1.Select();
                //Debug.Log("버튼 작동");
                //시간 멈추게 한 다음에 버튼 입력하면 시간 다시 흐르도록
                //시간 멈추고 Select()해야함.
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "player")
        {
            CallMenu();
            BuildingText.text = "상상관";
            //만약 메뉴가 꺼져있는 상태라면
            //메뉴를 켜놓는다
            //button1.Select();
            coliterOn = true;
            Debug.Log("트리거 작동");
        }
    }

    void OnTriggerExit(Collider col)
    {
        CloseMenu();
        ketSelected = false;
        go_Menu.SetActive(false);
        coliterOn = false;
        //트리거 해제됨
        //현재 Select 되어있는 Button 을 disable해야함
        //button1.Reset();
    }

    void OnTriggerStay(Collider col)
    {

    }

    public void CallMenu() // 일단 private 에서 
    {
        //InGame.isShowMenu = true;
        go_BuildingText.SetActive(true);
        go_showMenuUi.SetActive(true);
    }

    public void CloseMenu()
    {
        //InGame.isShowMenu = false;
        go_BuildingText.SetActive(false);
        go_showMenuUi.SetActive(false);
    }


    public void showBuildingText()
    {
        go_BuildingText.SetActive(true);
    }

    public void closeBuildingText()
    {
        go_BuildingText.SetActive(false);
    }



}
