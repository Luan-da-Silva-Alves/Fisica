using UnityEngine;
using UnityEngine.SceneManagement;

public class PhysicusSceneLoader : MonoBehaviour
{

    //Exposed to Inspector
    public string physicsSceneName;
    public float physicsSceneTimeScale = 1;
    private PhysicsScene physicsScene;
    private void Start()
    {
       //load the scene to place in a local physics scene
       LoadSceneParameters param =
            new LoadSceneParameters(LoadSceneMode.Additive, LocalPhysicsMode.Physics3D);
        Scene scene = SceneManager.LoadScene(physicsSceneName, param);
        //get the scene physics scene
        physicsScene = scene.GetPhysicsScene();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //Simulate the scene on fixedUpdate
        if(physicsScene != null)
        {
            physicsScene.Simulate(Time.fixedDeltaTime * physicsSceneTimeScale);
        }
    }
}
