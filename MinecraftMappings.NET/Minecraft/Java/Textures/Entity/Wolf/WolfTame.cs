using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Wolf
{
    public class WolfTame : JavaEntityTexture
    {
        public WolfTame() : base("Wolf, Tame")
        {
            AddVersion("wolf_tame")
                .WithPath("entity/wolf")
                .WithDefaultModel<Java.Models.Entity.Wolf>();
                //.MapsToBedrockEntity<BedrockEntities.WolfTame>();
        }
    }
}
