using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Elytra : JavaEntityTexture
    {
        public Elytra() : base("Elytra")
        {
            AddVersion("elytra")
                .WithDefaultModel<Java.Models.Entity.Elytra>();
                //.MapsToBedrockEntity<BedrockEntities.Elytra>();
        }
    }
}
