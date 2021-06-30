using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public bool Move(Vector2 direction) {
        if (BoxBloqued(transform.position,direction)) {
            return false;
        }
        else {
            transform.Translate(direction);
            return true;
        }
    }

    bool BoxBloqued(Vector3 position, Vector2 direction) { // cajas se bloquean con otras cajas
        Vector2 newPos = new Vector2(position.x, position.y) + direction;
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");

        foreach (var box in boxes) {
            if (box.transform.position.x == newPos.x && box.transform.position.y == newPos.y) {
                Box bx = box.GetComponent<Box>();
                if (bx && bx.Move(direction)) {
                    return false;
                }
                else {
                    return true;
                }
                
            }
        }
        return false;
    }
}
