/**
**/
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace OmniMod.Bioms{/// <summary>
/// Namensraum Biom
/// </summary>

	public class WaterfallStyle :ModWaterfallStyle{/// <summary>
	/// laesst wasserfall leuchten
	/// </summary>
	/// <param name="i"></param> x vector
	/// <param name="j"></param> y vector

	
	// Makes the waterfall provide light
		// Learn how to make a waterfall: https://terraria.wiki.gg/wiki/Waterfall
		public override void AddLight(int i, int j) =>
			Lighting.AddLight(new Vector2(i, j).ToWorldCoordinates(), Color.White.ToVector3() * 0.5f);
	
}

}