using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Test1 : MonoBehaviour
{
    [SerializeField] private GameObject FadeOutUi;
    [SerializeField] private GameObject FadeOutUi2;
    [SerializeField] private GameObject StartUI;

    public GameObject person1;
    public GameObject box1;
    public Transform Playerposition;
    //public Transform Target;
    //Vector3 maplastpos = new Vector3(0f, 52f, -31f);
    public bool onM; // 좌표 이동하기 위해 임의의 boolean값
    

    public bool buttonClicked = false;

    //타이머
    public float TimeLeft = 3.0f;
    public float nextTime = 0.0f;
    public float endTime = 7.0f;

    float timer;
    float waitingTime;
    float endtimer;
    float endFadeOut;

    public Transform Sangpos;
    //좌표
   
    Vector3 Main_Test_1 = new Vector3(0.0f, 0.0f, 0.0f);
    Vector3 Main_Test_2 = new Vector3(10.0f, 0.0f, 0.0f);

    public static bool startWarp = false;

    public string buildingText = "";

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        waitingTime = 3.0f;
        endtimer = 0.0f;
        endFadeOut = 7.0f;
        buttonClicked = false;
        onM = false;
        
        //maplastpos = new Vector3(0f, 52f, -31f);
        //maincam.transform.localPosition = maplastpos;
    }

    void Awake()
    {
        //person1 = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (startWarp) // P입력 시 메뉴화면.
        {
            buttonClicked = true;
            FadeOutUi.SetActive(true);
            startWarp = false; // 한번만 돌아갈 수 있도록 일단 설정해놓은것임
        }
        */

        if (buttonClicked)
        {
            timer += Time.deltaTime;
            endtimer += Time.deltaTime;
            Debug.Log("애니메이션시작" + onM);

            if (timer > waitingTime)
            {
                //onM = false;
                if (buildingText.Equals("낙산관"))
                {
                    Debug.Log("낙산관 이동");
                    person1.transform.position = new Vector3(211.66f, 0.0f, 106.58f);          
                    onM = true;
                }
                else if (buildingText.Equals("인성관 창의관"))
                {
                    Debug.Log("인성관 창의관 이동");
                    person1.transform.localPosition = new Vector3(207.33f, 0.0f, 97.65f);
                    Debug.Log(person1.transform.position);
                    onM = true;
                }
                else if (buildingText.Equals("미래관"))
                {
                    Debug.Log("미래관 이동");
                    person1.transform.localPosition = new Vector3(194.14f, 0.0f, 120.82f);
                    Debug.Log(person1.transform.position);
                    onM = true;
                }
                else if (buildingText.Equals("우촌관"))
                {
                    Debug.Log("우촌관 이동");
                    person1.transform.localPosition = new Vector3(184.18f, 0.0f, 177.38f);
                    Debug.Log(person1.transform.position);
                    onM = true;
                }
                else if (buildingText.Equals("상상관"))
                {
                    Debug.Log("상상관 이동");
                    person1.transform.localPosition = new Vector3(97.71f, 0.6f, 155.56f);
                    Debug.Log(person1.transform.position);
                    onM = true;
                }
                else if (buildingText.Equals("학송관"))
                {
                    Debug.Log("학송관 이동");
                    person1.transform.localPosition = new Vector3(70.33f, 0.0f, 210.62f);
                    Debug.Log(person1.transform.position);
                    onM = true;
                }
                else if (buildingText.Equals("탐구관"))
                {
                    Debug.Log("탐구관 이동");
                    person1.transform.localPosition = new Vector3(35.96f, 0.0f, 230.54f);
                    Debug.Log(person1.transform.position);
                    onM = true;
                }
                else if (buildingText.Equals("학군단"))
                {
                    Debug.Log("학군단 이동");
                    person1.transform.localPosition = new Vector3(20.82f, 0.0f, 217.2f);
                    Debug.Log(person1.transform.position);
                    onM = true;
                }
                else if (buildingText.Equals("연구관"))
                {
                    Debug.Log("연구관 이동");
                    person1.transform.localPosition = new Vector3(76.98f, 7.0f, 103.49f);
                    Debug.Log(person1.transform.position);
                    onM = true;
                }
                else if (buildingText.Equals("지선관"))
                {
                    Debug.Log("지선관이동");
                    person1.transform.localPosition = new Vector3(71.27f, 7.0f, 99.43f);
                    Debug.Log(person1.transform.position);
                    onM = true;
                }
                else if (buildingText.Equals("공학관"))
                {
                    Debug.Log("공학관 이동");
                    person1.transform.localPosition = new Vector3(55.8f, 9.0f, 43.55f);
                    Debug.Log(person1.transform.position);
                    onM = true;
                }
                else if (buildingText.Equals("상상빌리지"))
                {
                    Debug.Log("상상관빌리지 이동");
                    person1.transform.localPosition = new Vector3(62.66f, 9.0f, 26.14f);
                    Debug.Log(person1.transform.position);
                    onM = true;
                }
                else if (buildingText.Equals("진리관"))
                {
                    Debug.Log("진리관 이동");
                    person1.transform.localPosition = new Vector3(96.84f, 0.0f, 185.86f);
                    Debug.Log(person1.transform.position);
                    StartUI.SetActive(false);
                    onM = true;
                }
                else if (buildingText.Equals("후문"))
                {
                    Debug.Log("후문 이동");
                    person1.transform.localPosition = new Vector3(160.91f, 21.0f, 5.18f);
                    Debug.Log(person1.transform.position);
                    StartUI.SetActive(false);
                    onM = true;
                }
                else if (buildingText.Equals("정문"))
                {
                    Debug.Log("정문 이동");
                    person1.transform.localPosition = new Vector3(218.85f, 0.0f,110.61f);
                    Debug.Log(person1.transform.position);
                    StartUI.SetActive(false);
                    onM = true;
                }
                else
                {
                    Debug.Log("이동안됨");
                }
                //changePosition();
                //Action
                timer = 0; 
                waitingTime = 10.0f;
                Debug.Log(person1.transform.position);
                Debug.Log(person1.transform.localPosition);
            }

            if (endtimer > endFadeOut)
            {
                FadeOutUi.SetActive(false);
                FadeOutUi2.SetActive(false);
                buttonClicked = false;
                timer = 0;
                endtimer = 0;
                waitingTime = 3.0f;
                Debug.Log("애니메이션끝" +onM);
                onM = false;
            }
        }


        /*
        if(Time.time > nextTime)
        {
            nextTime = Time.time + TimeLeft.Left;
            changePosition();
        }
        */
    }

    public void ClickStart1()
    {
        buttonClicked = true;
        buildingText = "정문";
        Debug.Log("정문이동");
        //StartUI.SetActive(false);
        FadeOutUi2.SetActive(true);
    }

    public void ClickStart2()
    {
        buttonClicked = true;
        buildingText = "후문";
        Debug.Log("후문이동");
        //StartUI.SetActive(false);
        FadeOutUi2.SetActive(true);
    }

    public void SetVector(string bilding)
    {
        buttonClicked = false;
        timer = 0;
        endtimer = 0;
        waitingTime = 3.0f;
        buildingText = bilding;
        Debug.Log("워프 스크립트 실행됨");

        //Vector3 maplastpos = new Vector3(0.0f, 52.0f, -31.0f);
        //Playerposition.position = maplastpos;

        //person1.transform.position = new Vector3(0.0f, 0.0f, 0.0f); // 좌표 설정

        //person1.localEulerAngles = new Vector3(0.0f, 180.0f, 0.0f); // rotation설정.
        //buttonClicked = false;
        //Replace person1.transform.Position.Set(0.0f, 0.0f, 0.0f);
        //Debug.Log("이동");

        buttonClicked = true;
        FadeOutUi.SetActive(true);
    }


    public void changePosition()
    {
        //person1.transform.position = Main_Test_1; // 좌표 설정
        //ebug.Log("이동");
    }



    public void onClickButton()
    {
        //if문으로 버튼 구분, position세팅?
        buttonClicked = true;
    }

}
