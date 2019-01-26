using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGimmick : MonoBehaviour
{
    [SerializeField] float rotateValue = 10.0f;

    private void OnMouseOver()
    {
        float rotate = Input.GetAxis("Mouse ScrollWheel");
        gameObject.transform.Rotate(0, transform.rotation.y + (rotate * rotateValue), 0);
    }
}
