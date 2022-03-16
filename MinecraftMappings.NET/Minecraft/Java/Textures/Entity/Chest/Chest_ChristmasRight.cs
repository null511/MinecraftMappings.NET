using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Chest
{
    public class Chest_ChristmasRight : JavaEntityTexture
    {
        public Chest_ChristmasRight() : base("Chest, Christmas Right")
        {
            AddVersion("christmas_right")
                .WithPath("entity/chest")
                .WithDefaultModel<Java.Models.Entity.ChestLargeRight>();
                //.MapsToBedrockEntity<BedrockEntities.ChestChristmas>();
        }
    }
}
