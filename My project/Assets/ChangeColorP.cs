
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeCollorP : MonoBehaviour
{
    [SerializeField] private Material _whiteMaterial;
    [SerializeField] private Material _darkMaterial;
    [SerializeField]
    Perceptron perceptron;
    


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Floor")
        {
            var scene = SceneManager.GetActiveScene().name;
            double a = collision.gameObject.tag == "White" ? 1 : 0;
            double b = gameObject.tag == "White" ? 1 : 0;

            GetComponent<MeshRenderer>().material = 
            perceptron.CalcOutput(a, b) == 1 ? _whiteMaterial : _darkMaterial;
            Destroy(collision.gameObject);
        }

    }
}


