using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacilityMenu : MonoBehaviour
{

    [SerializeField] private GameObject go_FacilityMenuUi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            // 이 메뉴에서 p를 눌러도 select menu가 안뜨게 해야함
            // p를 누를 경우 모든 메뉴창에서 빠져나오도록 해야함
        }
    }

    public void CallMenu()
    {
        SelectMenu.isfacilityMenu = true;
        go_FacilityMenuUi.SetActive(true);
    }

    public void CloseMenu()
    {
        SelectMenu.isfacilityMenu = false;
        go_FacilityMenuUi.SetActive(false);
        //SelectMenu.CallMenu();

    }

    public void ClickFacilityButton()
    {
        Debug.Log("Click FacilityButton ");
    }

    public void ClickExitButton()
    {
        Debug.Log("주요시설 메뉴에서 취소버튼 클릭");
        CloseMenu();
    }

    public void ClickstarttButton()
    {
        Debug.Log("주요시설 기능 실행");
    }

}




