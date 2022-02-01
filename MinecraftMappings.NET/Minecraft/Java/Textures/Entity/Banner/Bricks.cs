using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Banner
{
    public class Bricks : JavaEntityTexture
    {
        public Bricks() : base("Banner, Bricks")
        {
            AddVersion("bricks")
                .WithPath("entity/banner")
                .WithDefaultModel<Java.Models.Entity.Banner>();
                //.MapsToBedrockEntity<BedrockEntities.Witch>();
        }
    }
}
