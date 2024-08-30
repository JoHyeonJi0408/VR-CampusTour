using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Title : MonoBehaviour
{
    int index = 0;
    public int totalLevels = 3;
    public float yOffset = 1f;
    [SerializeField] Animator animator;
 
    //[SerializeField] AnimatorFunctions animatorFunctions;

    public string startscene = "Scenes2"; // 이동할 씬 이름
    void Start()
    {
        int index = 0;
    }

    void Update() {
        

        if(Input.GetKeyDown(KeyCode.DownArrow)) // 화면 움직이는거 설정 
        {
            index++;
            if (index == totalLevels) index = index % 3;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (index == 0) index = 2;
            else index--;
        }

        if (Input.GetKeyDown(KeyCode.Return)) // 엔터 누르면 실행
        {
            if(index == 0){
                Debug.Log("학교탐방 시작");
                SceneManager.LoadScene(startscene);             
            }
            if (index == 1)
            {
                Debug.Log("미니게임 시작");
                //SceneManager.LoadScene();
            }
            if (index == 2)
            {
                Debug.Log("게임종료");
                Application.Quit();

            }
        }

    }


    /*
    public void ClickStart()
    {
        Debug.Log("로딩");
        SceneManager.LoadScene(startscene);
    }

    public void Clickminigame()
    {
        Debug.Log("로드");
    }

    public void ClickExit()
    {
        Debug.Log("게임종료");
        Application.Quit();
    }
    */

}
