using Terraria.ModLoader;
using Terraria.ID;

namespace RescourceCores.Items
{
	[AutoloadEquip(EquipType.Body)]
	internal class ExampleRobe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Studded Leather Robes"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Reinforced leather robes.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 14;
			item.rare = 8;
			item.defense = 20;
		}

		public override void SetMatch(bool male, ref int equipSlot, ref bool robes) {
			robes = true;
			// The equipSlot is added in ExampleMod.cs --> Load hook
			equipSlot = mod.GetEquipSlot("ExampleRobe_Legs", EquipType.Legs);
		}

		public override void DrawHands(ref bool drawHands, ref bool drawArms) {
			drawHands = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 10);
			recipe.AddIngredient(ItemID.Leather, 5);
			recipe.AddIngredient(ItemID.TungstenBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}
