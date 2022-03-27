using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Models
{
    public class GoldArmor_Layer1 : JavaEntityTexture
    {
        public GoldArmor_Layer1() : base("Gold Armor, Layer 1")
        {
            AddVersion("gold_layer_1")
                .WithPath("models/armor")
                .WithDefaultModel<Java.Models.Entity.ArmorLayer1>();
                //.MapsToBedrockEntity<BedrockEntities.GoldArmor_Layer1>();
        }
    }
}
