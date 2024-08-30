using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HackgoonTriggerzone : MonoBehaviour
{
    [SerializeField] private GameObject go_BuildingText;
    public int buttonCount = 0;
    public Text BuildingText;

    public bool ketSelected = false;
    public bool showText = false;

    public bool coliterOn = false;


    // Start is called before the first frame update
    void Start()
    {
    }

    void Awake() // Start전에 실행하는 함수.
    {
    }

    // Update is called once per frame
    // 
    void Update()
    {
        if (coliterOn)
        {

        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "player")
        {
            CallMenu();
            BuildingText.text = "학군단";
            coliterOn = true;
            Debug.Log("지선관 트리거 작동");
        }
    }

    void OnTriggerExit(Collider col)
    {
        CloseMenu();
        ketSelected = false;
        coliterOn = false;
    }

    void OnTriggerStay(Collider col)
    {

    }

    public void CallMenu() // 일단 private 에서 
    {
        go_BuildingText.SetActive(true);
    }

    public void CloseMenu()
    {
        //InGame.isShowMenu = false;
        go_BuildingText.SetActive(false);
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
