using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlatformPrefab : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public int rotationAngle = 90;
    public Vector3 size = new(5, 1, 5);

    void Start()
    {
        GeneratePlatform();
    }

    void Update()
    {
        RotatePlatform();
    }

    void GeneratePlatform()
    {
        GameObject platform = new("Platform");

        // Ajouter et configurer MeshRenderer
        MeshRenderer meshRenderer = platform.AddComponent<MeshRenderer>();
        meshRenderer.sharedMaterial = new Material(Shader.Find("Standard"));

        // Ajouter et configurer MeshFilter
        MeshFilter meshFilter = platform.AddComponent<MeshFilter>();
        meshFilter.mesh = CreateMesh();

        // Ajouter et configurer BoxCollider
        BoxCollider boxCollider = platform.AddComponent<BoxCollider>();
        boxCollider.size = size;
    }

    Mesh CreateMesh()
    {
        Mesh mesh = new()
        {
            // Créer un rectangle (ou cube)
            vertices = new Vector3[] {
            new(-size.x/2, -size.y/2, size.z/2),
            new(size.x/2, -size.y/2, size.z/2),
            new(size.x/2, -size.y/2, -size.z/2),
            new(-size.x/2, -size.y/2, -size.z/2),
            new(-size.x/2, size.y/2, size.z/2),
            new(size.x/2, size.y/2, size.z/2),
            new(size.x/2, size.y/2, -size.z/2),
            new(-size.x/2, size.y/2, -size.z/2)
        },

            triangles = new int[] {
            // Bas
            0, 2, 1, 0, 3, 2,
            // Haut
            4, 5, 6, 4, 6, 7,
            // Avant
            4, 1, 5, 4, 0, 1,
            // Arrière
            3, 6, 2, 3, 7, 6,
            // Gauche
            0, 7, 3, 0, 4, 7,
            // Droite
            1, 6, 5, 1, 2, 6
        }
        };

        mesh.RecalculateNormals();

        return mesh;
    }

    public void RotatePlatform()
    {
        float horizontalRotation = rotationAngle * rotationSpeed * Time.deltaTime;
        float verticalRotation = rotationAngle * rotationSpeed * Time.deltaTime;
        transform.Rotate(verticalRotation, 0f, -horizontalRotation, Space.World);
    }
}
