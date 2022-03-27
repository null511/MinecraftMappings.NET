using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Models
{
    public class DiamondArmor_Layer2 : JavaEntityTexture
    {
        public DiamondArmor_Layer2() : base("Diamond Armor, Layer 2")
        {
            AddVersion("diamond_layer_2")
                .WithPath("models/armor")
                .WithDefaultModel<Java.Models.Entity.ArmorLayer2>();
                //.MapsToBedrockEntity<BedrockEntities.DiamondArmor_Layer2>();
        }
    }
}
