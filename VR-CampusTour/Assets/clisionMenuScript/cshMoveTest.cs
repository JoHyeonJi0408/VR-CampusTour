using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshMoveTest : MonoBehaviour
{
    public Transform pos;
    public GameObject target;
    public bool onM;
    // Start is called before the first frame update
    void Start()
    {
        onM = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            target.transform.position = pos.position;
            onM = true;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            onM = false;
        }
    }
}
