using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class SnowGolem : JavaEntityTexture
    {
        public SnowGolem() : base("Snow Golem")
        {
            AddVersion("snow_golem")
                .WithDefaultModel<Java.Models.Entity.SnowGolem>();
                //.MapsToBedrockEntity<BedrockEntities.SnowGolem>();
        }
    }
}
