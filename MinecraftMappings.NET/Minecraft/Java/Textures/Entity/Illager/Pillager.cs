using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Illager
{
    public class Pillager : JavaEntityTexture
    {
        public Pillager() : base("Pillager")
        {
            AddVersion("pillager")
                .WithPath("entity/illager")
                .WithDefaultModel<Java.Models.Entity.Pillager>();
                //.MapsToBedrockEntity<BedrockEntities.Pillager>();
        }
    }
}
