using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Chest
{
    public class ChestChristmasRight : JavaEntityTexture
    {
        public ChestChristmasRight() : base("Chest, Christmas Right")
        {
            AddVersion("christmas_right")
                .WithPath("entity/chest")
                .WithDefaultModel<Java.Models.Entity.ChestLargeRight>();
                //.MapsToBedrockEntity<BedrockEntities.ChestChristmas>();
        }
    }
}
