using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Guardian : JavaEntityTexture
    {
        public Guardian() : base("Guardian")
        {
            AddVersion("guardian")
                .WithDefaultModel<Java.Models.Entity.Guardian>();
                //.MapsToBedrockEntity<BedrockEntities.Guardian>();
        }
    }
}
