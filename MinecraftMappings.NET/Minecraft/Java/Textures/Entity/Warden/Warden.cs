using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Warden
{
    public class Warden : JavaEntityTexture
    {
        public Warden() : base("Warden")
        {
            AddVersion("warden")
                .WithPath("entity/warden")
                .WithDefaultModel<Java.Models.Entity.Warden>();
                //.MapsToBedrockEntity<BedrockEntities.Warden>();
        }
    }
}
