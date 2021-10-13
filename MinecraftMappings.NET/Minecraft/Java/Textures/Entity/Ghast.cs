using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Ghast : JavaEntityTexture
    {
        public Ghast() : base("Ghast")
        {
            AddVersion("ghast")
                .WithDefaultModel<Java.Models.Entity.Ghast>();
                //.MapsToBedrockEntity<BedrockEntities.Bee>();
        }
    }
}
