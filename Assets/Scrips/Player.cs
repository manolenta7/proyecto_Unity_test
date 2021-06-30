using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
public bool Move(Vector2 direction) {//evita que se mueva diagonalmente
        if (Mathf.Abs(direction.x)<0.5) {//siempre pondra una de las coordenadas en 0
            direction.x = 0;
        }
        else {
            direction.y = 0;
        }

        direction.Normalize(); //hace que x o y sea = 1

        if (Blocked(transform.position,direction)) {
            return false;
        }
        else {
            transform.Translate(direction);
            return true;
        }

    }

bool Blocked(Vector3 position, Vector2 direction) {
        Vector2 newPos = new Vector2(position.x, position.y) + direction;

        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");

        foreach (var box in boxes) {
            if (box.transform.position.x == newPos.x && box.transform.position.y == newPos.y) {
                Box bx = box.GetComponent<Box>();
                if (bx && bx.Move(direction)) {
                    return false;
                }
            }
            else {
                return true;
            }
        }
        return false;
    }


}
