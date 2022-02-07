using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Illager
{
    public class Ravager : JavaEntityTexture
    {
        public Ravager() : base("Ravager")
        {
            AddVersion("ravager")
                .WithPath("entity/illager")
                .WithDefaultModel<Java.Models.Entity.Ravager>();
                //.MapsToBedrockEntity<BedrockEntities.Ravager>();
        }
    }
}
