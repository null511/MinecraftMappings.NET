using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Chest
{
    public class Chest_ChristmasLeft : JavaEntityTexture
    {
        public Chest_ChristmasLeft() : base("Chest, Christmas Left")
        {
            AddVersion("christmas_left")
                .WithPath("entity/chest")
                .WithDefaultModel<Java.Models.Entity.ChestLargeRight>();
                //.MapsToBedrockEntity<BedrockEntities.ChestChristmas>();
        }
    }
}
