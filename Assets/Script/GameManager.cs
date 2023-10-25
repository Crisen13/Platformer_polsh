using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int sceneBuildIndex;
    

    public void LoadGame()
    {
        SceneManager.LoadScene("tutorial_level");
        //SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }
}
