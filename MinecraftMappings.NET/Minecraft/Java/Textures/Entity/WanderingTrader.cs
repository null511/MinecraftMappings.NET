using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class WanderingTrader : JavaEntityTexture
    {
        public WanderingTrader() : base("Wandering Trader")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("wandering_trader")
                .WithPath("entity/wandering_trader")
                .WithDefaultModel<Java.Models.Entity.WanderingTrader>();
                //.MapsToBedrockEntity<BedrockEntities.Villager>();
        }
    }
}
