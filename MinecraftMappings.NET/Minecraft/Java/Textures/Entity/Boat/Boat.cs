using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Boat
{
    public class Boat : JavaEntityTexture
    {
        public Boat() : base("Boat")
        {
            AddVersion("boat")
                .WithPath("entity")
                .WithMaxVersion("1.9")
                .WithDefaultModel<Java.Models.Entity.Boat>();
                //.MapsToBedrockEntity<BedrockEntities.Boat>();
        }
    }
}
