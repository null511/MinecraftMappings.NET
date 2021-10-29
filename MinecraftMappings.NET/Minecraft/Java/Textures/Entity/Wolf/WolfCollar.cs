using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Wolf
{
    public class WolfCollar : JavaEntityTexture
    {
        public WolfCollar() : base("Wolf, Collar")
        {
            AddVersion("wolf_collar")
                .WithPath("entity/wolf")
                .WithBaseLayer<Wolf>()
                .WithDefaultModel<Java.Models.Entity.Wolf>();
                //.MapsToBedrockEntity<BedrockEntities.WolfCollar>();
        }
    }
}
