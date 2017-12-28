using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//A biblioteca abaixo foi incluida para usar o GetActiveScene e o LoadScene;
//using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    //criando objeto s da classe Scene
    //Scene s;

    //pGOT é uma abreviação de positionGameOverText.
    Vector2 pGOT;

    private void Start()
    {
        //instanciando s, colocando nele a cena atual
        //s = SceneManager.GetActiveScene();

        //pGOT é relativo ao pai, que será o Canvas. .5f,.5f vai representar o meio da tela.
        pGOT = new Vector2(.5f, .5f);
    }

    /// <summary> Teste para o comando LoadScene
    /// private void Update()
    ///{  
    ///    if(Input.GetKey(KeyCode.R))
    ///        SceneManager.LoadScene(s.buildIndex);
    ///}
    /// </summary>


    private void OnCollisionEnter2D()
    {
        //SceneManager.LoadScene(s.buildIndex);
        MakeGameOverText();
        DestroiCoisas();
        //PleaseStopInvoking = true;
    }

    void DestroiCoisas()
    {
        Destroy(GameObject.FindGameObjectWithTag("Player"));
    }
    
    void MakeGameOverText()
    {
        //cria objeto canv e atribui o objeto Canvas que foi taggeado como Canvas
        GameObject canv = GameObject.FindGameObjectWithTag("Canvas");
        //print(canv); //para testar se o canv foi instanciado;

        // instancia prefab da pasta Resources com nome GameOverText
        GameObject c = Instantiate(Resources.Load("GameOverText")) as GameObject;

        //põe o c como filho do canv
        c.transform.SetParent(canv.transform);

        //cria um objeto cRectTransform para poder posicionar o c
        RectTransform cRectTransform = c.GetComponent<RectTransform>();

        //posiciona o c usando a posição pGOT
        cRectTransform.anchoredPosition = pGOT;
    }
}
