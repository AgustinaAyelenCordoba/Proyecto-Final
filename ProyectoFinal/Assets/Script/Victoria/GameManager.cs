using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private int puntaje;
    [SerializeField] TMPro.TMP_Text _textMeshPro;
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

}
