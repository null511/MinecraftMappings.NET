using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Chicken : JavaEntityTexture
    {
        public Chicken() : base("Chicken")
        {
            AddVersion("chicken")
                .WithPath("entity")
                .WithDefaultModel<Java.Models.Entity.Chicken>();
                //.MapsToBedrockEntity<BedrockEntities.Chicken>();
        }
    }
}
