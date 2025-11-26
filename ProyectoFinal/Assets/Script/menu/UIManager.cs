using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _opcionesPlay;
    [SerializeField] private GameObject _opcionesPause;
    [SerializeField] private GameObject _menuPause;
    private bool _isMenu=  true ;
    private bool _isOpcionesPause = false;
    private bool _isOpcionesPlay =false;
    private bool _isMenuPause =false;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {

    }


    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex > 0)
        {
            if (Input.GetKey(KeyCode.Escape)) 
            {
                menuPause();
            }
        }
        
    }

    public void menuPlay()
    {
        _isMenu = !_isMenu  ;
        _menu.SetActive(_isMenu);
    }

    public void menuPause()
    {
        _isMenuPause = !_isMenuPause;
        _menuPause.SetActive(_isMenuPause);
    
    }

    public void opcionesPlay()
    {
        _isOpcionesPlay= !_isOpcionesPlay;
        _opcionesPlay.SetActive(_isOpcionesPlay);
    }

    public void opcionesPause() 
    { 
        _isOpcionesPause= !_isOpcionesPause;
        _opcionesPause.SetActive(_isOpcionesPause);
    
    }

    public void nextLevel() {

        SceneManager.LoadScene(1);
    }

}
