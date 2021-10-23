using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Boat
{
    public class SpruceBoat : JavaEntityTexture
    {
        public SpruceBoat() : base("Spruce Boat")
        {
            AddVersion("spruce")
                .WithPath("entity/boat")
                .WithMinVersion("1.9")
                .WithDefaultModel<Java.Models.Entity.Boat>();
                //.MapsToBedrockEntity<BedrockEntities.SpruceBoat>();
        }
    }
}
