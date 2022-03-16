using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Silverfish : JavaEntityTexture
    {
        public Silverfish() : base("Silverfish")
        {
            AddVersion("silverfish")
                .WithPath("entity")
                .WithDefaultModel<Java.Models.Entity.Silverfish>();
                //.MapsToBedrockEntity<BedrockEntities.Silverfish>();
        }
    }
}
