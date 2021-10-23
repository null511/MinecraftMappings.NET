using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Bell
{
    public class BellBody : JavaEntityTexture
    {
        public BellBody() : base("Bell Body")
        {
            AddVersion("bell_body")
                .WithDefaultModel<Java.Models.Entity.BellBody>();
                //.MapsToBedrockEntity<BedrockEntities.BellBody>();
        }
    }
}
