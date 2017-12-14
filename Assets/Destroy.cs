using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private bool isVisible;

    // 可視状態か
    public bool IsVisible
    {
        get { return isVisible; }
    }

    // 可視状態になった時に呼ばれる
    void OnBecameVisible()
    {
        isVisible = true;
    }

    // 不可視状態になった時に呼ばれる
    void OnBecameInvisible()
    {
        isVisible = false;
    }

}