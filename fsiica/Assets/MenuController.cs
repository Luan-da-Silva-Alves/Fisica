using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    void Update()
    {
        // Verifica se a tecla "Escape" foi pressionada
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
