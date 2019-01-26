using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillowManager : MonoBehaviour
{
    [SerializeField] private float TagWaitTime;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(TagWaitTime);
        gameObject.tag = "Pillow";
    }
}
