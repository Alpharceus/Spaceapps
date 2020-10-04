using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoBackArticles : MonoBehaviour
{
    public void gotoarticles()
    {
        SceneManager.LoadScene("Articles");
    }

}
