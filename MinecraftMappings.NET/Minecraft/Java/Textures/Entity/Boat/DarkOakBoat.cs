using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Boat
{
    public class DarkOakBoat : JavaEntityTexture
    {
        public DarkOakBoat() : base("Dark Oak Boat")
        {
            AddVersion("dark_oak")
                .WithPath("entity/boat")
                .WithMinVersion("1.9")
                .WithDefaultModel<Java.Models.Entity.Boat>();
                //.MapsToBedrockEntity<BedrockEntities.DarkOakBoat>();
        }
    }
}
