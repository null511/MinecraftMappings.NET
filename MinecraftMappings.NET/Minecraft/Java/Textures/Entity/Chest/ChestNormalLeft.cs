using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Chest
{
    public class ChestNormalLeft : JavaEntityTexture
    {
        public ChestNormalLeft() : base("Chest, Normal Left")
        {
            AddVersion("normal_left")
                .WithPath("entity/chest")
                .WithDefaultModel<Java.Models.Entity.ChestLargeLeft>();
                //.MapsToBedrockEntity<BedrockEntities.ChestNormal>();
        }
    }
}
