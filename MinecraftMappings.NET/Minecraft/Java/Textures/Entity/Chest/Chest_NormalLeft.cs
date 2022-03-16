using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Chest
{
    public class Chest_NormalLeft : JavaEntityTexture
    {
        public Chest_NormalLeft() : base("Chest, Normal Left")
        {
            AddVersion("normal_left")
                .WithPath("entity/chest")
                .WithDefaultModel<Java.Models.Entity.ChestLargeLeft>();
                //.MapsToBedrockEntity<BedrockEntities.ChestNormal>();
        }
    }
}
