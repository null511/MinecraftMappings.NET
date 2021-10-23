using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Boat
{
    public class JungleBoat : JavaEntityTexture
    {
        public JungleBoat() : base("Jungle Boat")
        {
            AddVersion("jungle")
                .WithPath("entity/boat")
                .WithMinVersion("1.9")
                .WithDefaultModel<Java.Models.Entity.Boat>();
                //.MapsToBedrockEntity<BedrockEntities.JungleBoat>();
        }
    }
}
