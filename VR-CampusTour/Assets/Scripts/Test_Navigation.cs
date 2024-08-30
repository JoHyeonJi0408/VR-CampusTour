using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// navigation의 위치를 frame마다 받아서 cube 생성 
public class Test_Navigation : MonoBehaviour
{
    Rigidbody myRigid;
    NavMeshAgent agent;
    [SerializeField] private Transform start; // 시작 위치
    [SerializeField] private Transform destination; // 목적지 위치
    public GameObject navi; // 목적지까지 움직여 줄 빈 GameObject
    public GameObject player; // 움직이는 player

    private float TimeLeft = 0.5f; // 0.5초 마다
    private float nextTime = 0.0f;
    private int count = 0;
    void MakeBox() // GameObject의 위치를 받아서 큐브 생성
    {
        Vector3[] wayPoints = new Vector3[1];
        wayPoints[0] = navi.transform.position; // navi위치 저장
        float navi_distance = Vector3.Distance(start.position, navi.transform.position); // 현재 navi위치 거리
        float desti_distance = Vector3.Distance(start.position, destination.position); // 목적지 위치 거리
        if (navi_distance <= desti_distance) // 최종 목적지보다 거리가 작을 경우만 Cube 생성
        {
            count++;
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = wayPoints[0];
            //cube.transform.localScale = new Vector3(0.5F, 0.5F, 0.5F); 크기
            cube.name = "Cube" + count; // Cube1, Cube2 ... 생성
            cube.tag = "Finish"; // tag를 "Finish"로!
            cube.GetComponent<Collider>().isTrigger = true; // 충돌 처리를 위해
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Finish")
        {
            Destroy(col.gameObject);
        }
    }

    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        // navi위치 start로 초기화
        navi.transform.position = start.position;
    }

    void Update()
    {
       
        agent.SetDestination(destination.position); // 네비게이션 시작
        if (Time.time > nextTime) // TimeLeft초 마다 실행
        {
            nextTime = Time.time + TimeLeft;
            MakeBox();
        }
    }
}