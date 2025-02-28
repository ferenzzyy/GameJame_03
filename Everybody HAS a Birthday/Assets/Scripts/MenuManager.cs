using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject[] menus;
    // Start is called before the first frame update
    void Start()
    {
        CheckForScene();
    }

    // Update is called once per frame
    void Update()
    {
        //CheckForScene();
    }

    void CheckForScene()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            menus[0].SetActive(true);
            menus[1].SetActive(false);
            menus[2].SetActive(false);
        }
    }


    public void StartButton()
    {
        print("Game Start");
        menus[0].SetActive(false);
        menus[1].SetActive(false);
        menus[2].SetActive(false);
    }

    public void OptionsButton()
    {
        print("options");
        menus[0].SetActive(false);
        menus[1].SetActive(false);
        menus[2].SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
        print("Quit Game!");
    }

    public void BackButton()
    {
        menus[0].SetActive(true);
        menus[1].SetActive(false);
        menus[2].SetActive(false);
    }

    public void ResumeGame()
    {

    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(1).name);
    }
}
