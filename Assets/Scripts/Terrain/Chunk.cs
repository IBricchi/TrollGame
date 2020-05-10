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
		// verteces
		vertices = new Vector3[(subs + 1) * (subs + 1)];
		for(int vert = 0, z = 0; z <= subs; z++){
			for(int x = 0; x <= subs; x++){
				vertices[vert] = new Vector3(
					c_x * size + x * size / (float)subs,
					noise(c_x * size + x * size / (float)subs, c_z * size + z * size / (float)subs),
					c_z * size + z * size / (float)subs
				);
				vert++;
			}
		}

		// triangles
		triangles = new int[subs * subs * 6];
		for(int vert = 0, tri = 0, z = 0; z < subs; z++){
			for(int x = 0; x < subs; x++){
				triangles[tri] = vert;
				triangles[tri + 1] = vert + subs + 1;
				triangles[tri + 2] = vert + 1;

				triangles[tri + 3] = vert + subs + 1;
				triangles[tri + 4] = vert + subs + 2;
				triangles[tri + 5] = vert + 1;

				vert++;
				tri += 6;
			}
			vert++;
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
