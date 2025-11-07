using System.Collections;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] private Transform[] _Pocision;
    [SerializeField] private float _Velocidad = 5f;
    [SerializeField] private float _EsperaEnCadaPunto = 0.5f;

    private int _indiceActual = 0;
    private bool _avanzando = true;

    void Start()
    {
        StartCoroutine(MoverEntrePuntos());
    }

    private IEnumerator MoverEntrePuntos()
    {
        while (true)
        {
            Vector3 destino = _Pocision[_indiceActual].position;
            while (Vector3.Distance(transform.position, destino) > 0.1f)
            {
                Vector3 direccion = (destino - transform.position).normalized;
                transform.Translate(direccion * _Velocidad * Time.deltaTime);
                yield return null;
            }

            // Asegura que se posiciona exactamente en el punto
            transform.position = destino;

            // Espera un momento en el punto
            yield return new WaitForSeconds(_EsperaEnCadaPunto);

            // Cambia el índice según la dirección
            if (_avanzando)
            {
                _indiceActual++;
                if (_indiceActual >= _Pocision.Length)
                {
                    _indiceActual = _Pocision.Length - 2;
                    _avanzando = false;
                }
            }
            else
            {
                _indiceActual--;
                if (_indiceActual < 0)
                {
                    _indiceActual = 1;
                    _avanzando = true;
                }
            }
        }
    }
}
