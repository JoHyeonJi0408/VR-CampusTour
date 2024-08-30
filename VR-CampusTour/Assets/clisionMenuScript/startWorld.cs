using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class startWorld : MonoBehaviour
{

    public Button po1Btn;

    void Start()
    {
        po1Btn.Select();
    }

    void Awake()
    {
        po1Btn.Select();
    }
    void onClickButton()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}
