using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Wolf
{
    public class Wolf : JavaEntityTexture
    {
        public Wolf() : base("Wolf")
        {
            AddVersion("wolf")
                .WithPath("entity/wolf")
                .WithDefaultModel<Java.Models.Entity.Wolf>();
                //.MapsToBedrockEntity<BedrockEntities.Wolf>();
        }
    }
}
