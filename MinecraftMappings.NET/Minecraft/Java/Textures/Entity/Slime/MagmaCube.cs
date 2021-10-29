using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Slime
{
    public class MagmaCube : JavaEntityTexture
    {
        public MagmaCube() : base("Magma Cube")
        {
            AddVersion("magmacube")
                .WithPath("entity/slime")
                .WithDefaultModel<Java.Models.Entity.MagmaCube>();
                //.MapsToBedrockEntity<BedrockEntities.MagmaCube>();
        }
    }
}
