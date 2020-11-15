using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag1;
    [SerializeField] string triggeringTag2;
 
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag1 && enabled) {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
        if (other.tag == triggeringTag2 && enabled)
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }


}
