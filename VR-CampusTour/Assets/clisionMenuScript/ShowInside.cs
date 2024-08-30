using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShowInside : MonoBehaviour
{
    [SerializeField] private GameObject go_showInside;

    public Text FloorText;
    public bool showImagePanel = false;
    //public Texture2D myTexture;
    public Sprite sprite;
    public Texture2D texture = null;

    public GameObject imageObj; // 가져올이미지
    public Image myImage; // 셋팅해야함

    //로드할 이미지들 ㅜㅜ
    public Sprite GongHSImage;
    public Sprite GongHGImage;
    public Sprite GongOJImage;

    public Sprite MiRaeCafeImage;
    public Sprite MiRaeDLCImage;
    public Sprite MiRaeFImage;

    public Sprite SangCafeImage;
    public Sprite SangFoodImage;
    public Sprite SangWomanImage;
    public Sprite SangHealthImage;

    public Sprite TamMjImage;
    public Sprite TamSSImage;

    public Sprite YounJSImage;
    public Sprite YounCafeImage;

    public Sprite ChangFoodImage;
    public Sprite ChangMJImage;

    public Sprite WochonImage;

    public Sprite NacksanImage;

    // Start is called before the first frame update
    void Start()
    {
        //myImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void showImage(string inside) // 주요시설 네임을 받아서 그에 맞는 도면 사진을 뿌린다. 
    {
        //공학관
        if (inside.Equals("공학관학과사무실"))
        {
            //이미지 셋팅
            //floor 셋팅
            Debug.Log("공학관학과사무실 도면 이미지 화면");
            //Image = imageObj.GetComponent<Image>().sprite = "GongHS";
            //Image = imageObj.GetComponent<Image>();
            //myImage = GameObject.Find("clisionMenuImage/GongHS.JPG").GetComponent<Image>();
            FloorText.text = "1F";
            //GameObject imageObj = GameObject.FindGameObjectWithTag("GongHS");
            //myImage = GameObject.FindGameObjectWithTag("GongHS").GetComponent<Image>();
            //myTexture = Resources.Load("clisionMenuImage/GongHS.JPG") as Texture2D;

            //sprite = Resources.Load<Sprite>("clisionMenuImage/GongHS.JPG");
            ////imageObj = GameObject.Find("Image");
            //imageObj.GetComponent<Image>().sprite = sprite;

            //texture = Resources.Load("clisionMenuImage/GongHS.JPG") as Texture2D;
            //imageObj.GetComponent<Image>().texture = texture;

            myImage.sprite = GongHSImage;
            FloorText.text = "1F";

            //if (myImage == null)
            //{
            //    //imageObj.sprite = Resources.Load("Icons/a") as Image; // 기본 이미지 설정 
            //    Debug.Log("이미지 로드 에러");
            //}


        }
        else if (inside.Equals("공학관휴계실"))
        {
            Debug.Log("공학관휴계실 도면 이미지 화면");
            myImage.sprite = GongHGImage;
            FloorText.text = "1F";
        }
        else if (inside.Equals("공학관실습실"))
        {
            Debug.Log("공학관실습실 도면 이미지 화면");
            myImage.sprite = GongOJImage;
            FloorText.text = "1F";
        }
        //탐구관
        else if (inside.Equals("탐구관매점"))
        {
            Debug.Log("탐구관매점 도면 이미지 화면");
            myImage.sprite = TamMjImage;
            FloorText.text = "B1F";
        }
        else if (inside.Equals("탐구관실습실/프린터실"))
        {
            Debug.Log("탐구관실습실/프린터실 도면 이미지 화면");
            myImage.sprite = TamSSImage;
            FloorText.text = "2F";
        }
        //학송관
        else if (inside.Equals("학송관실습실"))
        {
            Debug.Log("학송관실습실 도면 이미지 화면");
        }
        else if (inside.Equals("학송관기자재실"))
        {
            Debug.Log("학송관기자재실 도면 이미지 화면");
        }
        //연구관
        else if (inside.Equals("연구관카페"))
        {
            Debug.Log("연구관카페 도면 이미지 화면");
            myImage.sprite = YounCafeImage;
            FloorText.text = "1F";

        }
        else if (inside.Equals("연구관전시실"))
        {
            Debug.Log("연구관전시실 도면 이미지 화면");
            myImage.sprite = YounJSImage;
            FloorText.text = "1F";
        }
        //창의관
        else if (inside.Equals("창의관매점"))
        {
            Debug.Log("창의관매점 도면 이미지 화면");
            myImage.sprite = ChangMJImage;
            FloorText.text = "B1F";

        }
        else if (inside.Equals("창의관학식당"))
        {
            Debug.Log("창의관학식당 도면 이미지 화면");
            myImage.sprite = ChangFoodImage;
            FloorText.text = "B1F";
        }
        //미래관
        else if (inside.Equals("미래관카페"))
        {
            Debug.Log("미래관카페 도면 이미지 화면");
            myImage.sprite = MiRaeCafeImage;
            FloorText.text = "B1F";
        }
        else if (inside.Equals("미래관프린터실"))
        {
            Debug.Log("미래관프린터실 도면 이미지 화면");
            myImage.sprite = MiRaeFImage;
            FloorText.text = "B1F";
        }
        else if (inside.Equals("미래관학생정보관"))
        {
            Debug.Log("미래관학생정보관 도면 이미지 화면");
        }
        else if (inside.Equals("미래관DLC"))
        {
            Debug.Log("미래관DLC 도면 이미지 화면");
            myImage.sprite = MiRaeDLCImage;
            FloorText.text = "B1F";
        }
        //상상관
        else if (inside.Equals("상상관밀가옥"))
        {
            Debug.Log("상상관밀가옥 도면 이미지 화면");
            myImage.sprite = SangFoodImage;
            FloorText.text = "12F";
        }
        else if (inside.Equals("상상관팥고당"))
        {
            Debug.Log("상상관팥고당 도면 이미지 화면");
            myImage.sprite = SangCafeImage;
            FloorText.text = "2F";
        }
        else if (inside.Equals("상상관여학생휴게실"))
        {
            Debug.Log("상상관여학생휴게실 도면 이미지 화면");
            myImage.sprite = SangWomanImage;
            FloorText.text = "2F";
        }
        else if (inside.Equals("상상관보건실"))
        {
            Debug.Log("상상관보건실 도면 이미지 화면");
            myImage.sprite = SangHealthImage;
            FloorText.text = "1F";
        }
        //우촌관
        else if (inside.Equals("우촌관학사지원"))
        {
            Debug.Log("우촌관학사지원 도면 이미지 화면");
            myImage.sprite = WochonImage;
            FloorText.text = "3F";
        }
        //낙산관
        else if (inside.Equals("낙산관대강당"))
        {
            Debug.Log("낙산관대강당 도면 이미지 화면");
            myImage.sprite = NacksanImage;
            FloorText.text = "2F";
        }
        else // 이미지와 함수가 맞지 않을 겨우.
        {
            Debug.Log("이미지의 이름이 잘못 되었음. 건물TriggerZone스크립트, showInside스크립트 확인");
        }

        CallMenu();

        if (myImage == null)
        {
            //imageObj.sprite = Resources.Load("Icons/a") as Image; // 기본 이미지 설정 
            Debug.Log("이미지 로드 에러");
        }

    }

    public void ClickCloseButton()
    {

    }

    public void CallMenu() // 일단 private 에서 .
    {
        go_showInside.SetActive(true);
    }

    public void CloseMenu()
    {
        go_showInside.SetActive(false);
    }
}
