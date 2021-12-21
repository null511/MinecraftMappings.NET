using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Chest
{
    public class ChestChristmasLeft : JavaEntityTexture
    {
        public ChestChristmasLeft() : base("Chest, Christmas Left")
        {
            AddVersion("christmas_left")
                .WithPath("entity/chest")
                .WithDefaultModel<Java.Models.Entity.ChestLargeLeft>();
                //.MapsToBedrockEntity<BedrockEntities.ChestChristmas>();
        }
    }
}
