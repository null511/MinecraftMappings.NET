using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Steve : JavaEntityTexture
    {
        public Steve() : base("Steve")
        {
            AddVersion("steve")
                .WithPath("entity")
                .WithDefaultModel<Java.Models.Entity.Player>();
                //.MapsToBedrockEntity<BedrockEntities.Steve>();
        }
    }
}
