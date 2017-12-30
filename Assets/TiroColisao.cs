using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroColisao : MonoBehaviour {

    GameObject n;
    GameObject spawnstuff;

    private void Start()
    {
        n = GameObject.FindGameObjectWithTag("Pont");
        spawnstuff = GameObject.FindGameObjectWithTag("Spawner");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject, 0);
        Destroy(this.gameObject, 0);
        n.SendMessage("Somaponto");
        spawnstuff.SendMessage("AumentaDificuldade");
    }
}
