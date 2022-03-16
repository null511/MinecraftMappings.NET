using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Illager
{
    public class Evoker : JavaEntityTexture
    {
        public Evoker() : base("Evoker")
        {
            AddVersion("evoker")
                .WithPath("entity/illager")
                .WithDefaultModel<Java.Models.Entity.Evoker>();
                //.MapsToBedrockEntity<BedrockEntities.Evoker>();
        }
    }
}
