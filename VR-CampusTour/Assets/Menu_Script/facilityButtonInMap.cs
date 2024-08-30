using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class facilityButtonInMap : MonoBehaviour
{

    [SerializeField] private GameObject go_ButtonInMap;
    [SerializeField] private GameObject HacksaUI;
    [SerializeField] private GameObject FoodUI;
    [SerializeField] private GameObject CafeUI;
    [SerializeField] private GameObject PrinterUI;
    [SerializeField] private GameObject HealthUI;

    public Text text ; // 기본 ""
    public string buttonName = "Position2";

    public Button HsButton; // 학사지원팀, 우촌관
    public Button HacsickButton; //학식, 창의관
    public Button CUButton; // 씨유, 상빌
    public Button milButton; // 밀가옥, 상상관 
    public Button Y_cafeButton; // 연구관카페, 연구관
    public Button m_cafeButton; // 미래관카페, 미래관
    public Button patButton; // 팥고당, 상상관
    public Button printer1Button; // 공학관, 공학관
    public Button printer2Button; // 탐구관, 탐구관
    public Button printer3Button; // 미래관, 미래관
    public Button heathButton; // 생활관리실, 상상관
    // navigation
    public UnityEngine.AI.NavMeshAgent agent; // 네비게이션 에이전트.
    public Transform start; // 시작 위치.
    public Transform destination; // 목적지 위치.
    public GameObject navi; // 목적지까지 움직여 줄 빈 GameObject.
    public GameObject player; // 움직이는 player.

    private float TimeLeft = 1.2f;
    private float nextTime = 0.0f;
    private int count = 0;

    public static bool navigation_start = false; // 네비게이션 시작을 위한 변수.

    // Start is called before the first frame update
    void Start()
    {
        HsButton.onClick.AddListener(delegate { onClicked(HsButton); });
        HacsickButton.onClick.AddListener(delegate { onClicked(HacsickButton); });
        CUButton.onClick.AddListener(delegate { onClicked(CUButton); });
        milButton.onClick.AddListener(delegate { onClicked(milButton); });
        Y_cafeButton.onClick.AddListener(delegate { onClicked(Y_cafeButton); });
        m_cafeButton.onClick.AddListener(delegate { onClicked(m_cafeButton); });
        patButton.onClick.AddListener(delegate { onClicked(patButton); });
        printer1Button.onClick.AddListener(delegate { onClicked(printer1Button); });
        printer2Button.onClick.AddListener(delegate { onClicked(printer2Button); });
        printer3Button.onClick.AddListener(delegate { onClicked(printer3Button); });
        heathButton.onClick.AddListener(delegate { onClicked(heathButton); });

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onClicked(Button button)
    {
        go_ButtonInMap.SetActive(false);
        HacksaUI.SetActive(false);
        FoodUI.SetActive(false);
        CafeUI.SetActive(false);
        PrinterUI.SetActive(false);
        HealthUI.SetActive(false);

        text = button.GetComponentInChildren<Text>();
        //if (text != null) { Debug.Log("text: " + text.text); }
        buttonName = text.text;
        //Debug.Log(buttonName);
        //네비함수
        Navigation.navigation_enabled = true;
        Navigation.navigation_start = true;
        // start위치 player위치로 초기화.
        start.transform.position = player.transform.position;
        // navi위치 start로 초기화.
        navi.transform.position = start.transform.position;
        Vector3 naviPoint = new Vector3();
        naviPoint = navi.transform.position;// navi위치 저장.
        naviPoint.y = naviPoint.y + 1;// 캡슐이기때문에 y값 +1
        switch (buttonName)
        {
            case "학식":
                destination.transform.position = new Vector3(183f, 0.0f, 106f);
                break;
            case "미래관" :
            case "미래관카페" :
                destination.transform.position = new Vector3(194.14f, 0.0f, 120.82f);
                break;
            case "학사지원팀":
                destination.transform.position = new Vector3(184.18f, 0.0f, 177.38f);
                break;
            case "생활관리실":
            case "밀가옥":
                destination.transform.position = new Vector3(97.71f, 0.6f, 155.56f);
                break;
            case "팥고당":
                destination.transform.position = new Vector3(100.8f, 5.2796f, 139.43f);
                break;
            case "탐구관":
                destination.transform.position = new Vector3(35.96f, 0.0f, 230.54f);
                break;
            case "연구관카페":
                destination.transform.position = new Vector3(76.98f, 7.0f, 103.49f);
                break;
            case "공학관":
                destination.transform.position = new Vector3(55.8f, 9.0f, 43.55f);
                break;
            /*case "씨유":
                destination.transform.position = new Vector3(62.66f, 9.0f, 26.14f);
                break;*/
            default:
                //Debug.Log("주요 시설 에러");
                break;
        }
        //Debug.Log("주요시설 기능 실행");
    }

}
