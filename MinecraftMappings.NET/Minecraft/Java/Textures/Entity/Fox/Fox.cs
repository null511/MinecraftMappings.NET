using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fox
{
    public class Fox : JavaEntityTexture
    {
        public Fox() : base("Fox")
        {
            AddVersion("fox")
                .WithPath("entity/fox")
                .WithDefaultModel<Java.Models.Entity.Fox>();
                //.MapsToBedrockEntity<BedrockEntities.Fox>();
        }
    }
}
