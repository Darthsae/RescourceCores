using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace RescourceCores.Tiles
{
	public class Horocraust : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			drop = mod.ItemType("Horocraust");
			AddMapEntry(new Color(200, 200, 200));
		}
	}
}