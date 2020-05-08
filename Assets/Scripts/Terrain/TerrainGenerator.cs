using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;

[RequireComponent(typeof(MeshFilter))]
public class TerrainGenerator : MonoBehaviour
{
	Mesh mesh;
	public int size = 30;
	public float scale = 20;
	public float depth = 30;

	Vector3[] vertices;
	int[] triangles;

	// Start is called before the first frame update
	void Start()
	{
		mesh = new Mesh();
		GetComponent<MeshFilter>().mesh = mesh;

		create_shape();
		update_mesh();
	}

	// proceduraly generate vertecies and triangles
	void create_shape()
	{
		// verteces
		vertices = new Vector3[(size + 1) * (size + 1)];
		for (int vert = 0, z = -size/2; z <= size/2; z++)
		{
			for (int x = -size/2; x <= size/2; x++)
			{
				vertices[vert] = new Vector3(x*size, Mathf.PerlinNoise(x * 0.2f, z * 0.2f) * depth, z*size);
				vert++;
			}
		}

		// triangles
		triangles = new int[size * size * 6];
		for (int vert = 0, tri = 0, z = 0; z < size; z++)
		{
			for (int x = 0; x < size; x++)
			{
				triangles[tri] = vert;
				triangles[tri + 1] = vert + size + 1;
				triangles[tri + 2] = vert + 1;

				triangles[tri + 3] = vert + size + 1;
				triangles[tri + 4] = vert + size + 2;
				triangles[tri + 5] = vert + 1;

				vert++;
				tri += 6;
			}
			vert++;
		}
	}

	// set mesh vertices and triangles
	void update_mesh()
	{
		mesh.Clear();

		mesh.vertices = vertices;
		mesh.triangles = triangles;

		// calculate normals for shading
		mesh.RecalculateNormals();
	}
}
