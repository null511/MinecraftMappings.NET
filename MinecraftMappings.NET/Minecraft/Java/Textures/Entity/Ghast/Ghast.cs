using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Ghast
{
    public class Ghast : JavaEntityTexture
    {
        public Ghast() : base("Ghast")
        {
            AddVersion("ghast")
                .WithPath("entity/ghast")
                .WithDefaultModel<Java.Models.Entity.Ghast>();
                //.MapsToBedrockEntity<BedrockEntities.Ghast>();
        }
    }
}
