using OmniMod.Items.Dusts;
using OmniMod.Bioms;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;


namespace OmniMod.Tiles{

    public class OmniBlock : ModTile{

    
        public class ExampleBlock : ModTile
	{
		public override void SetStaticDefaults() {
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;

			DustType = ModContent.DustType<StarOne>();

			AddMapEntry(new Color(200, 200, 200));
		}

		public override void NumDust(int i, int j, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}

		 public override void ChangeWaterfallStyle(ref int style) {
			style = ModContent.GetInstance<WaterfallStyle>().Slot;
		}
    
    }


}}
