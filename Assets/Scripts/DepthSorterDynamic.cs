using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthSorterDynamic : MonoBehaviour
{
    // Will allow this object to move behind and in front of other objects with a static "DepthSorter"
    void Update()
    {
        GetComponent<SpriteRenderer>().sortingOrder = -Mathf.RoundToInt(10 * GetComponent<Transform>().position.y);
    }
}
