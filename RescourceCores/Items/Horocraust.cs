using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RescourceCores.Items
{
	public class Horocraust : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Horocraust"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a basic modded sword.");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.value = 100000000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.maxStack = 999;
			item.useTime = 20;
			item.useAnimation = 20;
			item.createTile = mod.TileType("Horocraust");
			item.noUseGraphic = true;
		}

		public void AddRecipesFunc(ModRecipe name , int itemonename, int itemoneamount, int craftingtile, int result)
		{
			name = new ModRecipe(mod);
			name.AddIngredient(itemonename, itemoneamount);
			name.AddTile(craftingtile);
			name.SetResult(result);
			name.AddRecipe();
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 100);
			recipe.AddIngredient(ItemID.Wood, 100);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();

			ModRecipe recipetwo = new ModRecipe(mod);
			recipetwo.AddIngredient(this);
			recipetwo.AddIngredient(ItemID.Emerald, 2);
			recipetwo.AddTile(TileID.WorkBenches);
			recipetwo.SetResult(ItemID.Emerald, 10);
			recipetwo.AddRecipe();

			ModRecipe recipethree = new ModRecipe(mod);
			recipethree.AddIngredient(this);
			recipethree.AddIngredient(ItemID.Diamond, 2);
			recipethree.AddTile(TileID.WorkBenches);
			recipethree.SetResult(ItemID.Diamond, 10);
			recipethree.AddRecipe();

			ModRecipe a = new ModRecipe(mod);
			a.AddIngredient(this);
			a.AddIngredient(ItemID.TungstenBar, 2);
			a.AddTile(TileID.WorkBenches);
			a.SetResult(ItemID.TungstenBar, 10);
			a.AddRecipe();

			ModRecipe b = new ModRecipe(mod);
			b.AddIngredient(this);
			b.AddIngredient(ItemID.LeadBar, 2);
			b.AddTile(TileID.WorkBenches);
			b.SetResult(ItemID.LeadBar, 10);
			b.AddRecipe();

			ModRecipe c = new ModRecipe(mod);
			c.AddIngredient(this);
			c.AddIngredient(ItemID.Topaz, 2);
			c.AddTile(TileID.WorkBenches);
			c.SetResult(ItemID.Topaz, 10);
			c.AddRecipe();

			ModRecipe d = new ModRecipe(mod);
			d.AddIngredient(ItemID.Wood, 20);
			d.AddIngredient(ItemID.StoneBlock, 20);
			d.AddTile(TileID.Anvils);
			d.SetResult(ItemID.Wood, 100);
			d.AddRecipe();

			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ItemID.Wood, 20);
			r.AddIngredient(ItemID.StoneBlock, 20);
			r.AddTile(TileID.Anvils);
			r.SetResult(ItemID.StoneBlock, 100);
			r.AddRecipe();

			ModRecipe rA = new ModRecipe(mod);
			rA.AddIngredient(ItemID.LeadAnvil, 1);
			rA.AddIngredient(ItemID.TungstenBar, 50);
			rA.AddTile(TileID.Anvils);
			rA.SetResult(ItemID.DemoniteBar, 10);
			rA.AddRecipe();

			ModRecipe dA = new ModRecipe(mod);
			dA.AddIngredient(ItemID.FallenStar, 1);
			dA.AddIngredient(this);
			dA.AddIngredient(ItemID.Gel, 50);
			dA.AddTile(TileID.CookingPots);
			dA.SetResult(ItemID.SlimeCrown, 1);
			dA.AddRecipe();

			ModRecipe l = new ModRecipe(mod);
			l.AddIngredient(ItemID.FallenStar, 1);
			l.AddIngredient(this);
			l.AddIngredient(ItemID.Obelisk, 1);
			l.AddTile(TileID.CookingPots);
			l.SetResult(ItemID.LifeCrystal, 1);
			l.AddRecipe();

			ModRecipe la = new ModRecipe(mod);
			la.AddIngredient(ItemID.FallenStar, 1);
			la.AddIngredient(this);
			la.AddIngredient(ItemID.GraveMarker, 1);
			la.AddTile(TileID.CookingPots);
			la.SetResult(ItemID.Gel, 90);
			la.AddRecipe();

			ModRecipe laf = new ModRecipe(mod);
			laf.AddIngredient(ItemID.FallenStar, 1);
			laf.AddIngredient(this);
			laf.AddIngredient(ItemID.Tombstone, 1);
			laf.AddTile(TileID.Anvils);
			laf.SetResult(ItemID.Obelisk, 1);
			laf.AddRecipe();

			ModRecipe GoldenCrown = new ModRecipe(mod);
			GoldenCrown.AddIngredient(ItemID.SlimeCrown, 1);
			GoldenCrown.AddIngredient(this);
			GoldenCrown.AddIngredient(ItemID.FallenStar, 1);
			GoldenCrown.AddTile(TileID.CookingPots);
			GoldenCrown.SetResult(ItemID.GoldCrown, 1);
			GoldenCrown.AddRecipe();

			ModRecipe DemonAltar = new ModRecipe(mod);
			DemonAltar.AddIngredient(ItemID.SlimeCrown, 5);
			DemonAltar.AddIngredient(this, 2);
			DemonAltar.AddIngredient(ItemID.DemoniteBar, 10);
			DemonAltar.AddTile(TileID.CookingPots);
			DemonAltar.SetResult(ItemID.CrownosWings, 1);
			DemonAltar.AddRecipe();

			ModRecipe DemonAltr = new ModRecipe(mod);
			DemonAltr.AddIngredient(ItemID.VilePowder, 5);
			DemonAltr.AddIngredient(this);
			DemonAltr.AddIngredient(ItemID.DemoniteBar, 10);
			DemonAltr.AddTile(TileID.CookingPots);
			DemonAltr.SetResult(ItemID.WormFood, 1);
			DemonAltr.AddRecipe();

			ModRecipe BigBombs = new ModRecipe(mod);
			BigBombs.AddIngredient(ItemID.TungstenBar, 2);
			BigBombs.AddIngredient(this);
			BigBombs.AddTile(TileID.WorkBenches);
			BigBombs.SetResult(ItemID.Bomb, 10);
			BigBombs.AddRecipe();

			ModRecipe BigBombse = new ModRecipe(mod);
			BigBombse.AddIngredient(ItemID.TungstenBar, 5);
			BigBombse.AddIngredient(this);
			BigBombse.AddTile(TileID.WorkBenches);
			BigBombse.SetResult(ItemID.Dynamite, 10);
			BigBombse.AddRecipe();

			ModRecipe ad = new ModRecipe(mod);
			ad.AddIngredient(ItemID.LifeCrystal, 1);
			ad.AddIngredient(ItemID.ManaCrystal, 1);
			ad.AddIngredient(this);
			ad.AddTile(TileID.WorkBenches);
			ad.SetResult(ItemID.FallenStar, 99);
			ad.AddRecipe();
		}
	}
}
