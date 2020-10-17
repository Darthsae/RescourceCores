using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RescourceCores.Items
{
	public class StarCutter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Cutter"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a legendary sword forged with materials from beyond the mortal world.");
		}

		public override void SetDefaults()
		{
			item.damage = 150;
			item.width = 40;
			item.height = 40;
			item.useTime = 1;
			item.useAnimation = 1;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 200000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override bool AltFunctionUse(Player player)//You use this to allow the item to be right clicked
		{
			return true;
		}

		public override void HoldItem(Player player)
		{
			Vector2 position = player.RotatedRelativePoint(new Vector2(player.itemLocation.X + 12f * player.direction + player.velocity.X, player.itemLocation.Y - 14f + player.velocity.Y), true);
			Lighting.AddLight(position, 1f, 1f, 1f);
		}

		public override bool CanUseItem(Player player)
		{

			if (player.altFunctionUse == 2)//Sets what happens on right click(special ability)
			{
				item.damage = 100;
				item.melee = false;
				item.width = 40;
				item.height = 40;
				item.useTime = 30;
				item.useAnimation = 10;
				item.useStyle = 5;
				item.knockBack = 2;
				item.value = 200000;
				item.rare = 10;
				item.UseSound = SoundID.Item1;
				item.autoReuse = true;
				item.shoot = mod.ProjectileType("Storian");
				item.shootSpeed = 25f;

			}
			else //Sets what happens on left click(normal use)
			{
				item.damage = 150;
				item.melee = true;
				item.width = 40;
				item.height = 40;
				item.useTime = 10;
				item.useAnimation = 10;
				item.useStyle = 1;
				item.knockBack = 2;
				item.value = 200000;
				item.rare = 10;
				item.UseSound = SoundID.Item1;
				item.autoReuse = true;
				item.shoot = 0;
				item.shootSpeed = 0f;

			}

			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 99);
			recipe.AddIngredient(ItemID.Wood, 999);
			recipe.AddIngredient(ItemID.TungstenBar, 99);
			recipe.AddIngredient(ItemID.LeadBar, 99);
			recipe.AddIngredient(ItemID.FallenStar, 99);
			recipe.AddIngredient(ItemID.StoneBlock, 999);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}