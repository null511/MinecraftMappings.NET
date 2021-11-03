using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Phantom : JavaEntityTexture
    {
        public Phantom() : base("Phantom")
        {
            AddVersion("phantom")
                .WithDefaultModel<Java.Models.Entity.Phantom>();
                //.MapsToBedrockEntity<BedrockEntities.Phantom>();
        }
    }
}
