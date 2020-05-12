using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class ChunkLoader : MonoBehaviour
{
	[SerializeField]
	public List<Chunk> loaded_chunks;
	
	int lc_dim_size;
	int lc_size;

	public int r_seed = 1;
	public int render_distance = 5;
	public int c_size = 30;
	public int c_subs = 10;
	public float c_depth = 30f;
	public float terrain_frequency = 0.01f;

	public Material mat;

	// Start is called before the first frame update
	void Start()
	{
		loaded_chunks = new List<Chunk>();
		lc_dim_size = (render_distance*2 + 1);
		lc_size = lc_dim_size;

		for(int z = -lc_dim_size/2; z <= lc_dim_size/2; z++){
			for(int x = -lc_dim_size/2; x <= lc_dim_size/2; x++){
				GameObject new_load_obj = new GameObject();
				new_load_obj.layer = 8;

				Chunk new_load = new_load_obj.AddComponent(typeof(Chunk)) as Chunk;
				new_load.setup(new_load_obj, r_seed, x, z, c_size, c_subs, c_depth, terrain_frequency, mat);
				
				loaded_chunks.Add(new_load);
			}
		}
	}
}
