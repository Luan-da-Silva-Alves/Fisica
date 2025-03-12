using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Se o player tocar na box collider, vai para a tela de derrota
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("TelaDerrota");
        }
    }
}


