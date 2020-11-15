using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class que_2_2_LimitDestroy : MonoBehaviour
{
    [SerializeField] string BottomTag;
    [SerializeField] string Toptag;

    void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (this.tag == BottomTag && screenPosition.y < 0)
            Destroy(this.gameObject);
        if (this.tag == Toptag && screenPosition.y > Screen.height)
            Destroy(this.gameObject);
    }
}
