using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class EnchantingTableBook : JavaEntityTexture
    {
        public EnchantingTableBook() : base("Enchanting Table Book")
        {
            AddVersion("enchanting_table_book")
                .WithDefaultModel<Java.Models.Entity.EnchantingBook>();
                //.MapsToBedrockEntity<BedrockEntities.SnowGolem>();
        }
    }
}
