using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransferManager : MonoBehaviour
{
    public string targetSceneName = "AnotherScene"; //nome da cena alvo
    public KeyCode transferkey = KeyCode.T; // Tecla para transferir o objeto


    private void Update()
    {
        if (Input.GetKeyDown(transferkey))
        {
            MoveObjectToAnotherScene();
        }


        void MoveObjectToAnotherScene()
        {
            Scene targetScene = SceneManager.GetSceneByName(targetSceneName);
            if(targetScene.IsValid()) {
                SceneManager.MoveGameObjectToScene(gameObject, targetScene);
                Debug.Log($"Objeto { gameObject.name} movido para a cena { targetSceneName}. ");
            
            
            
            }
            else
            {
                Debug.LogError($"cena {targetScene} não encontrada!");
            }



        }

    }






}
