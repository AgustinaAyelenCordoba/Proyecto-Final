using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private int puntaje;
    [SerializeField] private TMPro.TMP_Text _textMeshPro;
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private GameObject _final;
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
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            _final.SetActive(true);

        }
        else
        {
            _final.SetActive(false);
        }

        if (SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 3)
        {
            _gameObject.SetActive(false);
        }
        else
        {
            _gameObject.SetActive(true);
        }
    }

    public void mostrarPuntaje(int incremento) 
    {
        puntaje += incremento;
        _textMeshPro.text = "= " + puntaje.ToString();
        Debug.Log(puntaje ); 
    }

    public void volverMenu() 
    {
        SceneManager.LoadScene(0);
    }


    public void volverJugar() 
    {
        SceneManager.LoadScene(1);

    }

    public void mostrarHud() 
    {
        _gameObject.SetActive(true);
    }

    public void cerrarJuego ()
    {
        Application.Quit();
    }
}
