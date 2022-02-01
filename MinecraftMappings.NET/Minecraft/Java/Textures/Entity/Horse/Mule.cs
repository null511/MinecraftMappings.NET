using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse
{
    public class Mule : JavaEntityTexture
    {
        public Mule() : base("Mule")
        {
            AddVersion("mule")
                .WithPath("entity/horse")
                .WithDefaultModel<Java.Models.Entity.Horse>();
                //.MapsToBedrockEntity<BedrockEntities.Mule>();
        }
    }
}
