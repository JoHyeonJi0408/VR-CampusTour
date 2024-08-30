using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TriggerZone : MonoBehaviour
{
    [SerializeField] private GameObject go_showMenuUi;
    //public static bool isShowMenu = false;
    public Button button1; // 기준이 될 버튼
    public int buttonCount = 0;

    public bool ketSelected = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)) //메뉴 선택 버튼 누를 경우 캐릭터는 움직일 수 없도록 ...  
        {
            if (ketSelected) 
            {
                Time.timeScale = 0f; 
                button1.Select();
                ketSelected = false;
            }
            else
            {
                Time.timeScale = 1f;
                ketSelected = true;
                //OnDeselect(button1);
            }
            //button1.Select();
            //Debug.Log("버튼 작동");
            //시간 멈추게 한 다음에 버튼 입력하면 시간 다시 흐르도록
            //시간 멈추고 Select()해야함.
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "player")
        {
            CallMenu();
            //만약 메뉴가 꺼져있는 상태라면
            //메뉴를 켜놓는다
            //button1.Select();
            Debug.Log("트리거 작동");
        }

    }

    void OnTriggerExit(Collider col)
    {
        CloseMenu();
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
        go_showMenuUi.SetActive(true);
    }

    public void CloseMenu()
    {
        //InGame.isShowMenu = false;
        go_showMenuUi.SetActive(false);
    }

}
