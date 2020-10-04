using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DDArticles : MonoBehaviour
{

    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            SceneManager.LoadScene("Articles");
        }
        if (val == 1)
        {
            SceneManager.LoadScene("O3Article");
        }
        if (val == 2)
        {
            SceneManager.LoadScene("ADArticle");
        }
    }


}

