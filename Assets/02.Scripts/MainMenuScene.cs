using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScene : MonoBehaviour
{
    public GameObject popUpProfile;
    public GameObject popUpOption; //일반 옵션 
    public GameObject PopupRoomMaker; // 11. TogetherModeList
    public GameObject PopupGameOption; //게임 옵션 (뒤로가기 있음)

    public void OnClickProfileBtn()
    {
        // 만약에 popUpProfile이 활성화가 되어있으면 비활성화
        if(popUpProfile.activeSelf == true)
        {
            popUpProfile.SetActive(false);
        }
        // 그렇지 않으면 활성화
        else
        {
            popUpProfile.SetActive(true);
        }
        
    }
    
        //위에 네줄을 한방에 처리하는 문구
        public void OnClickOptionBtn()
    {
        popUpOption.SetActive(!popUpOption.activeSelf);
    }

        public void OnClickRoomMakerBtn()
    {
        PopupRoomMaker.SetActive(!PopupRoomMaker.activeSelf);
    }

        public void OnClickGameOptionBtn()
    {
        PopupGameOption.SetActive(!PopupGameOption.activeSelf);
    }
}
