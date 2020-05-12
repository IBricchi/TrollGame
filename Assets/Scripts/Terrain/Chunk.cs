using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
	Mesh mesh;
	MeshRenderer mr;
	MeshFilter mf;
	MeshCollider mc;

	int c_x;
	int c_z;
	int r_seed;
	float size;
	int subs;
	float depth;
	float freq;

	Vector3[] vertices;
	int[] triangles;

	public void setup(GameObject chunk_obj, int _r_seed, int x, int z, float _size, int _subs, float _depth, float _freq, Material mat)
	{
		mesh = new Mesh();

		mr = chunk_obj.AddComponent<MeshRenderer>();
		mr.material = mat;

		mf = chunk_obj.AddComponent<MeshFilter>();
		mf.mesh = mesh;

		mc = chunk_obj.AddComponent<MeshCollider>();

		c_x = x;
		c_z = z;
		r_seed = _r_seed;
		size = _size;
		subs = _subs;
		depth = _depth;
		freq = _freq;

		create_shape();
		update_mesh();
	}

	void create_shape(){
		// triangles with flat shading
		vertices = new Vector3[subs * subs * 6];
		triangles = new int[subs * subs * 6];
		for (int i = 0, z = 0; z < subs; z++)
		{
			for (int x = 0; x < subs; x++)
			{
				// setup one square in mesh, which has 2 trianges

				// setup vertices
				vertices[i] = new Vector3(c_x * size + x * size / (float)subs, 0, c_z * size + z * size / (float)subs);
				vertices[i + 1] = new Vector3(c_x * size + x * size / (float)subs, 0, c_z * size + (z + 1) * size / (float)subs);
				vertices[i + 2] = new Vector3(c_x * size + (x + 1) * size / (float)subs, 0, c_z * size + (z + 1) * size / (float)subs);
				vertices[i + 3] = new Vector3(c_x * size + x * size / (float)subs, 0, c_z * size + z * size / (float)subs);
				vertices[i + 4] = new Vector3(c_x * size + (x + 1) * size / (float)subs, 0, c_z * size + (z + 1) * size / (float)subs);
				vertices[i + 5] = new Vector3(c_x * size + (x + 1) * size / (float)subs, 0, c_z * size + z * size / (float)subs);


				for (int j = 0; j < 6; j++)
				{
					// setup vertices hight with noise
					vertices[i + j].y = noise(vertices[i + j].x, vertices[i + j].z);

					// setup triangles
					triangles[i + j] = i + j;
				}
				i += 6;
			}
		}
	}

	void update_mesh(){
		mesh.Clear();

		mesh.vertices = vertices;
		mesh.triangles = triangles;

		// calculate normals for shading
		mesh.RecalculateNormals();

		// set mesh collider for collisions <- no shit Sherlock
		// must be at end so added only once mesh has been created properly
		mc.sharedMesh = mesh;
	}

	float noise(float a, float b){
		return Mathf.PerlinNoise((a + r_seed) * freq, (b + r_seed) * freq) * depth;
	}
}
