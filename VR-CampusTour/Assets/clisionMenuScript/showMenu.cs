using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//버튼 이벤트 모아놓은 스크립트임! 모든 건물에 다 넣고 버튼에게 각각맞는 함수를 넣어주어야함!
//showInside 스크립트에서 각각 맞는 이미지를 보여줄것임.
public class showMenu : MonoBehaviour
{
    public static bool showInSide = false;

    public ShowInside showInside;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //공학관
    public void onClickHS() // 공학관 학사버튼
    {
        showInside.showImage("공학관학과사무실");
    }

    public void onClickHG() // 공학관 휴계실
    {
        showInside.showImage("공학관휴계실");
    }

    public void onClickOJ() // 공학관실습실
    {
        showInside.showImage("공학관실습실");
    }

    //탐구관
    public void onClickTM() // 탐구관 매점
    {
        showInside.showImage("탐구관매점");
    }

    public void onClickTF() // 탐구관 실습실/프린터실
    {
        showInside.showImage("탐구관실습실/프린터실");
    }

    //학송관 뺄까??
    public void onClickHSS() // 학송관 실습실
    {
        showInside.showImage("학송관실습실");
    }

    public void onClickHSG() // 학송관 기자재실
    {
        showInside.showImage("학송관기자재실");
    }

    //연구관
    public void onClickYGC() // 연구관 카페
    {
        showInside.showImage("연구관카페");
    }

    public void onClickYGJ() // 연구관 전시실
    {
        showInside.showImage("연구관전시실");
    }

    //창의관
    public void onClickCHM() // 창의관 매점
    {
        showInside.showImage("창의관매점");
    }

    public void onClickCHF() // 창의관 학식당
    {
        showInside.showImage("창의관학식당");
    }

    //미래관
    public void onClickMRC() // 미래관 카페
    {
        showInside.showImage("미래관카페");
    }
    public void onClickMRF() // 미래관 프린터실
    {
        showInside.showImage("미래관프린터실");
    }
    public void onClickMRH() // 미래관 학생정보관
    {
        showInside.showImage("미래관학생정보관");
    }
    public void onClickMRDLC() // 미래관 DLC
    {
        showInside.showImage("미래관DLC");
    }

    //상상관
    public void onClickSSF() // 상상관 밀가옥
    {
        showInside.showImage("상상관밀가옥");
    }
    public void onClickSSC() // 상상관 팥고당
    {
        showInside.showImage("상상관팥고당");
    }
    public void onClickSSWoman() // 상상관 여학생휴게실
    {
        showInside.showImage("상상관여학생휴게실");
    }
    public void onClickSSB() // 상상관 보건실
    {
        showInside.showImage("상상관보건실");
    }
    //우촌관
    public void onClickWChon() // 우촌관 학사지원
    {
        showInside.showImage("우촌관학사지원");
    }
    //낙산관
    public void onClickND() // 낙산관 대강당
    {
        showInside.showImage("낙산관대강당");
    }

}
