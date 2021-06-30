using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class PlayerControl : MonoBehaviour {

    public static int[] vectorSlotPlayer = new int[6] { 0, 1, 2, 3, 4, 5 };
    public float speed = 2f; //velocidad de movimiento
    private Rigidbody2D m_rig;

    public GameObject flecha;

    ID_Slot num = new ID_Slot();
    
    // Start is called before the first frame update
    void Start() {
        m_rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.R)){
            Debug.Log("me muevo :V"); 

            for (int i = 0; vectorSlotPlayer[i] <= 6; i++) {
                Debug.Log("Entre al For");
                if (vectorSlotPlayer[i] == num.IdSlot) {
                    Debug.Log("Entre al primer IF");
                    if (flecha == GameObject.FindGameObjectWithTag("FlechaUp")) {
                        Debug.Log("Entre al UP");
                        m_rig.velocity = new Vector2(m_rig.velocity.x, speed);
                     }
                    if (flecha == GameObject.FindGameObjectWithTag("FlechaDown")) {
                        Debug.Log("Entre al DOWN");
                        m_rig.velocity = new Vector2(m_rig.velocity.x, speed*=-1);
                     }
                    if (flecha == GameObject.FindGameObjectWithTag("FlechaRight")){
                        Debug.Log("Entre al DERECHA");
                        m_rig.velocity = new Vector2(speed, m_rig.velocity.y);
                     }
                    if (flecha == GameObject.FindGameObjectWithTag("FlechaLeft")) {
                        Debug.Log("Entre al IZQUIERDA");
                        m_rig.velocity = new Vector2(speed *= -1, m_rig.velocity.y);
                    }
                    else {
                        Debug.Log("Entre al ELSE");
                        speed = 0;
                    }
                }

            }
            Debug.Log("SALI DEL For");
        }
    }

   
}
