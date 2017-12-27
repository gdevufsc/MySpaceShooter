using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroColisao : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject, 0);
        Destroy(this.gameObject, 0);
    }

}
