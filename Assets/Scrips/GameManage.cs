using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    private bool m_ReadyForInput;
    public Player m_Player;

    private void Start() {
        
    }


    void Update(){
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        input.Normalize();

        if(input.sqrMagnitude > 0.5) {
            if (m_ReadyForInput) {
                m_ReadyForInput = false;
                m_Player.Move(input);
                //m_NextButton.SetActive(IsLevelComplete());
            }
        }
        else {
            m_ReadyForInput = true;
        }
    }
}
