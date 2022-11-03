using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public RectTransform uiGroup;

    PlayerController enterPlayer;

    // Start is called before the first frame update
    public void Enter(PlayerController player) // 입장
    {
        enterPlayer = player; // 플레이어 정보 저장
        uiGroup.anchoredPosition = Vector3.zero; // ui화면 중앙으로
    }

    // Update is called once per frame
    public void Exit() // 나가기
    {
        uiGroup.anchoredPosition = Vector3.down * 1000; 
    }
}
