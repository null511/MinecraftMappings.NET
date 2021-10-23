using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Bee
{
    public class Bee : JavaEntityTexture
    {
        public Bee() : base("Bee")
        {
            AddVersion("bee")
                .WithDefaultModel<Java.Models.Entity.Bee>();
                //.MapsToBedrockEntity<BedrockEntities.Bee>();
        }
    }
}
