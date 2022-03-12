using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Villager
{
    public class Villager : JavaEntityTexture
    {
        public Villager() : base("Villager")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("villager")
                .WithPath("entity/villager")
                .WithDefaultModel<Java.Models.Entity.Villager>();
                //.MapsToBedrockEntity<BedrockEntities.Villager>();
        }
    }
}
