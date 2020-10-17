using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RescourceCores.Projectiles
{
	public class Storian : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Storian");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.ranged = true;
		}

		// Additional hooks/methods here.
	}
}