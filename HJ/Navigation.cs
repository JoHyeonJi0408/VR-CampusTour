using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour
{
    //[SerializeField] private GameObject SoundObj;

    Rigidbody myRigid;
    NavMeshAgent agent;
    public Transform start; // 시작 위치.
    public Transform destination; // 목적지 위치.
    public GameObject navi; // 목적지까지 움직여 줄 빈 GameObject.
    public GameObject player; // 움직이는 player.

    private float TimeLeft = 1.2f; // 0.5초 마다.
    private float nextTime = 0.0f;
    private int count = 0;

    public static bool navigation_start = false;
    public static bool navigation_enabled = false;

    

    //public AudioSource audio;
    public AudioClip sound;

    void MakeBox() // GameObject의 위치를 받아서 큐브 생성.
    {
        // 시작과 목적지 위치사이 거리 간격마다 박스 생성.
        Vector3 wayPoint = new Vector3();
        Vector3 y_wayPoint = new Vector3();
        Vector3 y_destiPoint = new Vector3();
        wayPoint = navi.transform.position; // navi위치 저장.
        y_wayPoint = navi.transform.position; // navi위치 저장.
        y_destiPoint = destination.position;
        wayPoint.y = wayPoint.y + 0.5F; // box y값.
        float navi_distance = Vector3.Distance(start.position, navi.transform.position); // 현재 navi위치 거리.
        float desti_distance = Vector3.Distance(start.position, destination.position); // 목적지 위치 거리.
        float player_distance = Vector3.Distance(player.transform.position, destination.position); // player위치와 목적지 거리.
        //Debug.Log("네비 거리 : " + navi_distance + "최종 목적지 : " + desti_distance);
        if (navi_distance <= desti_distance - 1) // 최종 목적지보다 거리가 작을 경우만 Cube 생성 (소수점때문에 -1).
        {
            count++;
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            cube.transform.position = wayPoint;
            cube.transform.localScale = new Vector3(0.5F, 0.5F, 0.5F); //크기.
            cube.transform.rotation = Quaternion.Euler(0, 0, 90); //회전.
            cube.name = "NaviCube" + count;
            cube.tag = "Finish"; // tag를 "Finish"로!.
            cube.GetComponent<MeshRenderer>().material.color = new Color(200 / 255f, 255 / 255f, 255 / 255f); // 컬러
            // meterial
            //cube.GetComponent<MeshRenderer>().material = Resources.Load("test") as Material;
            cube.GetComponent<Collider>().isTrigger = true; // 충돌 처리를 위해.
        }
        else if (y_wayPoint.y != y_destiPoint.y)
        {
            count++;
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            cube.transform.position = wayPoint;
            cube.transform.localScale = new Vector3(0.5F, 0.5F, 0.5F); //크기.
            cube.transform.rotation = Quaternion.Euler(0, 0, 90); //회전.
            cube.name = "NaviCube" + count;
            cube.tag = "Finish"; // tag를 "Finish"로!.
            cube.GetComponent<MeshRenderer>().material.color = new Color(200 / 255f, 255 / 255f, 255 / 255f); // 컬러
            // meterial
            //cube.GetComponent<MeshRenderer>().material = Resources.Load("test") as Material;
            cube.GetComponent<Collider>().isTrigger = true; // 충돌 처리를 위해.
        }
        else
        {
            //Debug.Log(agent.enabled);
            agent.enabled = false;
            //SoundObj.SetActive(false);
        }

        // player가 목적지에 도착할 때.
        //Debug.Log(player_distance);
        if (player_distance < 5)
        {
            //Destroy(GameObject.Find("destiCube"));
            GameObject[] tempobj = GameObject.FindGameObjectsWithTag("Finish");
            foreach (GameObject ob in tempobj)
            {
                Destroy(ob);
            }

            agent.enabled = false;
            //SoundObj.SetActive(false);
        }
    }

    // Start is called before the first frame update.
    void Start()
    {
        /*
        if (navigation_start == true)
        {
            // start위치 player위치로 초기화.
            start.position = player.transform.position;
            // navi위치 start로 초기화.
            navi.transform.position = start.position;
            Vector3 naviPoint = new Vector3();
            naviPoint = navi.transform.position; // navi위치 저장.
            naviPoint.y = naviPoint.y + 1; // 캡슐이기때문에 y값 +1.
        }
        */
        myRigid = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        GetComponent<AudioSource>().clip = sound;
        GetComponent<AudioSource>().Play();
        agent.enabled = false;
        //SoundObj.SetActive(false);
    }

    // Update is called once per frame.
    void Update()
    {
        //Debug.Log(agent.enabled);
        if (navigation_enabled == true)
        {
            agent.enabled = true;
            //SoundObj.SetActive(false);
        }
        //Debug.Log("Navigation 스크립트 도는 중");
        //Debug.Log("네비 위치 : " + navi.transform.position + "플레이어 위치 : " + player.transform.position);
        if (navigation_start == true)
        {
            //Debug.Log("Navigation 기능");
            if (agent)
            {
                //Debug.Log("목적지: " + destination.position);
                agent.SetDestination(destination.position); // 네비게이션 시작.
                
                if (Time.time > nextTime) // TimeLeft초 마다 실행.
                {
                    nextTime = Time.time + TimeLeft;
                    MakeBox();
                }
                // _agent.enabled = false; 동작 멈춤.
            }
            else
            {
                //Debug.Log("Navigation Error");
            }
        }
    }
}

/*
1. agent = GetComponent<NavMeshAgent>(); 부분을 다른 스크립트에서
2. 스크립트 실행 (유니티 시작시 실행 중)
*/