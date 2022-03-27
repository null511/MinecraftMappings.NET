using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Models
{
    public class DiamondArmor_Layer1 : JavaEntityTexture
    {
        public DiamondArmor_Layer1() : base("Diamond Armor, Layer 1")
        {
            AddVersion("diamond_layer_1")
                .WithPath("models/armor")
                .WithDefaultModel<Java.Models.Entity.ArmorLayer1>();
                //.MapsToBedrockEntity<BedrockEntities.DiamondArmor_Layer1>();
        }
    }
}
