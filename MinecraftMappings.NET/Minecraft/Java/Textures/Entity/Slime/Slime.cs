using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Slime
{
    public class Slime : JavaEntityTexture
    {
        public Slime() : base("Slime")
        {
            AddVersion("slime")
                .WithPath("entity/slime")
                .WithDefaultModel<Java.Models.Entity.Slime>();
                //.MapsToBedrockEntity<BedrockEntities.Slime>();
        }
    }
}
