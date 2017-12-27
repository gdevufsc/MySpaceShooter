using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStuff : MonoBehaviour {

    //O é o vetor de Objetos a serem spawnados;
    GameObject[] O;
    //ob armazena os objetozinhos clonados
    GameObject ob;

    //t é o tempo entre spawns
    float t;

    //min e max são os limites da tela
    float min, max;

    // é a posição em y para o spawn
    float y;

    //v é o vetor velocidade para os objetos spawnados
    Vector2 v;

    void Start () {
        //Preenche o vetor O encontrando objetos na cena com a tag Respawn
        O = GameObject.FindGameObjectsWithTag("Respawn");
        /// testar O
        ///print(O[0]);
        ///print(O[1]);
        ///print(O[2]);
        ///print(O[3]);

        t = 2f; 

        min = -3.5f;
        max = 3.5f;

        y = transform.position.y;

        v = new Vector2(0, -3);

        InvokeRepeating("SpawnFunction", 2f, t);        
    }
	
    void SpawnFunction ()
    {

        //define x aleatoriamente
        float x = Random.Range(min, max);

        // p é o vetor posição para instanciar o objeto
        Vector3 p = new Vector3(x, y, 0);

        //i identificará qual elemento do vetor será instanciado. É definido aleatoriamente
        int i = Random.Range(0, 3);

        //instancia objeto do vetor e armazena em ab, com posição p e rotação zerada
        ob = Instantiate(O[i], p, Quaternion.Euler(Vector3.zero));

        //atribui velocidade v ao objeto ob instanciado
        ob.GetComponent<Rigidbody2D>().velocity = v;

        //destroi ob em 5 segundos para que não fique pesando na memoria, depois de ter saído da tela.
        Destroy(ob, 5);
    }
	
	void Update () {
	    
	}
}
