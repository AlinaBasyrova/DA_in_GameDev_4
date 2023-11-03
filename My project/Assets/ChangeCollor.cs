using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeCollor : MonoBehaviour
{
    [SerializeField] private Material _whiteMaterial;
    [SerializeField] private Material _darkMaterial;


    private void OnCollisionEnter(Collision collision)
    {
        var scene = SceneManager.GetActiveScene().name;

        if (collision.gameObject.tag != "Floor")
        {
            if (scene == "ANDScene")
                ANDScene(collision);
            if (scene == "ORScene")
                ORScene(collision);
            if (scene == "NANDScene")
                NANDScene(collision);
            if (scene == "XORScene")
                XORScene(collision);

            Destroy(collision.gameObject);
        }
    }

    private void ORScene(Collision collision)
    {
            if (collision.gameObject.tag != "Black")
            {
                GetComponent<MeshRenderer>().material = _whiteMaterial;
            }
    }
        private void ANDScene(Collision collision)
    {
            if (collision.gameObject.tag == "White" && gameObject.tag == "White")
            {
                GetComponent<MeshRenderer>().material = _whiteMaterial;
            }
            else 
                GetComponent<MeshRenderer>().material = _darkMaterial;

    }

            private void NANDScene(Collision collision)
    {
            if (collision.gameObject.tag == "White" && gameObject.tag == "White")
            {
                GetComponent<MeshRenderer>().material = _darkMaterial;
            }
            else 
                GetComponent<MeshRenderer>().material = _whiteMaterial;

    }

            private void XORScene(Collision collision)
    {
            if (collision.gameObject.tag != gameObject.tag)
            {
                GetComponent<MeshRenderer>().material = _whiteMaterial;
            }
            else 
                GetComponent<MeshRenderer>().material = _darkMaterial;

    }

}