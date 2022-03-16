using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Endermite : JavaEntityTexture
    {
        public Endermite() : base("Endermite")
        {
            AddVersion("endermite")
                .WithPath("entity")
                .WithMinVersion("1.8")
                .WithDefaultModel<Java.Models.Entity.Endermite>();
                //.MapsToBedrockEntity<BedrockEntities.Endermite>();
        }
    }
}
