using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Models
{
    public class GoldArmor_Layer2 : JavaEntityTexture
    {
        public GoldArmor_Layer2() : base("Gold Armor, Layer 2")
        {
            AddVersion("gold_layer_2")
                .WithPath("models/armor")
                .WithDefaultModel<Java.Models.Entity.ArmorLayer2>();
                //.MapsToBedrockEntity<BedrockEntities.GoldArmor_Layer2>();
        }
    }
}
