using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Dolphin : JavaEntityTexture
    {
        public Dolphin() : base("Dolphin")
        {
            AddVersion("dolphin")
                .WithPath("entity")
                .WithDefaultModel<Java.Models.Entity.Dolphin>();
                //.MapsToBedrockEntity<BedrockEntities.Dolphin>();
        }
    }
}
