using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Pig
{
    public class Pig : JavaEntityTexture
    {
        public Pig() : base("Pig")
        {
            AddVersion("pig")
                .WithPath("entity/pig")
                .WithDefaultModel<Java.Models.Entity.Pig>();
                //.MapsToBedrockEntity<BedrockEntities.Pig>();
        }
    }
}
