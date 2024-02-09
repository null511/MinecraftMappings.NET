using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Warden
{
    public class Warden_Heart : JavaEntityTexture
    {
        public Warden_Heart() : base("Warden, Heart")
        {
            AddVersion("warden_heart")
                .WithPath("entity/warden")
                .WithDefaultModel<Java.Models.Entity.Warden>();
                //.MapsToBedrockEntity<BedrockEntities.Warden>();
        }
    }
}
