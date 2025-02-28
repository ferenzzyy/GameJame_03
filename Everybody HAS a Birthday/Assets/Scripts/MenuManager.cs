using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject[] menus;
    private bool _isPaused;
    // Start is called before the first frame update
    void Start()
    {
        CheckForScene();
    }

    // Update is called once per frame
    void Update()
    {
        //if (_isPaused)
        //{
        //    PauseGame();
        //}

        //CheckForScene();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!_isPaused)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
        
    }

    void CheckForScene()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            menus[0].SetActive(true);
            menus[1].SetActive(false);
            menus[2].SetActive(false);
        }
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            menus[0].SetActive(false);
            menus[1].SetActive(false);
            menus[2].SetActive(false);
            if (menus[3] != null)
            {
                menus[3].SetActive(true);
            }
        }
    }

 

    private void PauseGame()
    {
        _isPaused = true;
        Time.timeScale = 0f;
        menus[0].SetActive(false);
        menus[1].SetActive(true);
        menus[2].SetActive(false);

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            menus[3].SetActive(false);
        }
    }

    public void StartButton()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(0).name);

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

        if (_isPaused)
        {
            menus[0].SetActive(false);
            menus[1].SetActive(true);
            menus[2].SetActive(false);
        }


    }

    public void ResumeGame()
    {
        _isPaused = false;
        Time.timeScale = 1f;
        menus[0].SetActive(false);
        menus[1].SetActive(false);
        menus[2].SetActive(false);

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            menus[3].SetActive(true);
        }
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(0).name);

    }
}
